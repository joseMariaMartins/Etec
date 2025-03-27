namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSete = new Button();
            btnOito = new Button();
            btnnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtrair = new Button();
            btnSomar = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            btnMaisMenos = new Button();
            btnMenos = new Button();
            btnBack = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F);
            txtResultado.Location = new Point(12, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(316, 43);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 14F);
            btnSete.Location = new Point(12, 61);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(75, 64);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 14F);
            btnOito.Location = new Point(93, 61);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(75, 64);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnnNove
            // 
            btnnNove.Font = new Font("Segoe UI", 14F);
            btnnNove.Location = new Point(174, 61);
            btnnNove.Name = "btnnNove";
            btnnNove.Size = new Size(75, 64);
            btnnNove.TabIndex = 3;
            btnnNove.Text = "9";
            btnnNove.UseVisualStyleBackColor = true;
            btnnNove.Click += btnnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 14F);
            btnQuatro.Location = new Point(12, 131);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(75, 64);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 14F);
            btnCinco.Location = new Point(93, 131);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(75, 64);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 14F);
            btnSeis.Location = new Point(174, 131);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(75, 64);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 14F);
            btnUm.Location = new Point(12, 201);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(75, 64);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 14F);
            btnDois.Location = new Point(93, 201);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(75, 64);
            btnDois.TabIndex = 8;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 14F);
            btnTres.Location = new Point(174, 201);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 64);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 14F);
            btnZero.Location = new Point(93, 271);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 64);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Segoe UI", 14F);
            btnVirgula.Location = new Point(174, 271);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(75, 64);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 14F);
            btnIgual.Location = new Point(267, 295);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(61, 40);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 14F);
            btnDivisao.Location = new Point(267, 139);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(61, 33);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 14F);
            btnMultiplicacao.Location = new Point(267, 178);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(61, 33);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Font = new Font("Segoe UI", 14F);
            btnSubtrair.Location = new Point(-679, 739);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(61, 64);
            btnSubtrair.TabIndex = 15;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btnSomar
            // 
            btnSomar.Font = new Font("Segoe UI", 14F);
            btnSomar.Location = new Point(267, 256);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(61, 33);
            btnSomar.TabIndex = 16;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 14F);
            btnLimpar.Location = new Point(267, 100);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(61, 33);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "c";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // btnMaisMenos
            // 
            btnMaisMenos.Font = new Font("Segoe UI", 14F);
            btnMaisMenos.Location = new Point(12, 271);
            btnMaisMenos.Name = "btnMaisMenos";
            btnMaisMenos.Size = new Size(75, 64);
            btnMaisMenos.TabIndex = 19;
            btnMaisMenos.Text = "+/-";
            btnMaisMenos.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Segoe UI", 14F);
            btnMenos.Location = new Point(267, 217);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(61, 33);
            btnMenos.TabIndex = 20;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.Location = new Point(267, 61);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 33);
            btnBack.TabIndex = 21;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Segoe UI", 15F);
            lblOperacao.Location = new Point(18, 22);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 28);
            lblOperacao.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 353);
            Controls.Add(lblOperacao);
            Controls.Add(btnBack);
            Controls.Add(btnMenos);
            Controls.Add(btnMaisMenos);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnSomar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnOito;
        private Button btnnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtrair;
        private Button btnSomar;
        private Button btnLimpar;
        private Label label1;
        private Button btnMaisMenos;
        private Button btnMenos;
        private Button btnBack;
        private Label lblOperacao;
    }
}
