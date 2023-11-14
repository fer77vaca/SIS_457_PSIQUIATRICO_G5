using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpPsiquiatrico
{
    public partial class FrmPrincipal : Form
    {
        private Form currentChilForm;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void OpenChilForm(Form ChilForm)
        {
            if (currentChilForm != null)
            {
                currentChilForm.Close();
            }
            currentChilForm = ChilForm;
            ChilForm.TopLevel = false;
            ChilForm.Dock = DockStyle.Fill;
            ChilForm.FormBorderStyle = FormBorderStyle.None;
            pnlControl.Controls.Add(ChilForm);
            pnlControl.Tag = ChilForm;
            ChilForm.BringToFront();
            ChilForm.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            OpenChilForm(new FrmPersonal());
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            OpenChilForm(new FrmPaciente());
        }
    }
}
