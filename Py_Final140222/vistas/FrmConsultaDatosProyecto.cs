using Py_Final030222.datos;
using Py_Final030222.Servicios;
using Py_Final140222.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Py_Final030222.vistas
{
    public partial class FrmConsultaDatosProyecto : Form
    {
        private Proyecto oProyecto;
        private GestorProyecto gestor;
        public FrmConsultaDatosProyecto(int nro)
        {
            InitializeComponent();
            oProyecto = new Proyecto();
            gestor = new GestorProyecto(new DaoFactory());
            CargarProyecto(nro);



        }

        public void CargarProyecto(int nroProyecto) 
        {
            
            this.oProyecto = gestor.CargarProyectosPorNro(nroProyecto);
            txtNombreProy.Text = oProyecto.Nombre;
            txtFechaInicio.Text = oProyecto.fechaInicio.ToString("dd/MM/yyyy");
            txtFechaFin.Text = oProyecto.fechaFin.ToString("dd/MM/yyyy");

            

            dgvDetalles.Rows.Clear();


            foreach (DetalleRecurso oDetalle in oProyecto.Detalles)
            {
                dgvDetalles.Rows.Add(new object[] { oDetalle.Proyecto.ProyectoId, oDetalle.Empleado.Nombre + " - " + oDetalle.Empleado.Apellido, oDetalle.Rol, oDetalle.HrsSemana}); // + " - " + oDetalle.Empleado.Nombre
            }

                
        
        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
