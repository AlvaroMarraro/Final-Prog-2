
namespace Py_Final030222.vistas
{
    partial class FrmConsultaDatosProyecto
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
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.txtNombreProy = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.txtSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbProyecto = new System.Windows.Forms.GroupBox();
            this.colProyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbProyecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Location = new System.Drawing.Point(153, 109);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(242, 32);
            this.lblNombreProyecto.TabIndex = 3;
            this.lblNombreProyecto.Text = "Nombre Proyecto:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(159, 169);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(176, 32);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(159, 237);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(149, 32);
            this.lblFechaFin.TabIndex = 7;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // txtNombreProy
            // 
            this.txtNombreProy.Enabled = false;
            this.txtNombreProy.Location = new System.Drawing.Point(419, 109);
            this.txtNombreProy.Name = "txtNombreProy";
            this.txtNombreProy.Size = new System.Drawing.Size(361, 38);
            this.txtNombreProy.TabIndex = 4;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Location = new System.Drawing.Point(419, 231);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(361, 38);
            this.txtFechaFin.TabIndex = 8;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(419, 169);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(361, 38);
            this.txtFechaInicio.TabIndex = 6;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProyId,
            this.colEmpleado,
            this.colRol,
            this.colHoras});
            this.dgvDetalles.Location = new System.Drawing.Point(56, 343);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 102;
            this.dgvDetalles.RowTemplate.Height = 40;
            this.dgvDetalles.Size = new System.Drawing.Size(1303, 286);
            this.dgvDetalles.TabIndex = 9;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(1208, 714);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(233, 50);
            this.txtSalir.TabIndex = 10;
            this.txtSalir.Text = "Salir";
            this.txtSalir.UseVisualStyleBackColor = true;
            this.txtSalir.Click += new System.EventHandler(this.txtSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(690, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "PROYECTO";
            // 
            // gbProyecto
            // 
            this.gbProyecto.Controls.Add(this.dgvDetalles);
            this.gbProyecto.Controls.Add(this.txtFechaInicio);
            this.gbProyecto.Controls.Add(this.txtFechaFin);
            this.gbProyecto.Controls.Add(this.txtNombreProy);
            this.gbProyecto.Controls.Add(this.lblFechaFin);
            this.gbProyecto.Controls.Add(this.lblFechaInicio);
            this.gbProyecto.Controls.Add(this.lblNombreProyecto);
            this.gbProyecto.Location = new System.Drawing.Point(83, 52);
            this.gbProyecto.Name = "gbProyecto";
            this.gbProyecto.Size = new System.Drawing.Size(1411, 645);
            this.gbProyecto.TabIndex = 1;
            this.gbProyecto.TabStop = false;
            this.gbProyecto.Text = "Proyecto";
            // 
            // colProyId
            // 
            this.colProyId.HeaderText = "";
            this.colProyId.MinimumWidth = 12;
            this.colProyId.Name = "colProyId";
            this.colProyId.ReadOnly = true;
            this.colProyId.Visible = false;
            this.colProyId.Width = 150;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.MinimumWidth = 12;
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            this.colEmpleado.Width = 350;
            // 
            // colRol
            // 
            this.colRol.HeaderText = "Rol";
            this.colRol.MinimumWidth = 12;
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            this.colRol.Width = 350;
            // 
            // colHoras
            // 
            this.colHoras.HeaderText = "Horas Semana";
            this.colHoras.MinimumWidth = 12;
            this.colHoras.Name = "colHoras";
            this.colHoras.ReadOnly = true;
            this.colHoras.Width = 350;
            // 
            // FrmConsultaDatosProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 804);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbProyecto);
            this.Controls.Add(this.txtSalir);
            this.Name = "FrmConsultaDatosProyecto";
            this.Text = "ConsultaDatosProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbProyecto.ResumeLayout(false);
            this.gbProyecto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.TextBox txtNombreProy;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button txtSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoras;
    }
}