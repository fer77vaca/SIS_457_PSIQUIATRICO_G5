using CadPsiquiatrico;
using ClnPsiquiatrico;
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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
            // dgvLista.DataSource = PersonalCln.listarPa("");
        }
        private void listar()
        {
            var personales = PersonalCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = personales;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre Completo";
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "C.I.";
            dgvLista.Columns["especialidad"].HeaderText = "Especialidad";
            dgvLista.Columns["telefono"].HeaderText = "Telefono";
            dgvLista.Columns["horarioTrabajo"].HeaderText = "Horario de Trabajo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha del Registro";
        }
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            Size = new Size (1018, 396);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size (1018, 611);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(1018, 611);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1018, 396);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
