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
            listar();
            cargarPersonal();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                MessageBox.Show("usuario guardado exitosamente", "::: Psiquiatrico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
