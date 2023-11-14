namespace CpPsiquiatrico
{
    partial class FrmPrincipal
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
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnReceta = new System.Windows.Forms.Button();
            this.btnMedicamento = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlAcciones.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.Gray;
            this.pnlAcciones.Controls.Add(this.btnReceta);
            this.pnlAcciones.Controls.Add(this.btnMedicamento);
            this.pnlAcciones.Controls.Add(this.btnCita);
            this.pnlAcciones.Controls.Add(this.btnPaciente);
            this.pnlAcciones.Controls.Add(this.btnPersonal);
            this.pnlAcciones.Controls.Add(this.pnlLogo);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(159, 643);
            this.pnlAcciones.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbxLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(159, 156);
            this.pnlLogo.TabIndex = 1;
            // 
            // btnReceta
            // 
            this.btnReceta.BackColor = System.Drawing.Color.Gray;
            this.btnReceta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceta.FlatAppearance.BorderSize = 0;
            this.btnReceta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReceta.Image = global::CpPsiquiatrico.Properties.Resources.icons8_receta_de_cerveza_30;
            this.btnReceta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceta.Location = new System.Drawing.Point(0, 380);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReceta.Size = new System.Drawing.Size(159, 56);
            this.btnReceta.TabIndex = 5;
            this.btnReceta.Text = "Receta";
            this.btnReceta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceta.UseVisualStyleBackColor = false;
            // 
            // btnMedicamento
            // 
            this.btnMedicamento.BackColor = System.Drawing.Color.Gray;
            this.btnMedicamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMedicamento.Image = global::CpPsiquiatrico.Properties.Resources.icons8_vacuna_30;
            this.btnMedicamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicamento.Location = new System.Drawing.Point(0, 324);
            this.btnMedicamento.Name = "btnMedicamento";
            this.btnMedicamento.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMedicamento.Size = new System.Drawing.Size(159, 56);
            this.btnMedicamento.TabIndex = 4;
            this.btnMedicamento.Text = "Medicamento";
            this.btnMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicamento.UseVisualStyleBackColor = false;
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.Gray;
            this.btnCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCita.Image = global::CpPsiquiatrico.Properties.Resources.icons8_registro_30;
            this.btnCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.Location = new System.Drawing.Point(0, 268);
            this.btnCita.Name = "btnCita";
            this.btnCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCita.Size = new System.Drawing.Size(159, 56);
            this.btnCita.TabIndex = 3;
            this.btnCita.Text = "Cita";
            this.btnCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCita.UseVisualStyleBackColor = false;
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.Gray;
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.Image = global::CpPsiquiatrico.Properties.Resources.icons8_venda_triangular_30;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 212);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPaciente.Size = new System.Drawing.Size(159, 56);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaciente.UseVisualStyleBackColor = false;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Gray;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.Image = global::CpPsiquiatrico.Properties.Resources.icons8_doctor_30;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 156);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPersonal.Size = new System.Drawing.Size(159, 56);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonal.UseVisualStyleBackColor = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::CpPsiquiatrico.Properties.Resources.A21;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(159, 156);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 643);
            this.Controls.Add(this.pnlAcciones);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.pnlAcciones.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnReceta;
        private System.Windows.Forms.Button btnMedicamento;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}