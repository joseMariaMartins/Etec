using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        public decimal Valor_Anterior { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            Valor_Anterior = Valor;
            txtResultado.Text = "";
            lblOperacao.Text = Valor + "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = Valor + "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = Valor + "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = Valor + "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal valorAtual = Convert.ToDecimal(txtResultado.Text);

            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + valorAtual;
                    lblOperacao.Text = $"{Valor} + {valorAtual} =";
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - valorAtual;
                    lblOperacao.Text = $"{Valor} - {valorAtual} =";
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * valorAtual;
                    lblOperacao.Text = $"{Valor} × {valorAtual} =";
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / valorAtual;
                    lblOperacao.Text = $"{Valor} ÷ {valorAtual} =";
                    break;
            }

            txtResultado.Text = Resultado.ToString();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }
    }
}