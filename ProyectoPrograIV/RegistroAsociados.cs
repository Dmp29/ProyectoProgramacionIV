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
    public partial class RegistroAsociados : MetroFramework.Forms.MetroForm
    {
        public Asociados oAsociado = new Asociados();

        public RegistroAsociados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        private void btnRegistroA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreEmpresaA.Text) || string.IsNullOrEmpty(txtIdentificacionA.Text) || string.IsNullOrEmpty(txtDireccionA.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                insertarAsociado();
                MetroMessageBox.Show(this, "Asociado insertado correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);
                limpiarControles();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
        }

        private void RegistroAsociados_Load(object sender, EventArgs e)
        {
            Validaciones();

            cbxOperacionA.DataSource = oAsociado.ObtenerOperacion();
            cbxOperacionA.DisplayMember = "DescripcionOperacion";
            cbxOperacionA.ValueMember = "IdOperacion";
        }

        public bool insertarAsociado()
        {
            try
            {
                Asociado oAsociado = new Asociado();
                oAsociado.NombreEmpresa = txtNombreEmpresaA.Text;
                oAsociado.Identificacion = txtIdentificacionA.Text;
                oAsociado.Direccion = txtDireccionA.Text;
                oAsociado.IdOperacion = cbxOperacionA.SelectedIndex + 1;

                return new Asociados().InsertarAsociado(oAsociado);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo completar su inserción", ex);
            }
        }

        public void limpiarControles()
        {
            txtNombreEmpresaA.Text = String.Empty;
            txtIdentificacionA.Text = String.Empty;
            txtDireccionA.Text = String.Empty;
            cbxOperacionA.SelectedValue = 0;
        }

        public void Validaciones()
        {
            txtNombreEmpresaA.MaxLength = 30;
            txtIdentificacionA.MaxLength = 12;
            txtDireccionA.MaxLength = 300;
        }

        private void txtIdentificacionA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxOperacionA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
