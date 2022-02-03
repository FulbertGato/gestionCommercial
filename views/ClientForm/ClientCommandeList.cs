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
    public partial class ClientCommandeList : Form
    {
        private IService service = Fabrique.getInstanceService();
        private Client userConnect;
        public ClientCommandeList()
        {
            InitializeComponent();
        }
        public ClientCommandeList(Client client)
        {
            this.userConnect = client;
            InitializeComponent();
        }
        

        private void ClientCommandeList_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            dtgvCommande.AutoGenerateColumns = false;


            // DataTable catesLis = new DataTable();
            List<Commande> listCommandes = service.showAllCommandesByClient(this.userConnect.Id);
            
            dtgvCommande.DataSource = listCommandes;
        }

        private void dtgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvCommande.Rows.Count - 1)
            {


                DataGridViewRow row = dtgvCommande.Rows[e.RowIndex];
                row.Selected = true;
                int id = int.Parse(row.Cells[0].Value.ToString());
                Commande commande = service.findCommandeById(id);




            }
        }
    }
}
