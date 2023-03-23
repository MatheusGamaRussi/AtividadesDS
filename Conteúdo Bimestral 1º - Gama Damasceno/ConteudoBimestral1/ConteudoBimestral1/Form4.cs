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
    public partial class frmdowhile : Form
    {
        public frmdowhile()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, n_tab;
            int i;

            num = Convert.ToDouble(txtnumero.Text);

            i = 0;
            do {
                n_tab = num * i;
                i++;

                txttabuada.Text = String.Concat(txttabuada.Text, " \n\n ", n_tab.ToString());

            } while (i <= 10);
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
    }
}
