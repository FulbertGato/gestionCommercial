using gestion_com_2022.fabrique;
using gestion_com_2022.service;
using gestion_com_2022.utils;
using gestion_com_2022.utils.ImageG;
using gestion_com_2022.views.Authentification;
using gestion_com_2022.views.ClientForm;
using gestion_com_2022.views.ProductForm.component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com_2022.views.ProductForm
{
    public partial class ProductlistShow : Form
    {

        private IService service = Fabrique.getInstanceService();
        private Client client;
        public ProductlistShow()
        {
            InitializeComponent();
        }

        public ProductlistShow(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
            // docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        public void AddItem(string name, double cost, int id, int stock)
        {
            var w = new productWidget()
            {
                Title = name,
                Prix = cost,
                Id = id,
                Stock = stock


            };
            pnl.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (productWidget)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[3].Value.ToString() == wdg.Id.ToString())
                    {

                        if(wdg.Stock < int.Parse(item.Cells[1].Value.ToString()) + 1)
                        {


                            MessageBox.Show("Stock Insuffisant",
                            "Stock inssufisant",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        

                    }
                        else
                        {
                            item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;

                            item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblPrix.Text.Replace("CFA", ""))).ToString("C2");
                        }
                        
                        

                        CalculateTotal();
                        return;
                    }

                }
                grid.Rows.Add(new object[] { wdg.lblProduitname.Text, 1, wdg.lblPrix.Text , wdg.Id,wdg.Stock});
                CalculateTotal();
            };
        }
       // private Byte[] biIm = { };
       // private Image imgIcon;
        private void pageProductShown(object sender, EventArgs e)
        {
           // List<Produit> listProduits = new List<Produit>();
            System.Data.Entity.DbSet<Produit> catesLis = service.showAllProduits();
            foreach (Produit prod in catesLis)
            {
               /* //  listProduits.Add(prod);
                
                foreach(Images im in prod.Images)
                {
                    this.biIm.Append(im.ImageByte);
                    this.imgIcon = MyImage.convertByteToImage(this.biIm);
                }
               // Image img = MyImage.convertByteToImage();*/
               AddItem(prod.Libelle, prod.Prix,prod.Id,prod.Stock);
            }

           
            
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
       // string path = "All Items";

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var wdg = (productWidget)item;
                    wdg.Visible = wdg.lblProduitname.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower())
                      /*  &&
                      (wdg.Tag.ToString() == path.Replace(" ", "") || path.Replace(" ", "") == "AllItems")*/;

                }
            }
        }


        private double totalAPayer;
        void CalculateTotal()
        {
            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("CFA", ""));
            }
            this.totalAPayer = tot;

            lblTot.Text = tot.ToString("C2");
        }

        private void ProductlistShow_Load(object sender, EventArgs e)
        {

            // List < Produit > listProduits = new List<Produit>();
            System.Data.Entity.DbSet<Produit> catesLis = service.showAllProduits();
            foreach (Produit prod in catesLis)
            {
                AddItem(prod.Libelle, prod.Prix, prod.Id,prod.Stock);
               
            }
            if (this.client == null)
            {
                btnUser.Visible = false;
                btnUser.Enabled = false;
                btnAskDashboard.Enabled = false;
                btnAskDashboard.Visible = false;
                btnInscription.Enabled = true;
                btnInscription.Visible = true;
                btnSeConnecter.Enabled = true;
                btnSeConnecter.Visible = true;

            }
            else
            {
                btnUser.Visible = true;
                btnUser.Text = "BIENVENUE  :  "+this.client.Fullname.ToUpper();
                btnUser.Enabled = true;
                btnInscription.Enabled = false;
                btnInscription.Visible = false;
                btnSeConnecter.Enabled = false;
                btnSeConnecter.Visible = false;
                btnAskDashboard.Enabled = true;
                btnAskDashboard.Visible = true;

            }

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            register.Show();
            this.Hide();
        }

        private void btnAskDashboard_Click(object sender, EventArgs e)
        {
            DashboardClient dashboardClient = new DashboardClient(this.client);
            dashboardClient.Show();
            this.Hide();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            createCommande();
            MessageBox.Show("Commande passé",
                            "Merci pour votre commande",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            // int idCommande = service.addCommande(cmd);
            /* if (idCommande >= 1)
             {
                 MessageBox.Show("Commande passé",
                             "Merci pour votre commande",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
             }
             else
             {
                 MessageBox.Show("Commande non enregistrer",
                             "error ",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
             }*/
        }

        private int  createCommande()
        {
            List<DetailCommande> listeDetails = new List<DetailCommande>();
            

            String refgene = getReference();
            Commande commande = new Commande
            {
    
               // DetailCommandes = listeDetails,
                Montant = this.totalAPayer,
                AdresseLivraison = this.client.Adresse,
                Etat= "EN ATTENTE",
                Date= DateTime.Now,
                Numero= refgene,
                ClientId = this.client.Id

            };

            service.addCommande(commande);
            Commande co=service.findCommandeByRef(refgene);

            foreach (DataGridViewRow item in grid.Rows)
            {
                
                Produit produit = service.findProduitById(int.Parse(item.Cells[3].Value.ToString()));
                DetailCommande detail = new DetailCommande
                {
                    CommandeId=co.Id,
                    QteProduits = item.Cells[1].Value.ToString(),
                    ProduitId = int.Parse(item.Cells[3].Value.ToString())

                };
                listeDetails.Add(detail);
            }

            co.DetailCommandes = listeDetails;
            service.soldeCompteUpdate(this.client.Id, this.totalAPayer);
            return service.UpdateCommandeDetails(co);

           


        }


        public static string getReference()
        {
            //si nbreProduit est sur 1 chiffre(1..9)  00Chiffre
            //si nbreProduit est sur 2 chiffre(10..99) 02Chiffre
            //si nbreProduit est sur 3 chiffre(10..99) 3Chiffre
            string refProd;
            //convertir le Nbre de Produits en chaine
            int seq = MyFiles.generateSeqence();
            string stringNbreProduit = string.Format("{0}", seq);
            switch (stringNbreProduit.Length)
            {
                case 1:
                    refProd = "REF00" + seq;
                    break;
                case 2:
                    refProd = "REF0" + seq;
                    break;
                default:
                    refProd = string.Format("REF{0}", seq);
                    break;
            }

            return refProd;

        }
    }
}
