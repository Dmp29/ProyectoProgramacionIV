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
    public partial class MantenimientoUsuarios : MetroFramework.Forms.MetroForm
    {
        public Personas oPersona = new Personas();

        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            Validaciones();

            cbxMantGenero.DataSource = oPersona.obtenerGenero();
            cbxMantGenero.DisplayMember = "DescripcionGenero";
            cbxMantGenero.ValueMember = "IdGenero";

            cbxMantRol.DataSource = oPersona.obtenerRol();
            cbxMantRol.DisplayMember = "DescripcionRol";
            cbxMantRol.ValueMember = "IdRol";

            HabilitarControles(false);
        }

        public bool ModificarUsuario()
        {
            try
            {
                Persona oPersona = new Persona();
                oPersona.Identificacion = txtMantCIdentificacion.Text;
                oPersona.Nombre = txtMantNombre.Text;
                oPersona.Apellido1 = txtMantApellido1.Text;
                oPersona.Apellido2 = txtMantApellido2.Text;
                oPersona.NumTelefono = txtMantTelefono.Text;
                oPersona.Direccion = txtMantDireccion.Text;
                oPersona.IdGenero = cbxMantGenero.SelectedIndex + 1;
                oPersona.IdRol = cbxMantRol.SelectedIndex + 1;

                return new Personas().ModificarPersona(oPersona);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar la información del usuario", ex);
            }
        }

        public bool EliminarUsuarioPersona()
        {
            try
            {
                return new Personas().EliminarPersona(txtMantCIdentificacion.Text);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo eliminar la información del usuario", ex);
            }
        }

        public void ConsultarUsuarios()
        {
            try
            {
                dgvMantUsuarios.DataSource = new Personas().ConsultarPersona(txtMantBuscar.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la información del usuario", ex);
            }
        }

        public bool EliminarUsuario()
        {
            try
            {
                return new Usuarios().eliminarUsuario(txtMantCIdentificacion.Text);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo eliminar la información del usuario", ex);
            }
        }

        private void HabilitarControles(bool Habilitar)
        {
            txtMantCIdentificacion.ReadOnly = !Habilitar;
            txtMantNombre.ReadOnly = !Habilitar;
            txtMantApellido1.ReadOnly = !Habilitar;
            txtMantApellido2.ReadOnly = !Habilitar;
            txtMantTelefono.ReadOnly = !Habilitar;
            txtMantDireccion.ReadOnly = !Habilitar;

        }

        private void limpiarControles()
        {
            txtMantCIdentificacion.Text = "";
            txtMantNombre.Text = "";
            txtMantApellido1.Text = "";
            txtMantApellido2.Text = "";
            txtMantTelefono.Text = "";
            txtMantDireccion.Text = "";
            cbxMantGenero.SelectedValue = 0;
            cbxMantRol.SelectedValue = 0;
            DataTable dt = (DataTable)dgvMantUsuarios.DataSource;
            dt.Clear();

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();
            cbxMantRol.Enabled = true;
            HabilitarControles(true);
            txtMantCIdentificacion.ReadOnly = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea modificar la información del usuario?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    ModificarUsuario();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Información modificada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar la información del usuario", ex);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea eliminar el registro del usuario?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    EliminarUsuarioPersona();
                    EliminarUsuario();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Registro eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el registro del usuario", ex);
            }
        }

        private void dgvMantUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMantCIdentificacion.Text = dgvMantUsuarios.CurrentRow.Cells["Identificacion"].Value.ToString();
            txtMantNombre.Text = dgvMantUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtMantApellido1.Text = dgvMantUsuarios.CurrentRow.Cells["Apellido1"].Value.ToString();
            txtMantApellido2.Text = dgvMantUsuarios.CurrentRow.Cells["Apellido2"].Value.ToString();
            txtMantTelefono.Text = dgvMantUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            txtMantDireccion.Text = dgvMantUsuarios.CurrentRow.Cells["Direccion"].Value.ToString();
            cbxMantGenero.Text = dgvMantUsuarios.CurrentRow.Cells["Genero"].Value.ToString();
            cbxMantRol.Text = dgvMantUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        public void Validaciones()
        {
            txtMantBuscar.MaxLength = 12;
            txtMantNombre.MaxLength = 30;
            txtMantApellido1.MaxLength = 30;
            txtMantApellido2.MaxLength = 30;
            txtMantTelefono.MaxLength = 8;
            txtMantDireccion.MaxLength = 300;
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

        private void txtMantNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantApellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantApellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxMantGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxMantRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }     
}
