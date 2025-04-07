namespace WindowsFormsApp1
{
    partial class MDI_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comBotõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comRádioButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorÚnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.frmCalcButtons = new System.Windows.Forms.ToolStripButton();
            this.Form1 = new System.Windows.Forms.ToolStripButton();
            this.Form2 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem
            // 
            this.calculadorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comBotõesToolStripMenuItem,
            this.comRádioButtonsToolStripMenuItem,
            this.calculadoraPlusToolStripMenuItem,
            this.visorÚnicoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.calculadorasToolStripMenuItem.Name = "calculadorasToolStripMenuItem";
            this.calculadorasToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.calculadorasToolStripMenuItem.Text = "Calculadoras";
            // 
            // comBotõesToolStripMenuItem
            // 
            this.comBotõesToolStripMenuItem.Name = "comBotõesToolStripMenuItem";
            this.comBotõesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.comBotõesToolStripMenuItem.Text = "Com Botões";
            this.comBotõesToolStripMenuItem.Click += new System.EventHandler(this.comBotõesToolStripMenuItem_Click);
            // 
            // comRádioButtonsToolStripMenuItem
            // 
            this.comRádioButtonsToolStripMenuItem.Name = "comRádioButtonsToolStripMenuItem";
            this.comRádioButtonsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.comRádioButtonsToolStripMenuItem.Text = "Com RádioButtons";
            this.comRádioButtonsToolStripMenuItem.Click += new System.EventHandler(this.comRádioButtonsToolStripMenuItem_Click);
            // 
            // calculadoraPlusToolStripMenuItem
            // 
            this.calculadoraPlusToolStripMenuItem.Name = "calculadoraPlusToolStripMenuItem";
            this.calculadoraPlusToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.calculadoraPlusToolStripMenuItem.Text = "Calculadora Plus";
            this.calculadoraPlusToolStripMenuItem.Click += new System.EventHandler(this.calculadoraPlusToolStripMenuItem_Click);
            // 
            // visorÚnicoToolStripMenuItem
            // 
            this.visorÚnicoToolStripMenuItem.Name = "visorÚnicoToolStripMenuItem";
            this.visorÚnicoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.visorÚnicoToolStripMenuItem.Text = "Visor Único";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmCalcButtons,
            this.Form1,
            this.Form2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmCalcButtons
            // 
            this.frmCalcButtons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmCalcButtons.BackgroundImage")));
            this.frmCalcButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmCalcButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.frmCalcButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frmCalcButtons.Name = "frmCalcButtons";
            this.frmCalcButtons.Size = new System.Drawing.Size(23, 22);
            this.frmCalcButtons.Text = "toolStripButton1";
            this.frmCalcButtons.Click += new System.EventHandler(this.frmCalcButtons_Click);
            // 
            // Form1
            // 
            this.Form1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Form1.BackgroundImage")));
            this.Form1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Form1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Form1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Form1.Name = "Form1";
            this.Form1.Size = new System.Drawing.Size(23, 22);
            this.Form1.Text = "toolStripButton2";
            this.Form1.Click += new System.EventHandler(this.Form1_Click);
            // 
            // Form2
            // 
            this.Form2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Form2.BackgroundImage")));
            this.Form2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Form2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Form2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(23, 22);
            this.Form2.Text = "toolStripButton3";
            this.Form2.Click += new System.EventHandler(this.Form2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.stlDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel2.Text = "**Mensagem**";
            // 
            // stlDataHora
            // 
            this.stlDataHora.Name = "stlDataHora";
            this.stlDataHora.Size = new System.Drawing.Size(36, 17);
            this.stlDataHora.Text = "Hora:";
            // 
            // MDI_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 298);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MDI_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDI_Menu_FormClosing);
            this.Load += new System.EventHandler(this.MDI_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comBotõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comRádioButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraPlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visorÚnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stlDataHora;
        private System.Windows.Forms.ToolStripButton frmCalcButtons;
        private System.Windows.Forms.ToolStripButton Form1;
        private System.Windows.Forms.ToolStripButton Form2;
    }
}