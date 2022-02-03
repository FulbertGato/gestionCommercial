using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using gestion_com_2022.utils.Forms;
using gestion_com_2022.utils.ImageG;
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
            textSeuilStock.Clear();
            txtStock.Clear();
            txtbPrix.Clear();
            btnUploadImage.Image = null;

        }

        private void ProduitGestions_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadDataGridView();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String libelle = txtbLibelle.Text.Trim();
            String description = textDescription.Text.Trim();
            String SeuilStock = textSeuilStock.Text;
            String stock = txtStock.Text;
            String prix = txtbPrix.Text;
           
            int idCategorie = int.Parse(cboCategorie.SelectedValue.ToString());
            if (string.IsNullOrEmpty(libelle) || string.IsNullOrEmpty(description)
                || string.IsNullOrEmpty(SeuilStock) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(prix))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (this.fileName == null)
                {
                    MessageBox.Show("Choississez une image zebi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Images images = new Images
                    {
                        ImageByte = MyImage.convertImageToByte(this.fileName)[0]
                    };

                    List<Images> imagesList = new List<Images>();


                    imagesList.Add(images);
                    Produit produit = new Produit
                    {
                        Libelle = libelle,
                        Description = description,
                        SeuilStock = int.Parse(SeuilStock),
                        Stock = int.Parse(stock),
                        Prix = double.Parse(prix),
                        CategorieId = idCategorie,
                        Images = imagesList,
                        Code = generateCode(),


                    };

                    if (service.addProduit(produit) != 0)
                    {
                        MessageBox.Show("Utilisateur insérée avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataGridView();
                        clearFields();
                    }
                } 
            }
        }

        public string generateCode()
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();

            // Debug.WriteLine("Your UUID is: " + myuuidAsString);
            return myuuidAsString;
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

        private void loadDataGridView()
        {
            dtgvProduits.AutoGenerateColumns = false;
            List< Produit> listProduits = new List<Produit>();

            // DataTable catesLis = new DataTable();
            System.Data.Entity.DbSet<Produit> catesLis = service.showAllProduits();
            foreach (Produit prod in catesLis)
            {
                listProduits.Add(prod);
            }
            dtgvProduits.DataSource = listProduits;
        }
        private int id;
        private void choixProduit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvProduits.Rows.Count - 1)
            {

                FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.UPDEL);
                DataGridViewRow row = dtgvProduits.Rows[e.RowIndex];
                row.Selected = true;
                id = int.Parse(row.Cells[0].Value.ToString());
                
                txtbLibelle.Text = row.Cells[1].Value.ToString();
                textDescription.Text = row.Cells[6].Value.ToString();
                textSeuilStock.Text = row.Cells[5].Value.ToString();
                txtStock.Text = row.Cells[4].Value.ToString();
                txtbPrix.Text = row.Cells[3].Value.ToString();



            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            String libelle = txtbLibelle.Text.Trim();
            String description = textDescription.Text.Trim();
            String SeuilStock = textSeuilStock.Text;
            String stock = txtStock.Text;
            String prix = txtbPrix.Text;
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
                    Id = this.id,
                    Libelle = libelle,
                    Description = description,
                    SeuilStock = int.Parse(SeuilStock),
                    Stock = int.Parse(stock),
                    Prix = double.Parse(prix),
                    CategorieId = idCategorie,
                };

                if (service.EditProduit(produit) != 0)
                {
                    MessageBox.Show("Utilisateur Modifier avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                }
            }
        }
    }
}
