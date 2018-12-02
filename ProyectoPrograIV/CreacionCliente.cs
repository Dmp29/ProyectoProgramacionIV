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
    public partial class CreacionCliente : MetroFramework.Forms.MetroForm
    {
        public Clientes oCliente = new Clientes();

        public CreacionCliente()
        {
            InitializeComponent();
        }

        private void CreacionCliente_Load(object sender, EventArgs e)
        {
            cbxCreacGene.DataSource = oCliente.obtenerGenero();
            cbxCreacGene.DisplayMember = "DescripcionGenero";
            cbxCreacGene.ValueMember = "IdGenero";
        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        public bool insertarCliente()
        {
            try
            {
                Cliente oCliente = new Cliente();
                oCliente.Identificacion = txtCreacIdentificacion.Text;
                oCliente.Nombre = txtCreacNombre.Text;
                oCliente.Apellido1 = txtCreacApe1.Text;
                oCliente.Apellido2 = txtCreacApe2.Text;
                oCliente.IdGenero = cbxCreacGene.SelectedIndex + 1;

                return new Clientes().InsertarCliente(oCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo completar su inserción", ex);
            }
        }

        public void limpiarControles()
        {
            txtCreacIdentificacion.Text = String.Empty;
            txtCreacNombre.Text = String.Empty;
            txtCreacApe1.Text = String.Empty;
            txtCreacApe2.Text = String.Empty;
            cbxCreacGene.SelectedValue = 0;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCreacIdentificacion.Text) || string.IsNullOrEmpty(txtCreacNombre.Text) || string.IsNullOrEmpty(txtCreacApe1.Text) || string.IsNullOrEmpty(txtCreacApe2.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                insertarCliente();
                MetroMessageBox.Show(this, "Cliente insertado correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);
                limpiarControles();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
        }
    }
}
