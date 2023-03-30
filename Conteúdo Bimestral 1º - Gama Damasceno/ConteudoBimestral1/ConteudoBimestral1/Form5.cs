using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConteudoBimestral1
{
    public partial class frmfor : Form
    {
        public frmfor()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txttabuada.Clear();
            txtnumero.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, n_tab;

            num = Convert.ToDouble(txtnumero.Text);

            for (int i = 0; i <= 10; i++)
            {
                n_tab = num * i;

                txttabuada.Text = String.Concat(txttabuada.Text, " \n\n ", n_tab.ToString());
            }
        }
    }
}
