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
    public partial class FrmPaciente : Form
    {
        bool esNuevo = false;
        public FrmPaciente()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var pacientes = PacienteCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = pacientes;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idPersonal"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombrePersonal"].HeaderText = "Personal";
            dgvLista.Columns["nombrePaciente"].HeaderText = "Paciente";
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "C.I.";
            dgvLista.Columns["edad"].HeaderText = "Edad";
            dgvLista.Columns["telefono"].HeaderText = "Telefono";
            dgvLista.Columns["historialMedico"].HeaderText = "Historial_Medico";
            dgvLista.Columns["tratamiento"].HeaderText = "Tratamiento";
            dgvLista.Columns["fechaAdmision"].HeaderText = "Fecha_Admision";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = pacientes.Count>0;
            btnEliminar.Enabled = pacientes.Count>0;
            if (pacientes.Count > 0) dgvLista.Rows[0].Cells["nombrePaciente"].Selected = true;
        }
        private void cargarPersonal ()
        {
            cbxPersonal.DataSource = PersonalCln.listar();
            cbxPersonal.DisplayMember = "nombre"; 
            cbxPersonal.ValueMember = "id";
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            Size = new Size(1000, 336);  //1000, 564  1000, 336
            listar();
            cargarPersonal();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1000, 564);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1000, 564);

            cbxPersonal.Enabled = false;        // Ultima modificacion MELBYN 

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var paciente = PacienteCln.get(id);
            txtNombre.Text = paciente.nombre;
            txtCedula.Text = paciente.cedulaIdentidad;
            txtTelefono.Text = paciente.telefono;
            txtHistorial.Text = paciente.historialMedico;
            txtTratamiento.Text = paciente.tratamiento;
            nudEdad.Value = paciente.edad;
            dtpFechaAdmision.Value = paciente.fechaAdmision;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1000, 336);
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpNombre.SetError(txtNombre, "");
            erpCedula.SetError(txtCedula, "");
            erpEdad.SetError(nudEdad, "");
            erpTelefono.SetError(txtTelefono, "");
            erpHistorial.SetError(txtHistorial, "");
            erpTratamiento.SetError(txtTratamiento, "");
            erpFechaAdmision.SetError(dtpFechaAdmision, "");
            erpPersonal.SetError(cbxPersonal, "");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                esValido = false;
                erpCedula.SetError(txtCedula, "El campo Cedula es obligatorio");
            }
            if (string.IsNullOrEmpty(nudEdad.Text))
            {
                esValido = false;
                erpEdad.SetError(nudEdad, "El campo Especialidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo Telefono es obligatorio");
            }
            if (string.IsNullOrEmpty(txtHistorial.Text))
            {
                esValido = false;
                erpHistorial.SetError(txtHistorial, "El campo Historial es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTratamiento.Text))
            {
                esValido = false;
                erpTratamiento.SetError(txtTratamiento, "El campo Tratamiento es obligatorio");
            }
            if (string.IsNullOrEmpty(dtpFechaAdmision.Text))
            {
                esValido = false;
                erpFechaAdmision.SetError(txtTratamiento, "El campo Fecha de Admision es obligatorio");
            }
            if(string.IsNullOrEmpty(cbxPersonal.Text))
            {
                esValido = false;
                erpPersonal.SetError(cbxPersonal, "El campo Personal es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var paciente = new Paciente();
                paciente.nombre = txtNombre.Text.Trim();
                paciente.cedulaIdentidad = txtCedula.Text.Trim();
                paciente.telefono = txtTelefono.Text.Trim();
                paciente.historialMedico = txtHistorial.Text.Trim();
                paciente.tratamiento = txtTratamiento.Text.Trim();
                paciente.edad = Convert.ToInt32(nudEdad.Text);
                paciente.fechaAdmision = dtpFechaAdmision.Value;
                paciente.usuarioRegistro = "FVC";

                if (esNuevo)
                {
                    paciente.fechaRegistro = DateTime.Now;
                    paciente.estado = 1;
                    paciente.idPersonal = Convert.ToInt32(cbxPersonal.SelectedValue);
                    //paciente.idPersonal = 2;
                    PacienteCln.insertar(paciente);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    paciente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    PacienteCln.actualizar(paciente);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Paciente guardado exitosamente", "::: Psiquiatrico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtHistorial.Text = string.Empty;
            txtTratamiento.Text = string.Empty;
            nudEdad.Value = 0;
            dtpFechaAdmision.Value = DateTime.Now;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string nombrePaciente = dgvLista.Rows[index].Cells["nombrePaciente"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"Esta seguro que desea eliminar el paciente {nombrePaciente}?",
                "::: Psiquiatrico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PacienteCln.eliminar(id, "FVC");
                listar();
                MessageBox.Show("Paciente eliminado correctamente", "::: Psiquiatrico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();

            this.Close();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
