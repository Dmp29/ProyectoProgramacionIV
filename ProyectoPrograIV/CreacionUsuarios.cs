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
    public partial class CreacionUsuarios : MetroFramework.Forms.MetroForm
    {
        public Personas oPersona = new Personas();

        public CreacionUsuarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        private void CreacionUsuarios_Load(object sender, EventArgs e)
        {
            cbxGenero.DataSource = oPersona.obtenerGenero();
            cbxGenero.DisplayMember = "DescripcionGenero";
            cbxGenero.ValueMember = "IdGenero";

            cbxRol.DataSource = oPersona.obtenerRol();
            cbxRol.DisplayMember = "DescripcionRol";
            cbxRol.ValueMember = "IdRol";

        }

        public bool Insertar()
        {
            try
            {
                Persona oPersona = new Persona();
                oPersona.Identificacion = txtIdentificacion.Text;
                oPersona.Nombre = txtNombre.Text;
                oPersona.Apellido1 = txtApellido1.Text;
                oPersona.Apellido2 = txtApellido2.Text;
                oPersona.NumTelefono = txtTelefono.Text;
                oPersona.Direccion = txtDireccion.Text;
                oPersona.IdGenero = cbxGenero.SelectedIndex + 1;
                oPersona.IdRol = cbxRol.SelectedIndex + 1;

                return new Personas().InsertarPersona(oPersona);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo completar su inserción", ex);
            }
        }

        public bool insertarUsuario()
        {
            try
            {
                Usuario oUsuario = new Usuario();
                oUsuario.NombreUsuario = txtNombreUsuario.Text;
                oUsuario.Contrasena = txtContraseña.Text;
                oUsuario.Identificacion = txtIdentificacion.Text;

                return new Usuarios().insertarUsuario(oUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo completar su inserción", ex);
            }
        }

        public void limpiarControles()
        {
            txtIdentificacion.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellido1.Text = String.Empty;
            txtApellido2.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            cbxGenero.SelectedValue = 0;
            cbxRol.SelectedValue = 0;
            txtNombreUsuario.Text = String.Empty;
            txtContraseña.Text = String.Empty;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido1.Text) || string.IsNullOrEmpty(txtApellido2.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                Insertar();
                insertarUsuario();
                MetroMessageBox.Show(this, "Usuario insertado correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);
                limpiarControles();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
        }
    }
}
