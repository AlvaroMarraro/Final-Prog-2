using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using RecetasSLN.Servicios.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class Frm_Consulta : Form
    {

        private IService servicio;
        public Frm_Consulta()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResultados.CurrentRow; // fila actual o seleccionada
            if (row != null)
            {
                int receta = Int32.Parse(row.Cells["colNro"].Value.ToString());
                if (MessageBox.Show("Seguro que desea eliminar el presupuesto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = servicio.RegistrarBajaReceta(receta);

                    if (respuesta)
                    {
                        MessageBox.Show("Presupuesto eliminado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(null, null);
                    }
                    else
                        MessageBox.Show("Error al intentar borrar el presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResultados.CurrentCell.ColumnIndex == 6)
            {
                int nroPresupuesto = Convert.ToInt32(dgvResultados.CurrentRow.Cells["colNro"].Value.ToString());
                Frm_Alta frm = new Frm_Alta();
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();
            Parametro fecha_desde = new Parametro();
            fecha_desde.Nombre = "@fecha_desde";
            fecha_desde.Valor = dtpDesde.Value;
            filtros.Add(fecha_desde);
            filtros.Add(new Parametro("@fecha_hasta", dtpHasta.Value));

            object val = DBNull.Value;
            if (!String.IsNullOrEmpty(txtCliente.Text))
                val = txtCliente.Text;
            filtros.Add(new Parametro("@cliente", val));

            string conBaja = "N";
            if (ckbBaja.Checked)
                conBaja = "S";
            filtros.Add(new Parametro("@datos_baja", conBaja));
            List<Recetas> lst = servicio.ConsultarRecetas(filtros);

            dgvResultados.Rows.Clear();
            foreach (Recetas oRecetas in lst)
            {
                dgvResultados.Rows.Add(new object[]{
                                        oRecetas.RecetaNro,
                                        oRecetas.Fecha.ToString("dd/MM/yyyy"),
                                        oRecetas.Nombre,
                                        oRecetas.Cheff,
                                        oRecetas.TipoReceta,
                                        
                 }); ;
            }
        }
    }
}
