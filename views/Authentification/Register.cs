using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com_2022.views

{
    public partial class registerForm : Form
    {
        private IService service = Fabrique.getInstanceService();
        public registerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void handleRegister(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string nom = textNom.Text.Trim();
            string prenom = textPrenom.Text.Trim();
            string password = textPassword.Text.Trim();
            string telephone = textPhone.Text;

            Client user = new Client() { 
                
                Login=email,
                Fullname = nom+" "+prenom,
                Password = password,
                Telephone= telephone,
            
                Solde= 0,
            Adresse= "adresse 1"};
            service.addClient(user);
            Console.WriteLine("Client Ajouter . tu veux verifier ?");

        }

        private void handleClear(object sender, EventArgs e)
        {

        }

        private void handleConnexion(object sender, EventArgs e)
        {

        }
    }
}
