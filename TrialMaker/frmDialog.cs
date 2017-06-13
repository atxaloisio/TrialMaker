using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareLocker
{
    public partial class frmDialog : Form
    {
        private string _Pass;

        public frmDialog(string BaseString,
            string Password,int DaysToEnd,int Runed, string info)
        {
            InitializeComponent();
            sebBaseString.Text = BaseString;
            _Pass = Password;
            lblDays.Text = DaysToEnd.ToString() + " Dia(s)";
            //lblTimes.Text = Runed.ToString() + "x";
            lblText.Text = info;
            if (DaysToEnd <= 0)
            {
                lblDays.Text = "Terminado";
                //lblTimes.Text = "Terminado";
                btnTrial.Enabled = false;
            }

            sebPassword.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_Pass == sebPassword.Text)
            {
                MessageBox.Show("Serial informado válido. Liceça registrada.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Serial informado inválido.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
    }
}