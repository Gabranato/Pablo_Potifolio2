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
    public partial class frmConversaoCK : Form
    {
        public frmConversaoCK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string celsius = "";
            double kelvin;
            try
            {
                celsius = textNum1.Text.Replace(".", ",");

                if (celsius == "")
                {
                    MessageBox.Show("O Campo está vazio!!!");
                }
                else
                {
                    kelvin = Convert.ToDouble(celsius) + 273.15;

                    ResultK.Text = kelvin.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Apenas Numeros!!!");
            }
        }
    }
}
