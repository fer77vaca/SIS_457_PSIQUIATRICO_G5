using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpPsiquiatrico
{
    public partial class FrmMenu : Form
    {
        private Form currentChilForm;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal personal = new FrmPersonal();
            personal.Show();

            this.Hide();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FrmPaciente paciente = new FrmPaciente();
            paciente.Show();

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd MMM yyy");
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            FrmCita cita = new FrmCita();
            cita.Show();

            this.Hide();
        }

        private void btnUsusario_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.Show();

            this.Hide();
        }
    }
    //public void OpenChilForm(Form ChilForm)
    //{
    //    if (currentChilForm != null)
    //    {
    //        currentChilForm.Close();
    //    }
    //    currentChilForm = ChilForm;
    //    ChilForm.TopLevel = false;
    //    ChilForm.Dock = DockStyle.Fill;
    //    ChilForm.FormBorderStyle = FormBorderStyle.None;
    //    pnlControl.Controls.Add(ChilForm);
    //    pnlControl.Tag = ChilForm;
    //    ChilForm.BringToFront();
    //    ChilForm.Show();
    //}
}
