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
    public partial class frmMediaAluno : Form
    {
        public frmMediaAluno()
        {
            InitializeComponent();
        }

        private void CalcularM_Click_1(object sender, EventArgs e)
        {
            string numero1 = "";
            string numero2 = "";
            double media;
            try
            {
                numero1 = textNum1.Text.Replace(".", ",");
                numero2 = textNum2.Text.Replace(".", ",");

                if(numero1 == "" || numero2 == "")
                {
                    MessageBox.Show("Algum campo está vazio!!!");
                }
                else
                {
                    media = (Convert.ToDouble(numero1) + Convert.ToDouble(numero2)) / 2;

                    textMedia.Text = media.ToString();
                }
                
            }
            catch
            {
                
            }
        }
    }
}
