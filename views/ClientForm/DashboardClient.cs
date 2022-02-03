using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using gestion_com_2022.views.ProductForm;
using gestion_com_2022.service;
using gestion_com_2022.fabrique;

namespace gestion_com_2022.views.ClientForm
{
    public partial class DashboardClient : Form
    {
        private User userConnect;
        private IService service = Fabrique.getInstanceService();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        public DashboardClient()
        {
            InitializeComponent();
        }
            public DashboardClient(User user)
        {
            InitializeComponent();
            userConnect = user;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowProduit_Click(object sender, EventArgs e)
        {
           
            panel1.Height = btnShowProduit.Height;
            panel1.Top = btnShowProduit.Top;
            panel1.Left = btnShowProduit.Left;
            btnShowProduit.BackColor = Color.FromArgb(46, 51, 73);
            ProductlistShow productList = new ProductlistShow(service.searchClientByUserId(userConnect.Id));
            productList.Show();
            this.Hide();


        }

        private void btnShowProduit_leave(object sender, EventArgs e)
        {
            btnShowProduit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnshowOrders_Click(object sender, EventArgs e)
        {
            panel1.Height = btnshowOrders.Height;
            panel1.Top = btnshowOrders.Top;
            panel1.Left = btnshowOrders.Left;
            btnshowOrders.BackColor = Color.FromArgb(46, 51, 73);
            
            loadform(new ClientCommandeList(service.searchClientByUserId(userConnect.Id)));
            
        }

        private void btnshowOrders_Leave(object sender, EventArgs e)
        {
            btnshowOrders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            panel1.Height = btnShowCart.Height;
            panel1.Top = btnShowCart.Top;
            panel1.Left = btnShowCart.Left;
            btnShowCart.BackColor = Color.FromArgb(46, 51, 73);
            ProductlistShow productList = new ProductlistShow(service.searchClientByUserId(userConnect.Id));
            productList.Show();
            this.Hide();
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            panel1.Height = btnShowAccount.Height;
            panel1.Top = btnShowAccount.Top;
            panel1.Left = btnShowAccount.Left;
            btnShowAccount.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new AccountInformation((Client)this.userConnect));
        }

        private void btnShowAccount_Leave(object sender, EventArgs e)
        {
            btnShowAccount.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnShowCart_Leave(object sender, EventArgs e)
        {
            btnShowCart.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void DashboardClient_Load(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

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
    }

    
}
