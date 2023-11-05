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
        bool esNuevo = false;
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
            btnEditar.Enabled = personales.Count > 0;
            btnEliminar.Enabled = personales.Count > 0;
            if (personales.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            Size = new Size (1018, 396);
            listar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size (1018, 611);
            txtNombre.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1018, 611);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var personal = PersonalCln.get(id);
            txtNombre.Text = personal.nombre;
            txtCedula.Text = personal.cedulaIdentidad;
            txtEspecialidad.Text = personal.especialidad;
            txtTelefono.Text = personal.telefono;
            txtHorario.Text = personal.horarioTrabajo;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1018, 396);
            limpiar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var personal = new Personal();
            personal.nombre = txtNombre.Text.Trim();
            personal.cedulaIdentidad = txtCedula.Text.Trim();
            personal.especialidad = txtEspecialidad.Text.Trim();
            personal.telefono = txtTelefono.Text.Trim();
            personal.horarioTrabajo = txtHorario.Text.Trim();
            personal.usuarioRegistro = "SIS_457";

            if (esNuevo)
            {
                personal.fechaRegistro = DateTime.Now;
                personal.estado = 1;
                PersonalCln.insertar(personal);
            }
            else
            {
                int index = dgvLista.CurrentCell.RowIndex;
                personal.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                PersonalCln.actualizar(personal);
            }
            listar();
            btnCancelar.PerformClick();
            MessageBox.Show("Personal guardado exitosamente", "::: Psiquiatrico - Mensaje :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void limpiar ()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtHorario.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"Esta seguro que desea eliminar el personal {nombre}?",
                "::: Psiquiatrico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PersonalCln.eliminar(id, "SIS_457");
                listar();
                MessageBox.Show("Personal eliminado correctamente", "::: Psiquiatrico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
