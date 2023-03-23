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
    public partial class frmposto : Form
    {
        public frmposto()
        {
            InitializeComponent();
        }

        private void frmposto_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double L, preco;
            string cod;

            L = Convert.ToDouble(txtlitros.Text);
            cod = Convert.ToString(txttipo.Text);

            if (cod.Equals("A"))
            {
                if(L <= 20)
                {
                    preco = L * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = preco.ToString();
                }
                else
                {
                    preco = L * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = preco.ToString();
                }
            }
            else if (cod.Equals("G"))
            {
                if(L <= 20)
                {
                    preco = L * (5.50 - (5.50 * 4 / 100));
                    txtresult.Text = preco.ToString();
                }
                else
                {
                    preco = L * (5.50 - (5.50 * 6 / 100));
                    txtresult.Text = preco.ToString();
                }
            }
            else
            {
                txtresult.Text = "Código Inválido!";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttipo.Clear();
            txtlitros.Clear();
            txtresult.Clear();
            txttipo.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}