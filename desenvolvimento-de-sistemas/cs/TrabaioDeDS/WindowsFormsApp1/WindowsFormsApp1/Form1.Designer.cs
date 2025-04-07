namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbPotencia = new System.Windows.Forms.RadioButton();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(206, 193);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 28);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(119, 193);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(62, 28);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(30, 193);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(66, 28);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.Execultar_Click);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(36, 61);
            this.rdbSubtrair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 4;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(36, 83);
            this.rdbDividir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(54, 17);
            this.rdbDividir.TabIndex = 5;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(36, 102);
            this.rdbMultiplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplicar.TabIndex = 6;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbPotencia
            // 
            this.rdbPotencia.AutoSize = true;
            this.rdbPotencia.Location = new System.Drawing.Point(37, 122);
            this.rdbPotencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbPotencia.Name = "rdbPotencia";
            this.rdbPotencia.Size = new System.Drawing.Size(67, 17);
            this.rdbPotencia.TabIndex = 7;
            this.rdbPotencia.TabStop = true;
            this.rdbPotencia.Text = "Potencia";
            this.rdbPotencia.UseVisualStyleBackColor = true;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(185, 40);
            this.txtN1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(68, 20);
            this.txtN1.TabIndex = 8;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(185, 86);
            this.txtN2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(68, 20);
            this.txtN2.TabIndex = 9;
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(185, 122);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(67, 17);
            this.result.TabIndex = 10;
            this.result.Text = "?";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSinal.Location = new System.Drawing.Point(213, 62);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(15, 15);
            this.lblSinal.TabIndex = 11;
            this.lblSinal.Text = "?";
            this.lblSinal.Click += new System.EventHandler(this.conta_Click);
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(36, 43);
            this.rdbSomar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(58, 17);
            this.rdbSomar.TabIndex = 12;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = " Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "______________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(296, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbSomar);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.rdbPotencia);
            this.Controls.Add(this.rdbMultiplicar);
            this.Controls.Add(this.rdbDividir);
            this.Controls.Add(this.rdbSubtrair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Cáculos com RadioButtons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rdbPotencia;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.Label label1;
    }
}

