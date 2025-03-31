using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos_1TDSN_2025
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void comBotoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcButtons objCalBot = new frmCalcButtons();
            //Assim Abre dentro da janela
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Quer sair mesmo???", "Cê ta saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)==DialogResult.No)
 // aparecer caixa de mensagem,         texto,          título       aparecer botão             ícone do botão         posição inicial padrão       resultado do click do usuario                  
            {
                e.Cancel = true;

                //esse é o botão não
            }
            else
            {
                e.Cancel=false;

                //esse é o botão sim
            }
            //da pra entender só de ver
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlDataHora.Text = DateTime.Now.ToString();
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCalcRadio objCalRad = new fmrCalcRadio();
            objCalRad.MdiParent = this;
            objCalRad.Show();
        }
    }
}