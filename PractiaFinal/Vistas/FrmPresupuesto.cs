using PractiaFinal.AccesoDatos;
using PractiaFinal.Entidades;
using PractiaFinal.Servicios;
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

namespace PractiaFinal.Vistas
{
    public partial class FrmPresupuesto : Form
    {
        public enum Accion
        {
            Create,
            Read,
            Update,
            Delete
        }
        private Accion modo;
        private Presupuesto oPresupuesto;
        private GestorPresupuesto gestor;
        public FrmPresupuesto(Accion modo, int nro)
        {
            InitializeComponent();
            oPresupuesto = new Presupuesto();
            gestor = new GestorPresupuesto(new DaoFactory());
            this.modo = modo;

            if (modo.Equals(Accion.Read)) 
            {
                Text = "Presupuesto";
                HabilitarConsulta();
                CargarPresupuesto(nro);
            }
            if (modo.Equals(Accion.Update))
            {
                Text = "Editar presupuesto";
                CargarPresupuesto(nro);

            }
            
           
        }

        private void FrmPresupuesto_Load(object sender, EventArgs e) 
        {
            CargarProductos();
            txtCantidad.Text = "1";
            if (modo.Equals(Accion.Create))
            {
                lblPresNro.Text += gestor.ProximoPresupuesto();
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtCliente.Text = "Consumidor Final";
                txtDesc.Text = "0"; 
            }

            CargarPropiedadesGrilla();
        }

        private void CargarProductos()
        {
            List<Producto> lst = gestor.ObtenerProductos();
            cboProductos.DataSource = lst;
            cboProductos.ValueMember = "IdProducto";
            cboProductos.DisplayMember = "NProducto";
        }

        private void CargarPropiedadesGrilla() {
            dgvDetalles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }

        private void HabilitarConsulta()
        {
            btnAceptar.Hide();
            txtCliente.Enabled = false;
            txtDescuento.Enabled = false;
            cboProductos.Enabled = false;
            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            dgvDetalles.Enabled = false;
        }

        private void CargarPresupuesto(int nroPresupuesto) 
        {
            oPresupuesto = gestor.CargarPresupuestoNro(nroPresupuesto);
            lblPresNro.Text += oPresupuesto.PresupuestoNro.ToString();
            txtFecha.Text = oPresupuesto.Fecha.ToString("dd/MM/yyyy");
            txtCliente.Text = oPresupuesto.Cliente;
            txtDesc.Text = oPresupuesto.Descuento.ToString();

            dgvDetalles.Rows.Clear();
            foreach (DetallePresupuesto item in oPresupuesto.Detalles)
            {
                dgvDetalles.Rows.Add(new object[] { item.Producto.IdProducto, item.Producto.NProducto, "$ " + item.Producto.Precio, item.Cantidad, "$ " + item.CalcularSubtotal()});      
            }
            CalcularTotales();
        }

        

        private void CalcularTotales()
        {
            txtSubTotal.Text = oPresupuesto.CalcularTotal().ToString();
            double desc = oPresupuesto.CalcularTotal() * Convert.ToDouble(txtDesc.Text) / 100;
            txtDescuento.Text = desc.ToString();
            txtTotal.Text = (oPresupuesto.CalcularTotal() - desc).ToString();
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProductos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColProd"].Value.ToString().Equals(cboProductos.Text))
                {
                    MessageBox.Show("Este producto ya se encuentra presupuestado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Producto oProducto = (Producto)cboProductos.SelectedItem;
            DetallePresupuesto detalle = new DetallePresupuesto();

            detalle.Producto = oProducto;
            detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);

            oPresupuesto.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { oProducto.IdProducto, oProducto.NProducto, "$ " + oProducto.Precio, detalle.Cantidad, "$ " + detalle.CalcularSubtotal() });

            CalcularTotales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

           
            CargarProductos();
            txtCantidad.Text = "1";
            if (modo.Equals(Accion.Create))
            {
                lblPresNro.Text += gestor.ProximoPresupuesto();
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtCliente.Text = "Consumidor Final";
                txtDesc.Text = "0";
            }

            CargarPropiedadesGrilla();

        }
    }
}
