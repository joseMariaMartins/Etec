using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalcButtons : Form
    {
        public frmCalcButtons()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
            double a, b;
            try
            {

                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);

                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números", "ERRO!!!");
            }
        
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
            double a, b;
            try
            {

                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);

                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números", "ERRO!!!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txt1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "x";
            double a, b;
            try
            {

                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);

                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números", "ERRO!!!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
            double a, b;
            try
            {

                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);

                lblResultado.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números", "ERRO!!!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possivel dividir por zero", "ERRO!!!");
            }
        }
    }
    
}
