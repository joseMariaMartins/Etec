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
    public partial class fmrCalcRadio : Form
    {
        public fmrCalcRadio()
        {
            InitializeComponent();
        }
        private void cBsomar_CheckedChanged(object sender, EventArgs e)
        {
            if (cBsomar.Checked)
            {
                if (cBSub.Checked || cBMulti.Checked || cBDividir.Checked || cBPoten.Checked)
                {
                    cBSub.Checked = false;
                    cBMulti.Checked = false;
                    cBDividir.Checked = false;
                    cBPoten.Checked = false;
                }
                lBLSinalR.Text = " + ";

            }
           
        }

        private void cBSub_CheckedChanged(object sender, EventArgs e)
        {
            if (cBSub.Checked)
            {
                if(cBsomar.Checked || cBMulti.Checked || cBDividir.Checked || cBPoten.Checked)
                {
                    cBsomar.Checked = false;
                    cBMulti.Checked = false;
                    cBDividir.Checked = false;
                    cBPoten.Checked = false;
                }

                lBLSinalR.Text = " - ";
               
            } 
  
        }

        private void cBMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMulti.Checked)
            {
                if (cBsomar.Checked || cBSub.Checked || cBDividir.Checked || cBPoten.Checked)
                {
                    cBsomar.Checked = false;
                    cBSub.Checked = false;
                    cBDividir.Checked = false;
                    cBPoten.Checked = false;
                }

                lBLSinalR.Text = " * ";
            }
        }
        private void cBDividir_CheckedChanged(object sender, EventArgs e)
        {
            if (cBDividir.Checked)
            {
                if (cBsomar.Checked || cBSub.Checked || cBMulti.Checked || cBPoten.Checked)
                {
                    cBsomar.Checked = false;
                    cBSub.Checked = false;
                    cBMulti.Checked = false;
                    cBPoten.Checked = false;
                }

                lBLSinalR.Text = " / ";
            }
        }

        private void cBPoten_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPoten.Checked)
            {
                if (cBsomar.Checked || cBSub.Checked || cBMulti.Checked || cBDividir.Checked)
                {
                    cBsomar.Checked = false;
                    cBSub.Checked = false;
                    cBMulti.Checked = false;
                    cBDividir.Checked = false;
                }

                lBLSinalR.Text = " ^ ";

            }
        }

        private void bTNLimparR_Click(object sender, EventArgs e)
        {
            tXTN1R.Clear();
            tXTN2R.Clear();
            lBLSinalR.Text = "?";
            lBLResultadoR.Text = "?";
            if (cBsomar.Checked || cBSub.Checked || cBMulti.Checked || cBDividir.Checked || cBPoten.Checked)
            {
                cBsomar.Checked = false;
                cBSub.Checked = false;
                cBMulti.Checked = false;
                cBDividir.Checked = false;
                cBPoten.Checked = false;
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b;

            if (cBsomar.Checked)
            {

                a = double.Parse(tXTN1R.Text);
                b = double.Parse(tXTN2R.Text);
                lBLResultadoR.Text = (a + b).ToString();

            }else if (cBSub.Checked)
            {
                a = double.Parse(tXTN1R.Text);
                b = double.Parse(tXTN2R.Text);
                lBLResultadoR.Text = (a - b).ToString();
            }else if (cBMulti.Checked)
            {
                a = double.Parse(tXTN1R.Text);
                b = double.Parse(tXTN2R.Text);
                lBLResultadoR.Text = (a * b).ToString();
            }else if (cBDividir.Checked)
            {
                a = double.Parse(tXTN1R.Text);
                b = double.Parse(tXTN2R.Text);
                lBLResultadoR.Text = (a / b).ToString();
            }else if (cBPoten.Checked)
            {
                a = double.Parse(tXTN1R.Text);
                b = double.Parse(tXTN2R.Text);
                lBLResultadoR.Text = (Math.Pow(a, b)).ToString();
            }
        }
    }
}
