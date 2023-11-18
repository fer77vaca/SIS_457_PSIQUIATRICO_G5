namespace CpPsiquiatrico
{
    partial class FrmMenu
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
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnUsusario = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.pnlAcciones.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnUsusario);
            this.pnlAcciones.Controls.Add(this.btnCatalogo);
            this.pnlAcciones.Controls.Add(this.btnPaciente);
            this.pnlAcciones.Controls.Add(this.btnCita);
            this.pnlAcciones.Controls.Add(this.btnPersonal);
            this.pnlAcciones.Controls.Add(this.pnlLogo);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(160, 573);
            this.pnlAcciones.TabIndex = 0;
            // 
            // btnUsusario
            // 
            this.btnUsusario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsusario.Image = global::CpPsiquiatrico.Properties.Resources.icons8_visible_30;
            this.btnUsusario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsusario.Location = new System.Drawing.Point(0, 320);
            this.btnUsusario.Name = "btnUsusario";
            this.btnUsusario.Size = new System.Drawing.Size(160, 49);
            this.btnUsusario.TabIndex = 5;
            this.btnUsusario.Text = "Usuario";
            this.btnUsusario.UseVisualStyleBackColor = true;
            this.btnUsusario.Click += new System.EventHandler(this.btnUsusario_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogo.Image = global::CpPsiquiatrico.Properties.Resources.icons8_menú_30;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 271);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(160, 49);
            this.btnCatalogo.TabIndex = 4;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.Image = global::CpPsiquiatrico.Properties.Resources.icons8_venda_triangular_301;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 222);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(160, 49);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnCita
            // 
            this.btnCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCita.Image = global::CpPsiquiatrico.Properties.Resources.icons8_registro_301;
            this.btnCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.Location = new System.Drawing.Point(0, 173);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(160, 49);
            this.btnCita.TabIndex = 2;
            this.btnCita.Text = "Cita";
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.Image = global::CpPsiquiatrico.Properties.Resources.icons8_doctor_301;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 124);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(160, 49);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(160, 124);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpPsiquiatrico.Properties.Resources.A22;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.IndianRed;
            this.pnlControl.Controls.Add(this.pbxCerrar);
            this.pnlControl.Controls.Add(this.pbxMinimizar);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(160, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1016, 46);
            this.pnlControl.TabIndex = 1;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::CpPsiquiatrico.Properties.Resources.icons8_cerrar_ventana_30;
            this.pbxCerrar.Location = new System.Drawing.Point(969, 9);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(35, 34);
            this.pbxCerrar.TabIndex = 1;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Image = global::CpPsiquiatrico.Properties.Resources.icons8_minimizar_30;
            this.pbxMinimizar.Location = new System.Drawing.Point(928, 9);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(35, 34);
            this.pbxMinimizar.TabIndex = 0;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(964, 497);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(200, 67);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(166, 497);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(134, 39);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "FECHA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.Image = global::CpPsiquiatrico.Properties.Resources.c11eaa946097fceb09c32506e83ddc4c;
            this.pbxImagen.Location = new System.Drawing.Point(160, 43);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(1016, 451);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1176, 573);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlAcciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.pnlAcciones.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUsusario;
    }
}