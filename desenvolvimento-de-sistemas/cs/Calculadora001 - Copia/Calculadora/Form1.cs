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

        public void f_numeros(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string digito = botaoClicado.Text;

            if (txtResultado.Text == "0" || string.IsNullOrEmpty(txtResultado.Text))
            {
                txtResultado.Text = digito;
            }
            else
            {
                txtResultado.Text += digito;
            }
        }

        private void f_calculos(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string operacao = botao.Text;

            switch (operacao)
            {
                case "+":
                    OperacaoSelecionada = Operacao.Adicao;
                    Valor = Convert.ToDecimal(txtResultado.Text);
                    Valor_Anterior = Valor;
                    txtResultado.Text = "";
                    lblOperacao.Text = Valor + "+";
                    break;

                case "-":
                    OperacaoSelecionada = Operacao.Subtracao;
                    Valor = Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text = "";
                    lblOperacao.Text = Valor + "-";
                    break;

                case "x":
                    OperacaoSelecionada = Operacao.Multiplicacao;
                    Valor = Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text = "";
                    lblOperacao.Text = Valor + "x";
                    break;

                case "/":
                    OperacaoSelecionada = Operacao.Divisao;
                    Valor = Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text = "";
                    lblOperacao.Text = Valor + "/";
                    break;
                case ",":
                    if (!txtResultado.Text.Contains(","))
                        txtResultado.Text += ",";
                    break;

                case "<":
                    if (txtResultado.Text.Length > 0) 
                    {
                        txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
                    }
                    if (txtResultado.Text == "")  
                    {
                        txtResultado.Text = "0"; 
                    }
                    break;

                case "c":
                    txtResultado.Text = "0";
                    lblOperacao.Text = "";
                    break;

                case "=":
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
                    break;
            }
        }
    }
}