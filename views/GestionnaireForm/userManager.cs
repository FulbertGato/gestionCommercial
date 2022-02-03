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
    public partial class userManager : Form
    {
        IService service = Fabrique.getInstanceService();
        public userManager()
        {
            InitializeComponent();
        }

        private void userManager_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadComboBox();
        }


        private void loadDataGridView()
        {
            dtgvUtilisateurs.AutoGenerateColumns = false;
            dtgvUtilisateurs.DataSource = service.showAllUsers();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearFields();
            FormUtils.desactiveFied(btnAdd, btnUp, btnDel, Action.ADD);
        }

        private void clearFields()
        {
            txtbNomPrenom.Clear();
            txtBoxNumero.Clear();
            txtbLogin.Clear();
            txtbPassword.Clear();
           

        }


        private void loadComboBox()
        {
            List<String> listEtat = new List<String>();
            listEtat.Add("ROLE_GESTION");
            listEtat.Add("ROLE_LIVREUR");
            listEtat.Add("ROLE_COMP");
           


            cboRole.DataSource = listEtat;
            // cboCategorie.DisplayMember = "Libelle";
            // cboCategorie.ValueMember = "Id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nomComp = txtbNomPrenom.Text.Trim();
            string login = txtbLogin.Text.Trim();
            
            string password = txtbPassword.Text.Trim();
            string telephone = txtBoxNumero.Text;
            

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nomComp) ||  string.IsNullOrEmpty(telephone))
            {
                MessageBox.Show("Verifier votre saisie",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int id = 0;
                if(cboRole.SelectedItem == "ROLE_LIVREUR")
                {
                    Livreur user = new Livreur { 
                        
                        Fullname=nomComp,
                        Login=login,
                        Password=password,
                        Telephone=telephone,
                        Matricule= "MA"+telephone+"TR",
                        Role= cboRole.SelectedItem.ToString()


                    };
                    id = service.AddLivreur(user);
                }
                else
                {
                    User user = new User()
                    {
                        Fullname = nomComp,
                        Login = login,
                        Password = password,
                        Role = cboRole.SelectedItem.ToString()
                    };
                    id = service.addUser(user);
                }

                if (id <= 0)
                {

                    MessageBox.Show("Verifier votre saisie",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Utilisateur ajouter",
                   "Success Utilisateur ajouter",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    clearFields();
                    loadDataGridView();

                }



            }
        }
    }
}
