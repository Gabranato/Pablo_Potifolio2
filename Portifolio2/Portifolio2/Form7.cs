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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void calcularTabuada_Click(object sender, EventArgs e)
        {
            string numero1 = "";
            double mult;
            try
            {
                numero1 = textNum1.Text.Replace(".", ",");

                if (numero1 == "")
                {
                    MessageBox.Show("O campo está vazio!!!");
                }
                else
                {
                    int i = 0;
                    do
                    {
                        i++;
                        mult = Convert.ToDouble(numero1) * i;
                        if (i == 1)
                            resultX1.Text = mult.ToString();
                        else if (i == 2)
                            resultX2.Text = mult.ToString();
                        else if (i == 3)
                            resultX3.Text = mult.ToString();
                        else if (i == 4)
                            resultX4.Text = mult.ToString();
                        else if (i == 5)
                            resultX5.Text = mult.ToString();
                        else if (i == 6)
                            resultX6.Text = mult.ToString();
                        else if (i == 7)
                            resultX7.Text = mult.ToString();
                        else if (i == 8)
                            resultX8.Text = mult.ToString();
                        else if (i == 9)
                            resultX9.Text = mult.ToString();
                        else if (i == 10)
                            resultX10.Text = mult.ToString();

                    } while (i <= 10);
                }

            }
            catch
            {
                MessageBox.Show("Apenas Numeros!!!");
            }
        }
    }
}
