namespace CpPsiquiatrico
{
    partial class FrmCita
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
            this.components = new System.ComponentModel.Container();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cbxPaciente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudPago = new System.Windows.Forms.NumericUpDown();
            this.lblPago = new System.Windows.Forms.Label();
            this.dtpFechaResrvacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReservacion = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.erpMotivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFechaResrvacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPago = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.gbxLista.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaResrvacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(7, 27);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(947, 134);
            this.dgvLista.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(842, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 32);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(27, 45);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(227, 20);
            this.lblBusqueda.TabIndex = 13;
            this.lblBusqueda.Text = "Buscar por motivo de la Cita:";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(31, 68);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(787, 27);
            this.txtParametro.TabIndex = 12;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(405, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 42);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Cita";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(224, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(110, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 32);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 32);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(18, 301);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(333, 41);
            this.pnlAcciones.TabIndex = 15;
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(12, 121);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(961, 174);
            this.gbxLista.TabIndex = 16;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista Citas";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblPaciente);
            this.gbxDatos.Controls.Add(this.cbxPaciente);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.nudPago);
            this.gbxDatos.Controls.Add(this.lblPago);
            this.gbxDatos.Controls.Add(this.dtpFechaResrvacion);
            this.gbxDatos.Controls.Add(this.lblFechaReservacion);
            this.gbxDatos.Controls.Add(this.txtMotivo);
            this.gbxDatos.Controls.Add(this.lblMotivo);
            this.gbxDatos.Location = new System.Drawing.Point(19, 369);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(954, 183);
            this.gbxDatos.TabIndex = 17;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de la Cita";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(589, 42);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(79, 20);
            this.lblPaciente.TabIndex = 45;
            this.lblPaciente.Text = "Paciente:";
            // 
            // cbxPaciente
            // 
            this.cbxPaciente.FormattingEnabled = true;
            this.cbxPaciente.Location = new System.Drawing.Point(678, 39);
            this.cbxPaciente.Name = "cbxPaciente";
            this.cbxPaciente.Size = new System.Drawing.Size(222, 28);
            this.cbxPaciente.TabIndex = 44;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(860, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 32);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(763, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 32);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudPago
            // 
            this.nudPago.Location = new System.Drawing.Point(193, 123);
            this.nudPago.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPago.Name = "nudPago";
            this.nudPago.Size = new System.Drawing.Size(120, 27);
            this.nudPago.TabIndex = 41;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(11, 125);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(52, 20);
            this.lblPago.TabIndex = 40;
            this.lblPago.Text = "Pago:";
            // 
            // dtpFechaResrvacion
            // 
            this.dtpFechaResrvacion.Location = new System.Drawing.Point(193, 78);
            this.dtpFechaResrvacion.Name = "dtpFechaResrvacion";
            this.dtpFechaResrvacion.Size = new System.Drawing.Size(301, 27);
            this.dtpFechaResrvacion.TabIndex = 39;
            // 
            // lblFechaReservacion
            // 
            this.lblFechaReservacion.AutoSize = true;
            this.lblFechaReservacion.Location = new System.Drawing.Point(8, 83);
            this.lblFechaReservacion.Name = "lblFechaReservacion";
            this.lblFechaReservacion.Size = new System.Drawing.Size(158, 20);
            this.lblFechaReservacion.TabIndex = 38;
            this.lblFechaReservacion.Text = "Fecha Reservacion:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(193, 35);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(301, 27);
            this.txtMotivo.TabIndex = 37;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(7, 38);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(63, 20);
            this.lblMotivo.TabIndex = 36;
            this.lblMotivo.Text = "Motivo:";
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::CpPsiquiatrico.Properties.Resources.icons8_cerrar_ventana_30;
            this.pbxCerrar.Location = new System.Drawing.Point(123, 3);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(35, 34);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Image = global::CpPsiquiatrico.Properties.Resources.icons8_minimizar_30;
            this.pbxMinimizar.Location = new System.Drawing.Point(82, 3);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(35, 34);
            this.pbxMinimizar.TabIndex = 0;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.IndianRed;
            this.pnlControl.Controls.Add(this.pbxCerrar);
            this.pnlControl.Controls.Add(this.pbxMinimizar);
            this.pnlControl.Location = new System.Drawing.Point(842, -3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(158, 41);
            this.pnlControl.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(830, 309);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(143, 33);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver a Menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // erpMotivo
            // 
            this.erpMotivo.ContainerControl = this;
            // 
            // erpFechaResrvacion
            // 
            this.erpFechaResrvacion.ContainerControl = this;
            // 
            // erpPago
            // 
            this.erpPago.ContainerControl = this;
            // 
            // erpPaciente
            // 
            this.erpPaciente.ContainerControl = this;
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1000, 353);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlAcciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCita";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaResrvacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.NumericUpDown nudPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.DateTimePicker dtpFechaResrvacion;
        private System.Windows.Forms.Label lblFechaReservacion;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cbxPaciente;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ErrorProvider erpMotivo;
        private System.Windows.Forms.ErrorProvider erpFechaResrvacion;
        private System.Windows.Forms.ErrorProvider erpPago;
        private System.Windows.Forms.ErrorProvider erpPaciente;
    }
}