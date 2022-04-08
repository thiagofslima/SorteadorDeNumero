using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorDeNumero
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {

            int numInicial = (int)nudInicial.Value;
            int numFinal = (int)nudFinal.Value;

            if (numInicial >= numFinal)
                MessageBox.Show("Número Inicial não pode ser maior ou igual ao Número Final");
            else
                lblnumSorteado.Text = Sortear(numInicial, numFinal).ToString();
        }

        private int Sortear(int inicial, int final)
        {
            Random rand = new Random();
            return rand.Next(inicial, final + 1);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
            this.Visible=true;
        }
    }
}
