using CapaDatos.Resources;
using CapaLógica;
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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Usuario oUsuario = new Usuario();
        Persona oPersona = new Persona();

        public Login()
        {
            InitializeComponent();
        }

        void LimpiarControles()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            { 

                if (Convert.ToBoolean(new Usuarios().consultarUsuario(txtUsuario.Text.Trim(), txtContraseña.Text.Trim()).Rows.Count > 0 && txtUsuario.Text != "" && txtContraseña.Text != ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "!Bienvenido " + txtUsuario.Text + "!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    MenuPrincipal Menu = new MenuPrincipal();
                    Menu.Show();
                    this.Close();

                }
                else
                {
                    LimpiarControles();
                    this.DialogResult = DialogResult.None;
                    MetroFramework.MetroMessageBox.Show(this, "Usuario y contraseña invalidos, intentelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 9;

            txtContraseña.Text = "";

            txtContraseña.PasswordChar = '*';

            txtContraseña.MaxLength = 9;

        }
    }
}
