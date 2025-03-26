using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variáveis para cálculos
        private double valor1 = 0;
        private double valor2 = 0;
        private string operacao = "";
        private bool limparTela = false;

        public Form1()
        {
            InitializeComponent();
            AssociarEventos();
        }

        private void AssociarEventos()
        {
            // Botões numéricos (0-9)
            Button[] botoesNumericos = { btnZero, btnUm, btnDois, btnTres, btnQuatro,
                                       btnCinco, btnSeis, btnSete, btnOito, btnnNove };
            foreach (Button btn in botoesNumericos)
            {
                btn.Click += BotaoNumero_Click;
            }

            // Botões de operação
            btnSomar.Click += BotaoOperacao_Click;
            btnSubtrair.Click += BotaoOperacao_Click;
            btnMultiplicacao.Click += BotaoOperacao_Click;
            btnDivisao.Click += BotaoOperacao_Click;

            // Botões especiais
            btnVirgula.Click += btnVirgula_Click;
            btnIgual.Click += btnIgual_Click;
            btnLimpar.Click += btnLimpar_Click;
            btnMaisMenos.Click += btnMaisMenos_Click;
            btnBack.Click += btnBack_Click;
        }

        private void BotaoNumero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (txtResultado.Text == "0" || limparTela)
            {
                txtResultado.Clear();
                limparTela = false;
            }

            txtResultado.Text += botao.Text;
            AtualizarLabelOperacao();
        }

        private void BotaoOperacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (!string.IsNullOrEmpty(operacao) && !limparTela)
            {
                btnIgual.PerformClick();
            }

            operacao = botao.Text;
            valor1 = double.Parse(txtResultado.Text);
            limparTela = true;
            AtualizarLabelOperacao();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operacao))
            {
                valor2 = double.Parse(txtResultado.Text);
                double resultado = Calcular(valor1, valor2, operacao);
                txtResultado.Text = resultado.ToString();
                lblOperacao.Text = $"{valor1} {operacao} {valor2} =";
                limparTela = true;
                operacao = "";
            }
        }

        private double Calcular(double v1, double v2, string op)
        {
            switch (op)
            {
                case "+": return v1 + v2;
                case "-": return v1 - v2;
                case "×": return v1 * v2;
                case "÷":
                    if (v2 == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return double.NaN;
                    }
                    return v1 / v2;
                default: return 0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lblOperacao.Text = "";
            limparTela = false;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(txtResultado.Text) || limparTela)
                {
                    txtResultado.Text = "0,";
                    limparTela = false;
                }
                else
                {
                    txtResultado.Text += ",";
                }
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "0")
            {
                if (txtResultado.Text.StartsWith("-"))
                    txtResultado.Text = txtResultado.Text.Substring(1);
                else
                    txtResultado.Text = "-" + txtResultado.Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void AtualizarLabelOperacao()
        {
            if (!string.IsNullOrEmpty(operacao))
            {
                lblOperacao.Text = $"{valor1} {operacao}";
            }
            else
            {
                lblOperacao.Text = "";
            }
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {
            // Pode ser usado para mostrar histórico ou outras funcionalidades
        }
    }
}