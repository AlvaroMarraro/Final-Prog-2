
namespace Py_Final030222.vistas
{
    partial class FrmConsultaMaestro
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevaReceta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalProy = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalProy);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblFin);
            this.groupBox2.Controls.Add(this.lblInicio);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.dgvProyecto);
            this.groupBox2.Location = new System.Drawing.Point(35, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1349, 568);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(876, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Consultar con fechas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(83, 136);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(149, 32);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fecha Fin:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(56, 71);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(176, 32);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Fecha inicio:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(269, 130);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(502, 38);
            this.dtpHasta.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(269, 66);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(502, 38);
            this.dtpDesde.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(876, 122);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(372, 46);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar Todos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(936, 488);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(256, 32);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total de proyectos:";
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.AllowUserToAddRows = false;
            this.dgvProyecto.AllowUserToDeleteRows = false;
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NroProyecto,
            this.NombreProyecto,
            this.FechaInicio,
            this.FechaFin,
            this.colAcciones});
            this.dgvProyecto.Location = new System.Drawing.Point(56, 192);
            this.dgvProyecto.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.ReadOnly = true;
            this.dgvProyecto.RowHeadersWidth = 102;
            this.dgvProyecto.Size = new System.Drawing.Size(1277, 279);
            this.dgvProyecto.TabIndex = 3;
            this.dgvProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyecto_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 250;
            // 
            // NroProyecto
            // 
            this.NroProyecto.HeaderText = "Proyecto Nro";
            this.NroProyecto.MinimumWidth = 12;
            this.NroProyecto.Name = "NroProyecto";
            this.NroProyecto.ReadOnly = true;
            this.NroProyecto.Width = 250;
            // 
            // NombreProyecto
            // 
            this.NombreProyecto.HeaderText = "Nombre Proyecto";
            this.NombreProyecto.MinimumWidth = 12;
            this.NombreProyecto.Name = "NombreProyecto";
            this.NombreProyecto.ReadOnly = true;
            this.NombreProyecto.Width = 350;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 12;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 250;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.MinimumWidth = 12;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 250;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.MinimumWidth = 12;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAcciones.Text = "Quitar";
            this.colAcciones.Width = 250;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1125, 644);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 55);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevaReceta
            // 
            this.btnNuevaReceta.Location = new System.Drawing.Point(35, 644);
            this.btnNuevaReceta.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNuevaReceta.Name = "btnNuevaReceta";
            this.btnNuevaReceta.Size = new System.Drawing.Size(253, 55);
            this.btnNuevaReceta.TabIndex = 5;
            this.btnNuevaReceta.Text = "Ver proyecto";
            this.btnNuevaReceta.UseVisualStyleBackColor = true;
            this.btnNuevaReceta.Click += new System.EventHandler(this.btnNuevaReceta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 644);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar proyecto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalProy
            // 
            this.txtTotalProy.Enabled = false;
            this.txtTotalProy.Location = new System.Drawing.Point(1233, 488);
            this.txtTotalProy.Name = "txtTotalProy";
            this.txtTotalProy.Size = new System.Drawing.Size(100, 38);
            this.txtTotalProy.TabIndex = 10;
            // 
            // FrmConsultaMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevaReceta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmConsultaMaestro";
            this.Text = "Consultar proyectos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProyecto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevaReceta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTotalProy;
    }
}