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

namespace gestion_com_2022.views.ClientForm
{
    public partial class PaiementFrm : Form
    {

        private IService service = Fabrique.getInstanceService();
        private Client userConnect;
        private Commande commande;
        public PaiementFrm()
        {
            InitializeComponent();
        }

        public PaiementFrm(Client client, Commande commande )
        {
            this.userConnect = client;
            this.commande = commande;
            InitializeComponent();
        }

        private void PaiementFrm_Load(object sender, EventArgs e)
        {
            textMontantDu.Text = this.commande.Montant.ToString();

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            String referencePaiement = textReferencePaiement.Text;
            String typePaiement = textTpe.Text.ToString().Trim();
            double montantPayer = double.Parse(textMontantPayer.Text);
            if (string.IsNullOrEmpty(typePaiement) || string.IsNullOrEmpty(referencePaiement) )
            {



            }
            else
            {
                Paiement paiement = new Paiement();
                paiement.ClientId = this.userConnect.Id;
                paiement.Montant = montantPayer;
               // paiement.Commande = this.commande;
                paiement.Reference = referencePaiement;
               // int idPaie = service.addPaiement(paiement);
                int idCo = service.updateCommandeStatus("PAYER",this.commande.Id);
                MessageBox.Show("Paiement enregistrer votre solde sera mis a jour apres confirmation",
                    "Paiement enregistrer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                NotificationSend sendNotif = new NotificationSend();
                sendNotif.emailSend(userConnect.Login, "PAIEMENT ENREGISTRER", "Paiement enregistrer votre solde sera mis a jour apres confirmation");
                this.Hide();
            }

        }
    }
}
