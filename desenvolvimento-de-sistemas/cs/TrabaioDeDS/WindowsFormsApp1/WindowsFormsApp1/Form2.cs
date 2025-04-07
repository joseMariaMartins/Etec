using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string operacao = "";
        decimal vNumAnt;
        bool vLimpar = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void f_numeros(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;

            if (vLimpar)
            { 
                lblVisor.Text = "";
                vLimpar = false ;
            }

            if (lblVisor.Text == "0")
            {
                lblVisor.Text = digito;
            }
            else
            {
                lblVisor.Text += digito;
            }
            if (lblVisor.Text.Length > 17)
            {
                lblVisor.Text = lblVisor.Text;
                lblAntiga.Visible = false;
            }
            else
            {
                lblAntiga.Visible = true;
            }
            lblVisor.Focus();
        }
        private void f_operacoes(object sender, EventArgs e)
        {
            operacao = ((Button)sender).Text;   
            vNumAnt = decimal.Parse(lblVisor.Text);
            vLimpar = true;
            lblAntiga.Text = " " + vNumAnt.ToString();
            lblAntiga.Text += " " + operacao;

            lblVisor.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            lblAntiga.Text = "";
            operacao = "";
            lblVisor.Focus();
        }
      
        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            string digito = e.KeyCode.ToString();
            Button bot = new Button();
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                bot.Text = digito.Substring(1, 1);
                f_numeros(bot, e);
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                bot.Text = digito.Substring(6, 1);
                f_numeros(bot, e);
            }
            switch (e.KeyCode.ToString())
            {
                case "Add":
                    bot.Text = "+";
                    f_operacoes(bot, e);
                    break;
                case "Substract":
                    bot.Text = "-";
                    f_operacoes(bot, e);
                    break;
                case "Multiply":
                    bot.Text = "x";
                    f_operacoes(bot, e);
                    break;
                case "None":
                    bot.Text = ":";
                    f_operacoes(bot, e);
                    break;
                case "Divide":
                    bot.Text = ":";
                    f_operacoes(bot, e);
                    break;
                case "Decimal":
                    bot.Text = ",";
                    btnVirgula_Click_1(sender, e);
                    break;
                case "Return":
                    bot.Text = "=";
                    btnIgual_Click_1(sender, e);
                    break;

            }
        }
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            lblVisor.Text = (Convert.ToDecimal(lblVisor.Text) *- 1).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text  = lblVisor.Text.Substring(0, lblVisor.Text.Length -1);
            if (lblVisor.Text=="")
            {
                lblVisor.Text = "0";
            }
        }

        private void btnVirgula_Click_1(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(","))
            {
                lblVisor.Text += ",";
            }
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            lblAntiga.Text += " " + vNumAtual.ToString();
            switch (operacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
                case "Return":
                    btnIgual_Click_1(sender, e);
                    break;
                case "x":
                    lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    break;
                case "/":
                    if (vNumAtual == 0 || vNumAnt == 0)
                    {
                        lblVisor.Text = "1";
                    }
                    else
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                    }
                    break;
                case "^":
                    lblVisor.Text = Math.Pow(double.Parse(vNumAnt.ToString()), double.Parse(vNumAtual.ToString())).ToString();
                    break;
            }
            lblVisor.Focus();
        }
    }
}
