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
            this.KeyPreview = true; // Permite capturar eventos do teclado
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
                            if (valorAtual == 0)
                            {
                                MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            Resultado = Valor / valorAtual;
                            lblOperacao.Text = $"{Valor} ÷ {valorAtual} =";
                            break;
                    }

                    txtResultado.Text = Resultado.ToString();
                    break;
            }
        }

        private void btnNumerico(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                Button bot = new Button();
                bot.Text = e.KeyChar.ToString();
                f_numeros(bot, EventArgs.Empty);
                e.Handled = true;
                return;
            }

            if (e.KeyChar >= (char)Keys.NumPad0 && e.KeyChar <= (char)Keys.NumPad9)
            {
                Button bot = new Button();
                bot.Text = e.KeyChar.ToString();
                f_numeros(bot, EventArgs.Empty);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                Button bot = new Button();
                bot.Text = "<";
                f_calculos(bot, EventArgs.Empty);
                e.Handled = true;
                return;
            }

            switch (e.KeyChar)
            {
                case '+':
                    Button botSoma = new Button();
                    botSoma.Text = "+";
                    f_calculos(botSoma, EventArgs.Empty);
                    e.Handled = true;
                    break;

                case '-':
                    Button botSub = new Button();
                    botSub.Text = "-";
                    f_calculos(botSub, EventArgs.Empty);
                    e.Handled = true;
                    break;

                case '*':
                    Button botMult = new Button();
                    botMult.Text = "x";
                    f_calculos(botMult, EventArgs.Empty);
                    e.Handled = true;
                    break;

                case '/':
                    Button botDiv = new Button();
                    botDiv.Text = "/";
                    f_calculos(botDiv, EventArgs.Empty);
                    e.Handled = true;
                    break;

                case '=':
                case (char)Keys.Enter:
                    Button botIgual = new Button();
                    botIgual.Text = "=";
                    f_calculos(botIgual, EventArgs.Empty);
                    e.Handled = true;
                    break;

                case ',':
                case '.':
                    Button botDecimal = new Button();
                    botDecimal.Text = ",";
                    f_calculos(botDecimal, EventArgs.Empty);
                    e.Handled = true;
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Add:
                    Button botaoAdd = new Button();
                    botaoAdd.Text = "+";
                    f_calculos(botaoAdd, EventArgs.Empty);
                    return true;

                case Keys.Subtract:
                    Button botaoSub = new Button();
                    botaoSub.Text = "-";
                    f_calculos(botaoSub, EventArgs.Empty);
                    return true;

                case Keys.Multiply:
                    Button botaoMul = new Button();
                    botaoMul.Text = "x";
                    f_calculos(botaoMul, EventArgs.Empty);
                    return true;

                case Keys.Divide:
                    Button botaoDiv = new Button();
                    botaoDiv.Text = "/";
                    f_calculos(botaoDiv, EventArgs.Empty);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}