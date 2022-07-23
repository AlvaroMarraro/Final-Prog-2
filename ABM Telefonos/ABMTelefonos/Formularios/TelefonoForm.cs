using ABMTelefonos.Acceso_a_Datos.Implementaciones;
using ABMTelefonos.Entidades;
using ABMTelefonos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMTelefonos.Formularios
{
    public partial class TelefonoForm : Form
    {
        private GestorTelefono gestor;
        private Telefono oTelefono;
        public TelefonoForm()
        {
            InitializeComponent();
            gestor = new GestorTelefono(new DaoFactory());
            oTelefono = new Telefono();
        }

        private void TelefonoForm_Load(object sender, EventArgs e)
        {
            
            CargarCombo();
            CargarLista();
            HabilitarCampos(false);
            btnAceptar.Enabled = false;
        }

        private void CargarLista()
        {
            DataTable table = new DataTable();

            table = gestor.CargarListaTelefonos();

            lstTelefonos.DataSource = table;
            lstTelefonos.DisplayMember = "Lista";

           
        }

        private void CargarCombo()
        {
            DataTable table = new DataTable();

            table = gestor.CargarComboMarca();

            cboMarca.DataSource = table;
            cboMarca.DisplayMember = "nombreMarca";
            cboMarca.ValueMember = "idMarca";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            } 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);


        }

        private void HabilitarCampos(bool habilitar)
        {
            

            txtCodigo.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtPrecio.Enabled = habilitar;
            btnEditar.Visible = !habilitar;
            lstTelefonos.Enabled = !habilitar;
            cboMarca.Enabled = habilitar;
            btnNuevo.Enabled = !habilitar;
            btnSalir.Enabled = !habilitar;
            btnBorrar.Enabled = !habilitar;
            btnGrabar.Enabled = habilitar;
            btnAceptar.Visible = !habilitar;


        }

        public void ValidarCampos() 
        {
            if (txtCodigo.Text == null || txtNombre.Text == null || txtPrecio.Text == null)
            {
                MessageBox.Show("Cargue todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Cargue una marca por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            int codigo;
            double precio;

            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                precio = Convert.ToDouble(txtPrecio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un valor numerico!");
                return;
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            oTelefono.Codigo = Convert.ToInt32(txtCodigo.Text);
            oTelefono.Nombre = txtNombre.Text;
            oTelefono.Marca = Convert.ToInt32(cboMarca.SelectedValue);
            oTelefono.Precio = Convert.ToDouble(txtPrecio.Text);
            
            if (gestor.GrabarTelefono(oTelefono))
            {
                MessageBox.Show("Telefono Cargado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();

            }
            else 
            {
                MessageBox.Show("No se ha podido cargar el telefono");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro desea cancelar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LimpiarCampos();
                HabilitarCampos(false);
                btnNuevo.Visible = true;
            
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cboMarca.SelectedValue = 1;
        }

        private void lstTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstTelefonos.SelectedIndex != -1) 
            {
                CargarDatosTelefono();
            }
            

        }

        private void CargarDatosTelefono()
        {
            int pk = lstTelefonos.SelectedIndex+1;

            oTelefono = gestor.TraerTelefonoUnico(pk);

            txtCodigo.Text = Convert.ToInt32(oTelefono.Codigo).ToString();
            txtNombre.Text = oTelefono.Nombre;
            cboMarca.SelectedValue = oTelefono.Marca;
            txtPrecio.Text = Convert.ToDouble(oTelefono.Precio).ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            HabilitarCampos(true);
            btnEditar.Visible = true;
            btnEditar.Enabled = false;
            btnAceptar.Visible = true;
            btnAceptar.Enabled = true;
            btnBorrar.Enabled = false;
            btnGrabar.Enabled = false;
            txtCodigo.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ValidarCampos();
            oTelefono.Codigo = Convert.ToInt32(txtCodigo.Text);
            oTelefono.Nombre = txtNombre.Text;
            oTelefono.Marca = Convert.ToInt32(cboMarca.SelectedValue);
            oTelefono.Precio = Convert.ToDouble(txtPrecio.Text);

            if (gestor.ActualizarTelefono(oTelefono))
            {
                MessageBox.Show("Telefono actualizado exitosamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();

            }
            else 
            {
                MessageBox.Show("Error al actualizar el telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LimpiarCampos();
            CargarLista();
            HabilitarCampos(false);
            btnEditar.Enabled = true;
            btnAceptar.Enabled = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstTelefonos.SelectedIndex != -1) 
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el telefono?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    if (gestor.BorrarTelefono(oTelefono))
                    {
                        MessageBox.Show("Telefono Eliminado exitosamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarLista();

                    }
                    else 
                    {
                        MessageBox.Show("Error al elimnar el telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
                }
                

            
            }
        }
    }
}
