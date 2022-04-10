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
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();
            txtHistorico.Text = frmPrincipal.historico;
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = frmPrincipal.historico = string.Empty;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
