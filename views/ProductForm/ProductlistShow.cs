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
        public ProductlistShow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
           // docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        public void AddItem(string name, double cost)
        {
            var w = new productWidget()
            {
                Title = name,
                Prix= cost,


            };
            pnl.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (productWidget)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblProduitname.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblPrix.Text.Replace("CFA", ""))).ToString("C2");
                        CalculateTotal();
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lblProduitname.Text, 1, wdg.lblPrix.Text });
                CalculateTotal();
            };
        }

        private void pageProductShown(object sender, EventArgs e)
        {
            AddItem("Fer", 7000);
            AddItem("manioc", 7000);
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        string path = "All Items";

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



        void CalculateTotal()
        {
            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("CFA", ""));
            }

            lblTot.Text = tot.ToString("C2");
        }

    }
}
