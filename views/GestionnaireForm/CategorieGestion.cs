using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using gestion_com_2022.utils.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com_2022.views.GestionnaireForm
{
    public enum Action { ADD, UPDATE, DELETE, UPDEL };
    public partial class CategorieGestion : Form
    {
        
        IService service = Fabrique.getInstanceService();
        public CategorieGestion()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            dtgvCategories.AutoGenerateColumns = false;
            List<Categorie> listCategories = new List<Categorie>();

            // DataTable catesLis = new DataTable();
            System.Data.Entity.DbSet<Categorie> catesLis = service.showAllCategories();
            foreach (Categorie cate in catesLis)
            {
                listCategories.Add(cate);
            }
            dtgvCategories.DataSource = listCategories;
        }

        private void CategorieGestion_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String libelle = txtbLibelle.Text.Trim();
            String description = textDescription.Text.Trim();
            if(string.IsNullOrEmpty(libelle) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categorie cat = new Categorie
                {
                    Code = generateCode(),
                    Libelle = libelle

                };
                if (service.addCategorie(cat) != 0)
                {
                    MessageBox.Show("Categorie ajouter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                }

            }
        }

        public string  generateCode()
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();

            // Debug.WriteLine("Your UUID is: " + myuuidAsString);
            return myuuidAsString;
        }

        private int id;
        private string code;
        private void dtgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvCategories.Rows.Count - 1)
            {

                FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.UPDEL);
                DataGridViewRow row = dtgvCategories.Rows[e.RowIndex];
                row.Selected = true;
                id = int.Parse(row.Cells[0].Value.ToString());
                code = row.Cells[1].Value.ToString();
                txtbLibelle.Text = row.Cells[2].Value.ToString();
                textDescription.Text = "desole c'etait pas enregistrer";


            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            String libelle = txtbLibelle.Text.Trim();
            String description = textDescription.Text.Trim();
            if (string.IsNullOrEmpty(libelle) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categorie cat = new Categorie
                {
                    Id = id,
                    Code= code,
                    Libelle = libelle

                };
                if (service.editCategorie(cat) != 0)
                {
                    MessageBox.Show("Categorie Modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                    clearFields();
                }

            }
        }
    }
}
