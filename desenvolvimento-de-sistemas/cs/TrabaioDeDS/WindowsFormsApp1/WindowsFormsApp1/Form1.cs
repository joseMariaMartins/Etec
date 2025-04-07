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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Execultar_Click(object sender, EventArgs e)
        {
            decimal a, b, r = 0;
            //double pontencia;

            //a= decimal.Parse(textBox1.Text);
            //b= Convert.ToDecimal(textBox2.Text);

            //pontencia = Math.Pow((double)a,b);
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);

                if (rdbSomar.Checked)
                {
                    lblSinal.Text = " + ";
                    r = a + b;
                }
                else if (rdbSubtrair.Checked)
                {
                    lblSinal.Text = " - ";
                    r = a - b;
                }
                else if (rdbDividir.Checked)
                {
                    lblSinal.Text = " / ";
                    r = a / b;
                }
                else if (rdbMultiplicar.Checked)
                {
                    lblSinal.Text = " x ";
                    r = a * b;
                }
                else
                {
                    MessageBox.Show("Selecione uma conta!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Impossivel dividir por zero ne fi!");
            }
            result.Text = r.ToString();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void conta_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblSinal.Text = "?";
            result.Text = "?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
