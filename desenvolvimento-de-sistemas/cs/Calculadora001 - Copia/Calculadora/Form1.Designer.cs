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
            btnMaisMenos = new Button();
            btnMenos = new Button();
            btnBack = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F);
            txtResultado.Location = new Point(15, 18);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(316, 61);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 14F);
            btnSete.Location = new Point(15, 99);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(75, 64);
            btnSete.TabIndex = 1;
            btnSete.Tag = "";
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += f_numeros;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 14F);
            btnOito.Location = new Point(96, 99);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(75, 64);
            btnOito.TabIndex = 2;
            btnOito.Tag = "";
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += f_numeros;
            // 
            // btnnNove
            // 
            btnnNove.Font = new Font("Segoe UI", 14F);
            btnnNove.Location = new Point(177, 99);
            btnnNove.Name = "btnnNove";
            btnnNove.Size = new Size(75, 64);
            btnnNove.TabIndex = 3;
            btnnNove.Tag = "";
            btnnNove.Text = "9";
            btnnNove.UseVisualStyleBackColor = true;
            btnnNove.Click += f_numeros;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 14F);
            btnQuatro.Location = new Point(15, 169);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(75, 64);
            btnQuatro.TabIndex = 4;
            btnQuatro.Tag = "";
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += f_numeros;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 14F);
            btnCinco.Location = new Point(96, 169);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(75, 64);
            btnCinco.TabIndex = 5;
            btnCinco.Tag = "";
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += f_numeros;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 14F);
            btnSeis.Location = new Point(177, 169);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(75, 64);
            btnSeis.TabIndex = 6;
            btnSeis.Tag = "";
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += f_numeros;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 14F);
            btnUm.Location = new Point(15, 239);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(75, 64);
            btnUm.TabIndex = 7;
            btnUm.Tag = "";
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += f_numeros;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 14F);
            btnDois.Location = new Point(96, 239);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(75, 64);
            btnDois.TabIndex = 8;
            btnDois.Tag = "";
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += f_numeros;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 14F);
            btnTres.Location = new Point(177, 239);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 64);
            btnTres.TabIndex = 9;
            btnTres.Tag = "";
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += f_numeros;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 14F);
            btnZero.Location = new Point(96, 309);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 64);
            btnZero.TabIndex = 10;
            btnZero.Tag = "";
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += f_numeros;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Segoe UI", 14F);
            btnVirgula.Location = new Point(177, 309);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(75, 64);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += f_calculos;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 14F);
            btnIgual.Location = new Point(270, 333);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(61, 40);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += f_calculos;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 14F);
            btnDivisao.Location = new Point(270, 177);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(61, 33);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += f_calculos;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 14F);
            btnMultiplicacao.Location = new Point(270, 216);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(61, 33);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += f_calculos;
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
            btnSomar.Location = new Point(270, 294);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(61, 33);
            btnSomar.TabIndex = 16;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += f_calculos;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 14F);
            btnLimpar.Location = new Point(270, 138);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(61, 33);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "c";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += f_calculos;
            // 
            // btnMaisMenos
            // 
            btnMaisMenos.Font = new Font("Segoe UI", 14F);
            btnMaisMenos.Location = new Point(15, 309);
            btnMaisMenos.Name = "btnMaisMenos";
            btnMaisMenos.Size = new Size(75, 64);
            btnMaisMenos.TabIndex = 19;
            btnMaisMenos.Text = "+/-";
            btnMaisMenos.UseVisualStyleBackColor = true;
            btnMaisMenos.Click += f_calculos;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Segoe UI", 14F);
            btnMenos.Location = new Point(270, 255);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(61, 33);
            btnMenos.TabIndex = 20;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += f_calculos;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.Location = new Point(270, 99);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 33);
            btnBack.TabIndex = 21;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += f_calculos;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = SystemColors.ButtonHighlight;
            lblOperacao.Font = new Font("Segoe UI", 10F);
            lblOperacao.Location = new Point(26, 33);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 19);
            lblOperacao.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 387);
            Controls.Add(lblOperacao);
            Controls.Add(btnBack);
            Controls.Add(btnMenos);
            Controls.Add(btnMaisMenos);
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
            Tag = "";
            Text = "Calculadora";
            Click += f_numeros;
            KeyPress += btnNumerico;
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
        private Label label2;
        private Button btnMaisMenos;
        private Button btnMenos;
        private Button btnBack;
        private Label lblOperacao;
    }
}
