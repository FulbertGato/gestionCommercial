using gestion_com_2022.dto;
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

namespace gestion_com_2022.views.CommandeForm
{
    public partial class CommandeDetailFrm : Form
    {

        private IService service = Fabrique.getInstanceService();
        private Client userConnect;
        private Commande commande;
        public CommandeDetailFrm()
        {
            InitializeComponent();
        }


        public CommandeDetailFrm(Commande commande,Client client)
        {
            this.userConnect = client;
            this.commande = commande;
            InitializeComponent();
        }


        private void loadDataGridView()
        {
            dtgvProduitsCmdes.AutoGenerateColumns = false;

            List<DetailCommandeDto> listeDTo = new List<DetailCommandeDto>();


            // DataTable catesLis = new DataTable();
            List<DetailCommande> listDetailsCommandes = service.showAllDetailCommandeByCommmandeId(this.commande.Id);

            foreach(DetailCommande detail in listDetailsCommandes)
            {
                DetailCommandeDto der = new DetailCommandeDto
                {
                    ProduitLibelle = detail.Produit.Libelle,
                    ProduitMontant = detail.Produit.Prix * int.Parse(detail.QteProduits),
                    ProduitPrix=detail.Produit.Prix,
                    Id= detail.Id,
                    Qte1=int.Parse(detail.QteProduits)

                };
                listeDTo.Add(der);
            }

            dtgvProduitsCmdes.DataSource = listeDTo;
        }

        

        private void CommandeDetailFrm_Load(object sender, EventArgs e)
        {

            if(this.commande.Etat != "EN COURS")
            {
                btnPayCommande.Enabled = false;
            }
            txtbCmdAdresse.Text = this.commande.AdresseLivraison;
            txtbCmdNomComplet.Text = this.userConnect.Fullname;
            txtbCmdTel.Text = this.userConnect.Telephone;
            txtbTotalCmde.Text = this.commande.Montant.ToString()+" CFA";
            loadDataGridView();



        }

        private void btnRetoure_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPayCommande_Click(object sender, EventArgs e)
        {
            PaiementFrm paiem = new PaiementFrm(this.userConnect,this.commande);
            paiem.Show();
        }
    }


    
}
