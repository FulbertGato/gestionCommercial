using gestion_com_2022.views.CommandeForm;
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
    public partial class DashboardGestionnaire : Form
    {
        public DashboardGestionnaire()
        {
            InitializeComponent();
        }

        private void btnGererProduis_Click(object sender, EventArgs e)
        {
            panel1.Height = btnGererProduis.Height;
            panel1.Top = btnGererProduis.Top;
            panel1.Left = btnGererProduis.Left;
            btnGererProduis.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new ProduitGestions());
        }

        public void loadform(object Form)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(f);
            this.panelContent.Tag = f;
            f.Show();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            panel1.Height = btnCategorie.Height;
            panel1.Top = btnCategorie.Top;
            panel1.Left = btnCategorie.Left;
            btnCategorie.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new CategorieGestion());
        }

        private void btnCommandes_Click(object sender, EventArgs e)
        {
            // loadform(new listerCommandeGestion()); }

            listerCommandeGestion listerCommandeGestion = new listerCommandeGestion();
            listerCommandeGestion.Show();
        }

        private void userGestionBtn_Click(object sender, EventArgs e)
        {
            loadform(new userManager());

        }
    }
}
