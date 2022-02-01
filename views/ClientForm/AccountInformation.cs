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
        public AccountInformation()
        {
            InitializeComponent();
        }

        public AccountInformation(Client client)
        {
            InitializeComponent();
        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
