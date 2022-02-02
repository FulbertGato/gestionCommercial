using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using gestion_com_2022.utils.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com_2022.views.GestionnaireForm
{
   // public enum Action { ADD, UPDATE, DELETE, UPDEL };
    public partial class ProduitGestions : Form
    {

        
        IService service = Fabrique.getInstanceService();
        public ProduitGestions()
        {
            InitializeComponent();
        }
        private void loadComboBox()
        {
            List<Categorie> listCategories = new List<Categorie>();

            // DataTable catesLis = new DataTable();
            System.Data.Entity.DbSet<Categorie> catesLis = service.showAllCategories();
            foreach (Categorie cate in catesLis)
            {
                listCategories.Add(cate);
            }

            cboCategorie.DataSource = listCategories;
            cboCategorie.DisplayMember = "Libelle";
            cboCategorie.ValueMember = "Id";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearFields();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }
        private void clearFields()
        {
            txtbLibelle.Clear();
            textDescription.Clear();

        }

        private void ProduitGestions_Load(object sender, EventArgs e)
        {
            loadComboBox();
           // loadDataGridView();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String libelle = txtbLibelle.Text.Trim();
            String description = textDescription.Text.Trim();
            String SeuilStock = textSeuilStock.Text;
            String stock = txtStock.Text;
            String prix = txtbPrix.Text;
            byte[] images = convertImageToByte(this.fileName);
            int idCategorie = int.Parse(cboCategorie.SelectedValue.ToString());
            if (string.IsNullOrEmpty(libelle) || string.IsNullOrEmpty(description)
                || string.IsNullOrEmpty(SeuilStock) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(prix))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Produit produit = new Produit
                {
                    Libelle = libelle,
                    Description = description,
                    SeuilStock = int.Parse(SeuilStock),
                    Stock = int.Parse(stock),
                    Prix = double.Parse(prix),
                    CategorieId = idCategorie,
                  //  imageProduit = images
                };

                if (service.addProduit(produit) != 0)
                {
                    MessageBox.Show("Utilisateur insérée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //loadDataGridView();
                    clearFields();
                }
            }
        }


        public static byte[] convertImageToByte(string fileName)
        {
            using (Image image = Image.FromFile(fileName))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }

        }

        public static Image convertByteToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        private string fileName;
        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "*.jpg files (*.jpg)|*jpg|.jpeg files (*.jpeg)|*jpeg|.png files (*.png)|*png";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    btnUploadImage.Image = Image.FromFile(dialog.FileName);
                    this.fileName = dialog.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
