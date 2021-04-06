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
    public partial class frmFrete : Form
    {
        public frmFrete()
        {
            InitializeComponent();
        }

        private void CalcularF_Click(object sender, EventArgs e)
        {
            try
            {
                double sTotal = 0;
                double sQtnde = 0;
                double sGramas = 0;
                double sVTotal = 0;

                if (cbEstado.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Selecione um estado");

                }
                else if (cbEstado.SelectedIndex.Equals(0))
                {
                    MessageBox.Show("Selecione um estado");

                }
                else if (cbEstado.SelectedIndex.Equals(8))
                {
                    MessageBox.Show("Selecione um estado");

                }
                else if (cbEstado.SelectedIndex.Equals(18))
                {
                    MessageBox.Show("Selecione um estado");

                }
                else if (cbEstado.SelectedIndex.Equals(23))
                {
                    MessageBox.Show("Selecione um estado");

                }
                else if (cbEstado.SelectedIndex.Equals(28))
                {
                    MessageBox.Show("Selecione um estado");

                }

                //NORTE
                if (cbEstado.SelectedIndex >= 1 && cbEstado.SelectedIndex <= 7)
                {
                    sTotal = Convert.ToDouble(textPesoT.Text);
                    sQtnde = Convert.ToDouble(textQtde.Text);

                    sGramas = ((sTotal * 1000) / 100) * 0.25;
                    sVTotal = (sQtnde * 5) + sGramas;
                    textValorT.Text = sVTotal.ToString();
                }

                //NORDESTE
                else if (cbEstado.SelectedIndex >= 9 && cbEstado.SelectedIndex <= 17)
                {
                    sTotal = Convert.ToDouble(textPesoT.Text);
                    sQtnde = Convert.ToDouble(textQtde.Text);

                    sGramas = ((sTotal * 1000) / 100) * 0.25;
                    sVTotal = (sQtnde * 4) + sGramas;
                    textValorT.Text = sVTotal.ToString();
                }

                //CENTRO-OESTE
                else if (cbEstado.SelectedIndex >= 19 && cbEstado.SelectedIndex <= 22)
                {
                    sTotal = Convert.ToDouble(textPesoT.Text);
                    sQtnde = Convert.ToDouble(textQtde.Text);

                    sGramas = ((sTotal * 1000) / 100) * 0.25;
                    sVTotal = (sQtnde * 3) + sGramas;
                    textValorT.Text = sVTotal.ToString();
                }

                //SUDESTE
                else if (cbEstado.SelectedIndex >= 24 && cbEstado.SelectedIndex <= 27)
                {
                    sTotal = Convert.ToDouble(textPesoT.Text);
                    sQtnde = Convert.ToDouble(textQtde.Text);

                    sGramas = ((sTotal * 1000) / 100) * 0.25;
                    sVTotal = (sQtnde * 2) + sGramas;
                    textValorT.Text = sVTotal.ToString();
                }

                // SUL
                else if (cbEstado.SelectedIndex >= 29 && cbEstado.SelectedIndex <= 31)
                {
                    sTotal = Convert.ToDouble(textPesoT.Text);
                    sQtnde = Convert.ToDouble(textQtde.Text);

                    sGramas = ((sTotal * 1000) / 100) * 0.25;
                    sVTotal = (sQtnde * 1) + sGramas;
                    textValorT.Text = sVTotal.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Apenas Numeros!!!");
            }
        }
    }
}
