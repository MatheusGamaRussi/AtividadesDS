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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void mnusair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuexercicio1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmposto exercicio1 = new frmposto();
            exercicio1.Show();
        }

        private void mnuwhile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmwhile ex_while = new frmwhile();
            ex_while.Show();
        }

        private void mnudowhile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdowhile ex_dowhile = new frmdowhile();
            ex_dowhile.Show();
        }
    }
}
