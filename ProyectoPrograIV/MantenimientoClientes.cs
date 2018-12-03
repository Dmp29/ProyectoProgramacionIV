using CapaDatos.Resources;
using CapaLógica;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    public partial class MantenimientoClientes : MetroFramework.Forms.MetroForm
    {
        public Clientes oCliente = new Clientes();

        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMantBuscar.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                BuscarClientes();
                cbxMantCGenero.Enabled = true;
                HabilitarControles(true);
                txtMantCIdentificacion.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
        }

        public bool ModificarCliente()
        {
            try
            {
                Cliente oCliente = new Cliente();
                oCliente.Identificacion = txtMantCIdentificacion.Text;
                oCliente.Nombre = txtMantCNombre.Text;
                oCliente.Apellido1 = txtMantCApellido1.Text;
                oCliente.Apellido2 = txtMantCApellido2.Text;
                oCliente.IdGenero = cbxMantCGenero.SelectedIndex + 1;

                return new Clientes().ModificarCliente(oCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar la información del cliente", ex);
            }
        }

        public bool EliminarCliente()
        {
            try
            {
                return new Clientes().EliminarCliente(txtMantCIdentificacion.Text);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo eliminar la información del cliente", ex);
            }
        }

        public void BuscarClientes()
        {
            try
            {
                dgvMantClientes.DataSource = new Clientes().ConsultarCliente(txtMantBuscar.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la información del cliente", ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea modificar la información del cliente?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    ModificarCliente();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Información modificada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar la información del cliente", ex);
            }

        }

        private void limpiarControles()
        {
            txtMantCIdentificacion.Text = "";
            txtMantCNombre.Text = "";
            txtMantCApellido1.Text = "";
            txtMantCApellido2.Text = "";
            cbxMantCGenero.SelectedValue = 0;
            DataTable dt = (DataTable)dgvMantClientes.DataSource;
            dt.Clear();

        }

        private void HabilitarControles(bool Habilitar)
        {
            txtMantCIdentificacion.ReadOnly = !Habilitar;
            txtMantCNombre.ReadOnly = !Habilitar;
            txtMantCApellido1.ReadOnly = !Habilitar;
            txtMantCApellido2.ReadOnly = !Habilitar;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea eliminar el registro del cliente?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    EliminarCliente();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Registro eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el registro del cliente", ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            Validaciones();

            cbxMantCGenero.DataSource = oCliente.obtenerGenero();
            cbxMantCGenero.DisplayMember = "DescripcionGenero";
            cbxMantCGenero.ValueMember = "IdGenero";

            HabilitarControles(false);
        }

        private void dgvMantClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMantCIdentificacion.Text = dgvMantClientes.CurrentRow.Cells["Identificacion"].Value.ToString();
            txtMantCNombre.Text = dgvMantClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtMantCApellido1.Text = dgvMantClientes.CurrentRow.Cells["Apellido1"].Value.ToString();
            txtMantCApellido2.Text = dgvMantClientes.CurrentRow.Cells["Apellido2"].Value.ToString();
            cbxMantCGenero.Text = dgvMantClientes.CurrentRow.Cells["Genero"].Value.ToString();

        }

        public void Validaciones()
        {
            txtMantBuscar.MaxLength = 11;
            txtMantCNombre.MaxLength = 29;
            txtMantCApellido1.MaxLength = 29;
            txtMantCApellido2.MaxLength = 29;
        }

        private void txtMantBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtMantCIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtMantCNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = false;
            }
        }

        private void txtMantCApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = false;
            }
        }

        private void txtMantCApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = false;
            }
        }

        private void cbxMantCGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
