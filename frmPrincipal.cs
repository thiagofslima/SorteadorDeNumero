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
        public static string historico;
        public frmPrincipal()
        {
            InitializeComponent();
            nudFinal.Value = 10;
            nudFinal.Select();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int numInicial = (int)nudInicial.Value;
            int numFinal = (int)nudFinal.Value;

            if (numInicial >= numFinal)
                MessageBox.Show("Número Inicial não pode ser maior ou igual ao Número Final");
            else
                lblnumSorteado.Text = Sortear(numInicial, numFinal).ToString();

            historico+=$"Inicial: {numInicial} | Final: {numFinal} || {lblnumSorteado.Text}{Environment.NewLine}";
        }

        private int Sortear(int inicial, int final)
        {
            Random rand = new Random();
            return rand.Next(inicial, final + 1);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSobre().ShowDialog();
            this.Visible = true;
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmHistorico().ShowDialog();
            this.Visible = true;
        }
    }
}
