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
using TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Implementaciones;
using TUP_PI_Parcial2_Telefonos.Servicios;

//CURSO: – LEGAJO: – APELLIDO: – NOMBRE:

namespace TUP_PI_Parcial2_Telefonos
{
    public partial class frmTelefono : Form
    {
        private GestorTelefono gestor;
        private Telefono oTelefono;
        
        public frmTelefono()
        {
            InitializeComponent();
            gestor = new GestorTelefono(new DAOFactory());
            oTelefono = new Telefono();
            

        }

        private void frmTelefono_Load(object sender, EventArgs e)
        {
            cargaCombo();
            cargarTelefonos();
            gbDatos.Enabled = false;
        }

        private void cargaCombo()
        {


            try
            {
                DataTable table = new DataTable();
                table = gestor.CargarComboTelefonos();
               
                cboMarca.DataSource = table;
                cboMarca.DisplayMember = "nombreMarca";
                cboMarca.ValueMember = "idMarca";
                //cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;

              
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void cargarTelefonos()
        {
            try
            {
                DataTable tabla = new DataTable();

                tabla = gestor.CargarListaTelefonos();
                
                dgvTelefonos.DataSource = tabla;
              
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cboMarca.SelectedIndex = 0;
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            oTelefono.pCodigo = Convert.ToInt32(txtCodigo.Text);
            oTelefono.pNombre = txtNombre.Text;
            oTelefono.pPrecio = Convert.ToDouble(txtPrecio.Text);
            oTelefono.pMarca = cboMarca.SelectedIndex + 1;
            try
            {
                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "") {
                    MessageBox.Show("Olvidó ingresar un campo!");
                    return;
                }
                if (cboMarca.SelectedIndex < 0)
                {
                    MessageBox.Show("Olvidó seleccionar una marca!");
                    return;
                }

                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    double precio = Convert.ToDouble(txtPrecio.Text);

                }
                catch (Exception) {
                    MessageBox.Show("Código y precio deben ser numéricos!");
                    return;
                }

                

                if (gestor.NuevoTelefono(oTelefono))
                {
                    MessageBox.Show("Telefono cargado con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    cargarTelefonos();
                    habilitarCampos(false);
                }
                else 
                {
                    MessageBox.Show("Error al cargar el telefono!");
                }            
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el teléfono");
                MessageBox.Show(ex.Message);
            }
        }

        private void habilitarCampos(bool value)
        {
            btnNuevo.Enabled = !value;
            dgvTelefonos.Enabled = !value;
            btnGuardar.Enabled = value;
            gbDatos.Enabled = value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult valor = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valor == DialogResult.Yes)
                this.Dispose();
        }
    }
}
