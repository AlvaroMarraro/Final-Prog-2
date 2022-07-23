
using Py_Final030222.datos;
using Py_Final030222.Servicios;
using Py_Final140222.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Py_Final030222.vistas
{
    public partial class FrmConsultaMaestro : Form
    {
		private GestorProyecto gestor;
        private Proyecto oProyecto;

        public FrmConsultaMaestro()
        {
            InitializeComponent();
			gestor = new GestorProyecto(new DaoFactory());
            oProyecto = new Proyecto();
            
        }

        
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarProyectos();
            CalcularTotales();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

		private void CargarProyectos()
		{
			List<Proyecto> lst = gestor.CargarProyectos();

			dgvProyecto.Rows.Clear();
			CargarGrilla(lst);
		}

        private void CargarGrilla(List<Proyecto> lst)
        {
            foreach (Proyecto item in lst)
            {
                dgvProyecto.Rows.Add(new object[] { item.ProyectoId.ToString(), item.ProyectoId.ToString(), item.Nombre, item.fechaInicio.ToString("dd/MM/yyyy"), item.fechaFin.ToString("dd/MM/yyyy") });
            }
        }

        private void dgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

                if (dgvProyecto.CurrentCell.ColumnIndex == 6)
                {
                    oProyecto.QuitarDetalle(dgvProyecto.CurrentRow.Index);
                    dgvProyecto.Rows.Remove(dgvProyecto.CurrentRow);
                    CalcularTotales();
                }
                
           
        }

        private void CalcularTotales() 
        {
             txtTotalProy.Text = Convert.ToInt32(dgvProyecto.Rows.Count).ToString();
        }

        private void btnNuevaReceta_Click(object sender, EventArgs e)
        {


            if (dgvProyecto.CurrentRow != null)
            {
                int nroProyecto = int.Parse(dgvProyecto.CurrentRow.Cells[0].Value.ToString());
                FrmConsultaDatosProyecto ofrmConsulta = new FrmConsultaDatosProyecto(nroProyecto);
                ofrmConsulta.ShowDialog();
            }

            else 
            {
                MessageBox.Show("Seleccione un proyecto por favor!!");
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nroPresupuesto = int.Parse(dgvProyecto.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Desea finalizar este proyecto?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (gestor.BorrarProyecto(nroPresupuesto))
                {
                    MessageBox.Show("Proyecto Finalizado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProyecto.Rows.Clear();
                    CargarProyectos();
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo finalizar el Proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarProyectosFiltros();
        }

        private void CargarProyectosFiltros() 
        {
            List<Parametro> filtros = new List<Parametro>();
            filtros.Add(new Parametro("@fec_inicio", dtpDesde.Value));
            filtros.Add(new Parametro("@fec_fin", dtpHasta.Value));

            List<Proyecto> lst = gestor.CargarProyectoFiltros(filtros);

            dgvProyecto.Rows.Clear();
            CargarGrilla(lst);


        }
    }
}
