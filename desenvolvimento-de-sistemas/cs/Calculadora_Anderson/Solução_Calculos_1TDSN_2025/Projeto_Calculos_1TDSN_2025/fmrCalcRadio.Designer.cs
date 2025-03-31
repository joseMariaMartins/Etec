namespace Projeto_Calculos_1TDSN_2025
{
    partial class fmrCalcRadio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bTNLimparR = new System.Windows.Forms.Button();
            this.bTNFecharR = new System.Windows.Forms.Button();
            this.lBLResultadoR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tXTN1R = new System.Windows.Forms.TextBox();
            this.tXTN2R = new System.Windows.Forms.TextBox();
            this.lBLSinalR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBsomar = new System.Windows.Forms.CheckBox();
            this.cBSub = new System.Windows.Forms.CheckBox();
            this.cBMulti = new System.Windows.Forms.CheckBox();
            this.cBDividir = new System.Windows.Forms.CheckBox();
            this.cBPoten = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTNLimparR
            // 
            this.bTNLimparR.Location = new System.Drawing.Point(12, 301);
            this.bTNLimparR.Name = "bTNLimparR";
            this.bTNLimparR.Size = new System.Drawing.Size(89, 31);
            this.bTNLimparR.TabIndex = 0;
            this.bTNLimparR.Text = "Limpar";
            this.bTNLimparR.UseVisualStyleBackColor = true;
            this.bTNLimparR.Click += new System.EventHandler(this.bTNLimparR_Click);
            // 
            // bTNFecharR
            // 
            this.bTNFecharR.Location = new System.Drawing.Point(386, 301);
            this.bTNFecharR.Name = "bTNFecharR";
            this.bTNFecharR.Size = new System.Drawing.Size(89, 31);
            this.bTNFecharR.TabIndex = 1;
            this.bTNFecharR.Text = "Fechar";
            this.bTNFecharR.UseVisualStyleBackColor = true;
            // 
            // lBLResultadoR
            // 
            this.lBLResultadoR.AllowDrop = true;
            this.lBLResultadoR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lBLResultadoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLResultadoR.Location = new System.Drawing.Point(340, 228);
            this.lBLResultadoR.Name = "lBLResultadoR";
            this.lBLResultadoR.Size = new System.Drawing.Size(111, 31);
            this.lBLResultadoR.TabIndex = 3;
            this.lBLResultadoR.Text = "?";
            this.lBLResultadoR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "__________________________________________________";
            // 
            // tXTN1R
            // 
            this.tXTN1R.Location = new System.Drawing.Point(319, 49);
            this.tXTN1R.Name = "tXTN1R";
            this.tXTN1R.Size = new System.Drawing.Size(156, 20);
            this.tXTN1R.TabIndex = 5;
            this.tXTN1R.Text = "0";
            this.tXTN1R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tXTN2R
            // 
            this.tXTN2R.Location = new System.Drawing.Point(319, 132);
            this.tXTN2R.Name = "tXTN2R";
            this.tXTN2R.Size = new System.Drawing.Size(156, 20);
            this.tXTN2R.TabIndex = 6;
            this.tXTN2R.Text = "0";
            this.tXTN2R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBLSinalR
            // 
            this.lBLSinalR.AllowDrop = true;
            this.lBLSinalR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLSinalR.Location = new System.Drawing.Point(373, 85);
            this.lBLSinalR.Name = "lBLSinalR";
            this.lBLSinalR.Size = new System.Drawing.Size(53, 31);
            this.lBLSinalR.TabIndex = 7;
            this.lBLSinalR.Text = "?";
            this.lBLSinalR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 214);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operações";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cBsomar
            // 
            this.cBsomar.AutoSize = true;
            this.cBsomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBsomar.Location = new System.Drawing.Point(21, 52);
            this.cBsomar.Name = "cBsomar";
            this.cBsomar.Size = new System.Drawing.Size(53, 17);
            this.cBsomar.TabIndex = 9;
            this.cBsomar.Text = "Somar";
            this.cBsomar.UseVisualStyleBackColor = true;
            this.cBsomar.CheckedChanged += new System.EventHandler(this.cBsomar_CheckedChanged);
            // 
            // cBSub
            // 
            this.cBSub.AutoSize = true;
            this.cBSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSub.Location = new System.Drawing.Point(21, 85);
            this.cBSub.Name = "cBSub";
            this.cBSub.Size = new System.Drawing.Size(59, 17);
            this.cBSub.TabIndex = 10;
            this.cBSub.Text = "Subtrair";
            this.cBSub.UseVisualStyleBackColor = true;
            this.cBSub.CheckedChanged += new System.EventHandler(this.cBSub_CheckedChanged);
            // 
            // cBMulti
            // 
            this.cBMulti.AutoSize = true;
            this.cBMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBMulti.Location = new System.Drawing.Point(21, 119);
            this.cBMulti.Name = "cBMulti";
            this.cBMulti.Size = new System.Drawing.Size(70, 17);
            this.cBMulti.TabIndex = 11;
            this.cBMulti.Text = "Multiplicar";
            this.cBMulti.UseVisualStyleBackColor = true;
            this.cBMulti.CheckedChanged += new System.EventHandler(this.cBMulti_CheckedChanged);
            // 
            // cBDividir
            // 
            this.cBDividir.AutoSize = true;
            this.cBDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBDividir.Location = new System.Drawing.Point(21, 157);
            this.cBDividir.Name = "cBDividir";
            this.cBDividir.Size = new System.Drawing.Size(52, 17);
            this.cBDividir.TabIndex = 12;
            this.cBDividir.Text = "Dividir";
            this.cBDividir.UseVisualStyleBackColor = true;
            this.cBDividir.CheckedChanged += new System.EventHandler(this.cBDividir_CheckedChanged);
            // 
            // cBPoten
            // 
            this.cBPoten.AutoSize = true;
            this.cBPoten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBPoten.Location = new System.Drawing.Point(21, 193);
            this.cBPoten.Name = "cBPoten";
            this.cBPoten.Size = new System.Drawing.Size(98, 17);
            this.cBPoten.TabIndex = 13;
            this.cBPoten.Text = "Potencialização";
            this.cBPoten.UseVisualStyleBackColor = true;
            this.cBPoten.CheckedChanged += new System.EventHandler(this.cBPoten_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(198, 301);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 31);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // fmrCalcRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(479, 335);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cBPoten);
            this.Controls.Add(this.cBDividir);
            this.Controls.Add(this.cBMulti);
            this.Controls.Add(this.cBSub);
            this.Controls.Add(this.cBsomar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lBLSinalR);
            this.Controls.Add(this.tXTN2R);
            this.Controls.Add(this.tXTN1R);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBLResultadoR);
            this.Controls.Add(this.bTNFecharR);
            this.Controls.Add(this.bTNLimparR);
            this.Name = "fmrCalcRadio";
            this.Text = "fmrCaldRadio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTNLimparR;
        private System.Windows.Forms.Button bTNFecharR;
        private System.Windows.Forms.Label lBLResultadoR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tXTN1R;
        private System.Windows.Forms.TextBox tXTN2R;
        private System.Windows.Forms.Label lBLSinalR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBsomar;
        private System.Windows.Forms.CheckBox cBSub;
        private System.Windows.Forms.CheckBox cBMulti;
        private System.Windows.Forms.CheckBox cBDividir;
        private System.Windows.Forms.CheckBox cBPoten;
        private System.Windows.Forms.Button btnCalcular;
    }
}