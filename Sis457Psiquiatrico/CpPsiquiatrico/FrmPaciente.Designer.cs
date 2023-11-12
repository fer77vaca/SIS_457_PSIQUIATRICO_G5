namespace CpPsiquiatrico
{
    partial class FrmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxLista.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(7, 27);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(962, 121);
            this.dgvLista.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(855, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(40, 45);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(250, 20);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "Buscar por nombre del Paciente";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(44, 68);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(787, 27);
            this.txtParametro.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(418, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 42);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Pacientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(12, 111);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(976, 162);
            this.gbxLista.TabIndex = 9;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Pacientes";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(109, 279);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(772, 41);
            this.pnlAcciones.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(512, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(77, 32);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(394, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(280, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 32);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(171, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 32);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.textBox1);
            this.gbxDatos.Controls.Add(this.lblTratamiento);
            this.gbxDatos.Controls.Add(this.txtHorario);
            this.gbxDatos.Controls.Add(this.txtEspecialidad);
            this.gbxDatos.Controls.Add(this.txtCedula);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblHistorial);
            this.gbxDatos.Controls.Add(this.lblTelefono);
            this.gbxDatos.Controls.Add(this.lblCedula);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Location = new System.Drawing.Point(12, 332);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(976, 220);
            this.gbxDatos.TabIndex = 11;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Paciente";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(140, 137);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(264, 27);
            this.txtHorario.TabIndex = 27;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(140, 101);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(264, 27);
            this.txtEspecialidad.TabIndex = 26;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(140, 65);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(264, 27);
            this.txtCedula.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 27);
            this.txtNombre.TabIndex = 24;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(6, 137);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(77, 20);
            this.lblHistorial.TabIndex = 23;
            this.lblHistorial.Text = "Historial:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 101);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 20);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(6, 65);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 20);
            this.lblCedula.TabIndex = 21;
            this.lblCedula.Text = "C.I. :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 27);
            this.textBox1.TabIndex = 29;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(6, 170);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(103, 20);
            this.lblTratamiento.TabIndex = 28;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(883, 182);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 32);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(786, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 32);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1000, 564);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxLista.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}