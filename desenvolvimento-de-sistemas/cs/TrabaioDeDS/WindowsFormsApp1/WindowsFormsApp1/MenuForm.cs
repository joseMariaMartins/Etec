using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }


        private bool IsFormOpen(string formName)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formName)
                {
                    MessageBox.Show($"O formulário '{formName}' já está aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; 
                }
            }
            return false; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlDataHora.Text = DateTime.Now.ToString();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("frmCalcButtons"))
            {
                frmCalcButtons objCalBot = new frmCalcButtons();
                objCalBot.MdiParent = this;
                objCalBot.Name = "frmCalcButtons";
                objCalBot.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculadoraPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("Form2"))
            {
                Form2 objCalBot = new Form2();
                objCalBot.MdiParent = this;
                objCalBot.Name = "Form2"; 
                objCalBot.Show();
            }
        }

        private void comRádioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("Form1"))
            {
                Form1 objCalBot = new Form1();
                objCalBot.MdiParent = this;
                objCalBot.Name = "Form1"; 
                objCalBot.Show();
            }
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza de que quer sair?", "Você esta saindo!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void frmCalcButtons_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("frmCalcButtons"))
            {
                frmCalcButtons objCalBot = new frmCalcButtons();
                objCalBot.MdiParent = this;
                objCalBot.Name = "frmCalcButtons";
                objCalBot.Show();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("Form1"))
            {
                Form1 objCalBot = new Form1();
                objCalBot.MdiParent = this;
                objCalBot.Name = "Form1"; 
                objCalBot.Show();
            }
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("Form2"))
            {
                Form2 objCalBot = new Form2();
                objCalBot.MdiParent = this;
                objCalBot.Name = "Form2"; 
                objCalBot.Show();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            stlDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
