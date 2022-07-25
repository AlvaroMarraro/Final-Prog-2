
using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using RecetasSLN.Servicios.Service;
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

namespace RecetasSLN
{
    public partial class Frm_Alta : Form
    {
        private IService servicio;
        Recetas oReceta = new Recetas();
        public Frm_Alta()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
            CargarCombo();
            ConsultarUltimaReceta();
            txtNombre.Text = "Ingrese Nombre Receta";
            txtCheff.Text = "Ingrese Nombre Cheff";
            
        }

        private void ConsultarUltimaReceta()
        {
            lblNro.Text = "Receta #: " + servicio.ObtenerProximaRecetaID();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto como detalle", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProducto.Focus();
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de Receta", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (txtCheff.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cheff", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCheff.Focus();
                return;
            }

            //pasar datos al objeto 
            oReceta.Nombre = txtNombre.Text;
            oReceta.Cheff = txtCheff.Text;
            oReceta.TipoReceta = Convert.ToInt32(cboTipo.SelectedValue);

            if (servicio.GrabarReceta(oReceta))
            {
                MessageBox.Show("Receta guardada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                
            }
            else
            {
                MessageBox.Show("Error al intentar grabar la Receta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();

            }
            else
            {
                return;
            }
        }

        private void Frm_Alta_Presupuesto_Load(object sender, EventArgs e)
        {
            CargarCombo();

        }

        private void CargarCombo()
        {
            List<Ingredientes> lst = servicio.ConsultarProducto();

            
            cboProducto.DataSource = lst;
            
            cboProducto.ValueMember = "IngredientesId";
            cboProducto.DisplayMember = "Nombre";
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ExisteProductoEnGrilla(cboProducto.Text))
            {
                MessageBox.Show("Producto ya agregado como detalle", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleRecetas item = new DetalleRecetas();

            Ingredientes oIngrediente = (Ingredientes)cboProducto.SelectedItem;
            item.Ingredientes = oIngrediente;
            item.Cantidad = (int)nudCantidad.Value;

            oReceta.AgregarDetalle(item);

            dgvDetalles.Rows.Add(new string[] { "", oIngrediente.Nombre, item.Cantidad.ToString() });

            ActualizarTotales();

        }
        private void ActualizarTotales()
        {
            lblTotalIngredientes.Text = "Total de ingredientes:" + dgvDetalles.Rows.Count;
        }

        private bool ExisteProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["ingrediente"].Value.Equals(text))
                    return true;
            }
            return false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtCheff.Text = string.Empty;
            cboTipo.Text = string.Empty;
            dgvDetalles.Rows.Clear();
            lblTotalIngredientes.Text = "Total de ingredientes:";
            ConsultarUltimaReceta();
        }
       



        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                oReceta.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                ActualizarTotales();
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
