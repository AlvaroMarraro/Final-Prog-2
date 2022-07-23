
namespace PractiaFinal.Vistas
{
    partial class FrmConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFiltro1 = new System.Windows.Forms.Label();
            this.cboFiltrarFecha = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.chkBajas = new System.Windows.Forms.CheckBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.cNroPresup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltro1
            // 
            this.lblFiltro1.AutoSize = true;
            this.lblFiltro1.Location = new System.Drawing.Point(163, 32);
            this.lblFiltro1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFiltro1.Name = "lblFiltro1";
            this.lblFiltro1.Size = new System.Drawing.Size(79, 32);
            this.lblFiltro1.TabIndex = 31;
            this.lblFiltro1.Text = "Filtro";
            // 
            // cboFiltrarFecha
            // 
            this.cboFiltrarFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarFecha.FormattingEnabled = true;
            this.cboFiltrarFecha.Location = new System.Drawing.Point(258, 32);
            this.cboFiltrarFecha.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboFiltrarFecha.Name = "cboFiltrarFecha";
            this.cboFiltrarFecha.Size = new System.Drawing.Size(471, 39);
            this.cboFiltrarFecha.TabIndex = 30;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(601, 249);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(200, 62);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(385, 249);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 62);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // chkBajas
            // 
            this.chkBajas.AutoSize = true;
            this.chkBajas.Location = new System.Drawing.Point(888, 263);
            this.chkBajas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkBajas.Name = "chkBajas";
            this.chkBajas.Size = new System.Drawing.Size(205, 36);
            this.chkBajas.TabIndex = 27;
            this.chkBajas.Text = "Incluir bajas";
            this.chkBajas.UseVisualStyleBackColor = true;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(1331, 29);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(104, 32);
            this.lblFechaHasta.TabIndex = 26;
            this.lblFechaHasta.Text = "Hasta: ";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(822, 32);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(112, 32);
            this.lblFechaDesde.TabIndex = 25;
            this.lblFechaDesde.Text = "Desde: ";
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Location = new System.Drawing.Point(169, 249);
            this.btnNuevoP.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(200, 62);
            this.btnNuevoP.TabIndex = 24;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.UseVisualStyleBackColor = true;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(1464, 29);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(284, 38);
            this.dtpFechaHasta.TabIndex = 23;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(950, 29);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(284, 38);
            this.dtpFechaDesde.TabIndex = 22;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1548, 119);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 62);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(828, 132);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(639, 38);
            this.txtFiltro.TabIndex = 20;
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(258, 128);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(471, 39);
            this.cboFiltro.TabIndex = 19;
            // 
            // lblFiltro2
            // 
            this.lblFiltro2.AutoSize = true;
            this.lblFiltro2.Location = new System.Drawing.Point(163, 135);
            this.lblFiltro2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFiltro2.Name = "lblFiltro2";
            this.lblFiltro2.Size = new System.Drawing.Size(79, 32);
            this.lblFiltro2.TabIndex = 18;
            this.lblFiltro2.Text = "Filtro";
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.AllowUserToResizeRows = false;
            this.dgvConsultar.ColumnHeadersHeight = 30;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNroPresup,
            this.cFecha,
            this.cCliente,
            this.cDescuento,
            this.cTotal,
            this.cFechaBaja,
            this.cAccion});
            this.dgvConsultar.Location = new System.Drawing.Point(169, 341);
            this.dgvConsultar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvConsultar.MultiSelect = false;
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultar.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.RowHeadersWidth = 102;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(1579, 549);
            this.dgvConsultar.TabIndex = 17;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // cNroPresup
            // 
            this.cNroPresup.HeaderText = "Presupuesto";
            this.cNroPresup.MinimumWidth = 12;
            this.cNroPresup.Name = "cNroPresup";
            this.cNroPresup.ReadOnly = true;
            this.cNroPresup.Width = 85;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.MinimumWidth = 12;
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            this.cFecha.Width = 250;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "Cliente";
            this.cCliente.MinimumWidth = 12;
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            this.cCliente.Width = 250;
            // 
            // cDescuento
            // 
            this.cDescuento.HeaderText = "Descuento";
            this.cDescuento.MinimumWidth = 12;
            this.cDescuento.Name = "cDescuento";
            this.cDescuento.ReadOnly = true;
            this.cDescuento.Width = 80;
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.MinimumWidth = 12;
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            this.cTotal.Width = 250;
            // 
            // cFechaBaja
            // 
            this.cFechaBaja.HeaderText = "Fecha Baja";
            this.cFechaBaja.MinimumWidth = 12;
            this.cFechaBaja.Name = "cFechaBaja";
            this.cFechaBaja.ReadOnly = true;
            this.cFechaBaja.Width = 250;
            // 
            // cAccion
            // 
            this.cAccion.HeaderText = "Accion";
            this.cAccion.MinimumWidth = 12;
            this.cAccion.Name = "cAccion";
            this.cAccion.ReadOnly = true;
            this.cAccion.Text = "Ver";
            this.cAccion.UseColumnTextForButtonValue = true;
            this.cAccion.Width = 75;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Location = new System.Drawing.Point(169, 938);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(280, 55);
            this.btnEliminarFiltro.TabIndex = 33;
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1548, 934);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 62);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1099);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFiltro1);
            this.Controls.Add(this.cboFiltrarFecha);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.chkBajas);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.btnNuevoP);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.lblFiltro2);
            this.Controls.Add(this.dgvConsultar);
            this.Name = "FrmConsultar";
            this.Text = "FrmConusultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltro1;
        private System.Windows.Forms.ComboBox cboFiltrarFecha;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox chkBajas;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label lblFiltro2;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroPresup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaBaja;
        private System.Windows.Forms.DataGridViewButtonColumn cAccion;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.Button btnCancelar;
    }
}