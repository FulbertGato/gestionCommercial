using gestion_com_2022.dto;
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

namespace gestion_com_2022.views.CommandeForm
{
   
    public partial class listerCommandeGestion : Form
    {
        IService service = Fabrique.getInstanceService();
        public listerCommandeGestion()
        {
            InitializeComponent();
        }

        private void listerCommandeGestion_Load(object sender, EventArgs e)
        {
            loadDataGridView(service.showAllCommandes());
            loadComboBox();


        }

        public void loadDataGridView(List<Commande> cmdes)
        {
            List<CommandeDto> listeDto = new List<CommandeDto>();

            foreach(Commande cmde in cmdes)
            {
                CommandeDto cm = new CommandeDto
                {
                    Numero=cmde.Numero,
                    Id1 = cmde.Id,
                    Montant = cmde.Montant,
                    Telephone = cmde.Client.Telephone,
                    Date=cmde.Date

                };
                listeDto.Add(cm);
            }
            dgvCommandes.AutoGenerateColumns = false;
            dgvCommandes.DataSource = listeDto;
        }



        private void loadComboBox()
        {
            List<String> listEtat = new List<String>();
            listEtat.Add("EN ATTENTE");
            listEtat.Add("EN COURS");           
            listEtat.Add("ANNULER");
            listEtat.Add("TERMINER");


            cbxEtat.DataSource = listEtat;
           // cboCategorie.DisplayMember = "Libelle";
           // cboCategorie.ValueMember = "Id";
           
        }

        private void cbxEtat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxEtat_SelectedValueChanged(object sender, EventArgs e)
        {
            String statut = cbxEtat.SelectedItem.ToString();
            loadDataGridView(service.showAllCommandes(statut));
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            string tel = textBox6.Text.Trim();
            List<Commande> cmdesClient = service.showAllCommandesClientTel(tel);
            if (cmdesClient.Count > 0)
            {
                loadDataGridView(cmdesClient);

            }
            else
            {
                dgvCommandes.DataSource = null;
            }
        }
        private int idCmde;
        private void dgvCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCommandes.Rows.Count)
            {

                DataGridViewRow row = dgvCommandes.Rows[e.RowIndex];
                row.Selected = true;
                idCmde = int.Parse(row.Cells[0].Value.ToString());
                Commande cmde = service.findCommandeById(idCmde);
                MessageBox.Show("" + idCmde);
                //Données  Client
                txtRef.Text = cmde.Numero;
                txtEtat.Text = cmde.Etat;
                textMontant.Text = cmde.Montant.ToString();


                cmbLivreur.DataSource = service.showAllLivreurs("ROLE_LIVREUR");
                cmbLivreur.DisplayMember = "FullName";
                cmbLivreur.ValueMember = "Id";
                loadDataGridViewDetail(idCmde);

            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Commande cmde = service.findCommandeById(idCmde);
            cmde.Etat = "EN COURS";
            Livraison livraison = new Livraison
            { 
                LivreurId = int.Parse(cmbLivreur.SelectedValue.ToString()),
                 Commande = cmde,
                Date = DateTime.Now,
                Statut = "EN PREPARATION"


            };

            service.addLivraison(livraison);


        }


        private void loadDataGridViewDetail(int id)
        {
            dgtvDetailProd.AutoGenerateColumns = false;

            List<DetailCommandeDto> listeDTo = new List<DetailCommandeDto>();


            // DataTable catesLis = new DataTable();
            List<DetailCommande> listDetailsCommandes = service.showAllDetailCommandeByCommmandeId(id);

            foreach (DetailCommande detail in listDetailsCommandes)
            {
                DetailCommandeDto der = new DetailCommandeDto
                {
                    ProduitLibelle = detail.Produit.Libelle,
                    ProduitMontant = detail.Produit.Prix * int.Parse(detail.QteProduits),
                    ProduitPrix = detail.Produit.Prix,
                    Id = detail.Id,
                    Qte1 = int.Parse(detail.QteProduits)

                };
                listeDTo.Add(der);
            }

            dgtvDetailProd.DataSource = listeDTo;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
