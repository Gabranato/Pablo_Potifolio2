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
    public partial class frmCalculoIMC : Form
    {
        public frmCalculoIMC()
        {
            InitializeComponent();
        }

        private void CalcularIMC_Click(object sender, EventArgs e)
        {
            string peso = "";
            string altura = "";
            double imc = 0;

            try
            {
                peso = textNum1.Text.Replace(".", ",");
                altura = textNum2.Text.Replace(".", ",");

                if (peso == "" || altura == "")
                {
                    MessageBox.Show("Algum campo está vazio!!!");
                }
                else
                {

                    imc = Convert.ToDouble(peso) / (Convert.ToDouble(altura) * Convert.ToDouble(altura));
                    calculoIMC.Text = imc.ToString();

                    if (imc < 18.5)
                    {
                        resultadoIMC.Text = "Abaixo do Peso";
                    }
                    else if(imc >= 18.5 && imc <= 24.9)
                    {
                        resultadoIMC.Text = "Peso Normal";
                    }
                    else if (imc >= 25 && imc <= 29.9)
                    {
                        resultadoIMC.Text = "Sobrepeso";
                    }
                    else if (imc >= 30 && imc <= 34.9)
                    {
                        resultadoIMC.Text = "Obesidade Grau I";
                    }
                    else if (imc >= 35 && imc <= 39.9)
                    {
                        resultadoIMC.Text = "Obesidade Grau II";
                    }
                    else if (imc >= 40)
                    {
                        resultadoIMC.Text = "Obesidade Grau III (Mórbida)";
                    }

                }

            }
            catch
            {
                MessageBox.Show("Apenas Numeros!!!");
            }
        }
    }
}
