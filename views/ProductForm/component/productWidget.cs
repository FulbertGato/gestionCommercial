using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com_2022.views.ProductForm.component
{
    public partial class productWidget : UserControl
    {
        private double _cost;
        public event EventHandler OnSelect = null;
        public productWidget()
        {
            InitializeComponent();
        }

        private void imgImage_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        public string Title { get => lblProduitname.Text; set => lblProduitname.Text = value; }
        
        public double Prix { get => _cost; set { _cost = value; lblPrix.Text = _cost.ToString("C2"); } }
        // public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }
    }
}
