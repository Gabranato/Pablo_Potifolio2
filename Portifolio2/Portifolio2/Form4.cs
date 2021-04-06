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
    public partial class frmConversaoCF : Form
    {
        public frmConversaoCF()
        {
            InitializeComponent();
        }

        private void calcularCF_Click(object sender, EventArgs e)
        {
            string celsius = "";
            double fahrenheit;
            try
            {
                celsius = textNum1.Text.Replace(".", ",");

                if (celsius == "")
                {
                    MessageBox.Show("O Campo está vazio!!!");
                }
                else
                {
                    fahrenheit = ((Convert.ToDouble(celsius) * 9) / 5) + 32;

                    ResultF.Text = fahrenheit.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Apenas Numeros!!!");
            }
        }
    }
}
