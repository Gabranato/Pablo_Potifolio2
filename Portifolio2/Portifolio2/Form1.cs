using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portifolio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mediaDasNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMediaAluno Form = new frmMediaAluno();
            Form.Show();
        }

        private void calculoDeIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoIMC Form = new frmCalculoIMC();
            Form.Show();
        }
        private void ceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConversaoCF Form = new frmConversaoCF();
            Form.Show();
        }

        private void celsiusParaKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConversaoCK Form = new frmConversaoCK();
            Form.Show();
        }

        private void calculoDeFreteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrete Form = new frmFrete();
            Form.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuada Form = new frmTabuada();
            Form.Show();
        }

    }
}
