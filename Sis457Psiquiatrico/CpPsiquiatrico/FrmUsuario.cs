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
    public partial class FrmUsuario : Form
    {
        bool esNuevo = false;
        public FrmUsuario()
        {
            InitializeComponent();
            //dgvLista.DataSource = UsuarioCln.listarPa("");
            //dgvLista.DataSource = PersonalCln.listarPa("");
        }
        private void listar()
        {
            var usuarios = UsuarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = usuarios;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idPersonal"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "C.I Personal";
            dgvLista.Columns["usuario"].HeaderText = "Usuario";
            dgvLista.Columns["clave"].HeaderText = "Clave";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = usuarios.Count > 0;
            btnEliminar.Enabled = usuarios.Count > 0;
            if (usuarios.Count > 0) dgvLista.Rows[0].Cells["usuario"].Selected = true;
        }
        private void cargarPersonal()
        {
            cbxCedulaIdentidad.DataSource = PersonalCln.listar();
            cbxCedulaIdentidad.DisplayMember = "cedulaIdentidad";
            cbxCedulaIdentidad.ValueMember = "id";
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Size = new Size(1000, 367);
            listar(); //1000, 562 1000, 367
            cargarPersonal();
        }
        private bool validar ()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                esValido = false;
                erpClave.SetError(txtClave, "El campo Clave es obligatorio");
            }
            return esValido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = new Usuario();
                usuario.usuario1 = txtUsuario.Text.Trim();
                usuario.clave = Util.Encrypt(txtClave.Text.Trim());
                usuario.usuarioRegistro = "FVC";

                if (esNuevo)
                {
                    usuario.fechaRegistro = DateTime.Now;
                    usuario.estado = 1;
                    usuario.idPersonal = Convert.ToInt32(cbxCedulaIdentidad.SelectedValue);
                    //usuario.idPersonal = 2;
                    cbxCedulaIdentidad.Enabled = true;
                    UsuarioCln.insertar(usuario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    usuario.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    UsuarioCln.actualizar(usuario);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Usuario guardado exitosamente", "::: Psiquiatrico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1000, 562);
            cbxCedulaIdentidad.Enabled = true;  // Melby modificacion
            txtUsuario.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1000, 562);

            cbxCedulaIdentidad.Enabled = false; // Ultima de ultimas

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var usuario = UsuarioCln.get(id);
            txtUsuario.Text = usuario.usuario1;
            txtClave.Text = usuario.clave;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1000, 367);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private void limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string usuario = dgvLista.Rows[index].Cells["usuario"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"Esta seguro que desea eliminar el Usuario {usuario}?",
                "::: Psiquiatrico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                UsuarioCln.eliminar(id, "FVC");
                listar();
                MessageBox.Show("Usuario eliminado correctamente", "::: Psiquiatrico - Mensaje :::",
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
