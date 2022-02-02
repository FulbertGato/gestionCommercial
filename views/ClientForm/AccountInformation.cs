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

namespace gestion_com_2022.views.ClientForm
{
    public partial class AccountInformation : Form
    {
        private IService service = Fabrique.getInstanceService();
        private Client userConnect;
        public AccountInformation()
        {
            InitializeComponent();
        }

        public AccountInformation(Client client)
        {
            this.userConnect = client;
            
            InitializeComponent();
        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            textNomComplet.Text = this.userConnect.Fullname;
            textAddresse.Text = this.userConnect.Adresse;
            textEmail.Text = this.userConnect.Login;
            textTelephone.Text = this.userConnect.Telephone;
            soldeBtn.Text = "Solde : " + this.userConnect.Solde;
        }

        private void updateInformation(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string nomComplet = textNomComplet.Text.Trim();
            string telephone = textTelephone.Text;
            string addresse = textAddresse.Text;

            if (string.IsNullOrEmpty(email) ||  string.IsNullOrEmpty(nomComplet) || string.IsNullOrEmpty(telephone) || string.IsNullOrEmpty(addresse))
            {
                MessageBox.Show("Verifier votre saisie",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Client client = new Client
                {
                    Id=this.userConnect.Id,
                    Login = email,
                    Adresse = addresse,
                    Fullname = nomComplet,
                    Telephone= telephone
                };
                service.updateClient(client);
                this.userConnect = service.searchClientByUserId(userConnect.Id);
                
            }
        }
    }
}
