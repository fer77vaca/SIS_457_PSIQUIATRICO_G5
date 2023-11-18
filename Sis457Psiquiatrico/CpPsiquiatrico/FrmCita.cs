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
    public partial class FrmCita : Form
    {
        bool esNuevo = false;
        public FrmCita()
        {
            InitializeComponent();
            //dgvLista.DataSource = CitaCln.listarPa("");
            // dgvLista.DataSource = PersonalCln.listarPa("");
        }
        private void listar()
        {
            var citas = CitaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = citas;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idPaciente"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre_paciente"].HeaderText = "Paciente";
            dgvLista.Columns["motivo_cita"].HeaderText = "Motivo_Cita";
            dgvLista.Columns["fechaReservacion"].HeaderText = "Fecha_Reservacion";
            dgvLista.Columns["pago"].HeaderText = "Pago_(Bs)";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = citas.Count > 0;
            btnEliminar.Enabled = citas.Count > 0;
            if (citas.Count > 0) dgvLista.Rows[0].Cells["motivo_cita"].Selected = true;
        }
        private void cargarPaciente ()
        {
            cbxPaciente.DataSource = PacienteCln.listar();
            cbxPaciente.DisplayMember = "nombre";
            cbxPaciente.ValueMember = "id";
        }
        private void FrmCita_Load(object sender, EventArgs e)
        {
            Size = new Size(1000, 353); //1000, 564   1000, 353
            listar();
            cargarPaciente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1000, 564);
            txtMotivo.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1000, 564);

            cbxPaciente.Enabled = false;  // ULTIMA MELBIN

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var cita = CitaCln.get(id);
            txtMotivo.Text = cita.motivo;
            dtpFechaResrvacion.Value = cita.fechaReservacion;
            nudPago.Value = cita.pago;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1000, 353);
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
            erpMotivo.SetError(txtMotivo, "");
            erpFechaResrvacion.SetError(dtpFechaResrvacion, "");
            erpPago.SetError(nudPago, "");
            erpPaciente.SetError(cbxPaciente, "");
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                esValido = false;
                erpMotivo.SetError(txtMotivo, "El campo Motivo es obligatorio");
            }
            if (string.IsNullOrEmpty(dtpFechaResrvacion.Text))
            {
                esValido = false;
                erpFechaResrvacion.SetError(dtpFechaResrvacion, "El campo Fecha Reservacion es obligatorio");
            }
            if (string.IsNullOrEmpty(nudPago.Text))
            {
                esValido = false;
                erpPago.SetError(nudPago, "El campo Pago es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxPaciente.Text))
            {
                esValido = false;
                erpPaciente.SetError(cbxPaciente, "El campo Paciente es obligatorio");
            }
      
            return esValido;
        }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
            if (validar())
            {
                var cita = new Cita();
                cita.motivo = txtMotivo.Text.Trim();
                cita.fechaReservacion = dtpFechaResrvacion.Value;
                cita.pago = nudPago.Value;
                cita.usuarioRegistro = "FVC";

                if (esNuevo)
                {
                    cita.fechaRegistro = DateTime.Now;
                    cita.estado = 1;
                    cita.idPaciente = Convert.ToInt32(cbxPaciente.SelectedValue);
                    //cita.idPaciente = 1;
                    CitaCln.insertar(cita);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    cita.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    CitaCln.actualizar(cita);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Cita guardado exitosamente", "::: Psiquiatrico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtMotivo.Text = string.Empty;
            dtpFechaResrvacion.Value = DateTime.Now;
            nudPago.Value = 0;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string motivo_cita = dgvLista.Rows[index].Cells["motivo_cita"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"Esta seguro que desea eliminar la cita {motivo_cita}?",
                "::: Psiquiatrico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                CitaCln.eliminar(id, "FVC");
                listar();
                MessageBox.Show("Cita eliminada correctamente", "::: Psiquiatrico - Mensaje :::",
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
