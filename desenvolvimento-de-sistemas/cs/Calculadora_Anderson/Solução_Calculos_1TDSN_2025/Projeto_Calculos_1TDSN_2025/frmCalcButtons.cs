using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos_1TDSN_2025
{
    public partial class frmCalcButtons : Form
    {
        public frmCalcButtons()
        {
            InitializeComponent();
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = " + ";
                double a, b;
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("[ERRO!!!] Digite apenas números!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = " - ";
                double a, b;

                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("[ERRO!!!] Digite apenas números!");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();

            lblResultado.Text = "?";
            lblSinal.Text = "?";

            txtN1.Focus();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = " x ";
                double a, b;

                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("[ERRO!!!] Digite apenas números!");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = " / ";
                decimal a, b;

                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);
                lblResultado.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("[ERRO!!!] Digite apenas números!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Todo número dividido por 0 é 0!");
                
            }
        }
    }
}
