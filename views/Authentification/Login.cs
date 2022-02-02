using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using gestion_com_2022.views.ClientForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com_2022.views.Authentification
{
    public partial class Login : Form
    {
        private IService service = Fabrique.getInstanceService();

        public Login()
        {
            InitializeComponent();
        }

        private void labelTite_Click(object sender, EventArgs e)
        {

        }

        private void HandleInscription(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            register.Show();
            this.Hide();
        }

        private void handleConnexion(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Verifier votre saisie",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                User user = service.searchUserLoginAndPassword(email, password);
                if(user ==null){

                    MessageBox.Show("mdp ou login",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                else
                {
                    DashboardClient dashboardClient = new DashboardClient(user);
                    dashboardClient.Show();
                    this.Hide();


                }
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            labetTxtError.Visible = false;
        }
    }
}
