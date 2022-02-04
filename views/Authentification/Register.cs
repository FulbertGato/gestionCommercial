using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using gestion_com_2022.utils;
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
    public partial class registerForm : Form
    {
        private IService service = Fabrique.getInstanceService();
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void handleRegister(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string nom = textNom.Text.Trim();
            string prenom = textPrenom.Text.Trim();
            string password = textPassword.Text.Trim();
            string telephone = textPhone.Text;
            string addresse = textAdresse.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(telephone))
            {
                MessageBox.Show("Verifier votre saisie",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Client user = new Client()
                {

                    Login = email,
                    Fullname = nom + " " + prenom,
                    Password = password,
                    Telephone = telephone,
                    Adresse = addresse,
                    Solde = 0
                };
                int id = service.addClient(user);
                if (id <= 0)
                {

                    labelError.Visible = true;

                }
                else
                {
                    NotificationSend sendNotif = new NotificationSend();
                    sendNotif.emailSend(user.Login,"COMPTE CREER", "VOTRE COMPTE EST BIEN CREER");
                   // sendNotif.sendMailApiAsync();
                  
                   Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void handleClear(object sender, EventArgs e)
        {
            labelError.Visible = false;
            textEmail.Clear();
            textNom.Clear();
            textPrenom.Clear();
            textPassword.Clear();
            textPhone.Clear();
            textAdresse.Clear();
        }

        private void handleConnexion(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
