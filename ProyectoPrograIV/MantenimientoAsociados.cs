﻿using CapaDatos.Resources;
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
    public partial class MantenimientoAsociados : MetroFramework.Forms.MetroForm
    {
        public Asociados oAsociado = new Asociados();

        public MantenimientoAsociados()
        {
            InitializeComponent();
        }

        private void MantenimientoAsociados_Load(object sender, EventArgs e)
        {
            Validaciones();
            cbxMantAOperacion.DataSource = oAsociado.ObtenerOperacion();
            cbxMantAOperacion.DisplayMember = "DescripcionOperacion";
            cbxMantAOperacion.ValueMember = "IdOperacion";

            HabilitarControles(false);
        }

        private void btnBuscarAsociado_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMantABuscar.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                BuscarAsociados();
                cbxMantAOperacion.Enabled = true;
                HabilitarControles(true);
                txtMantAIdentificacion.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
        }

        public bool ModificarAsociado()
        {
            try
            {
                Asociado oAsociado = new Asociado();
                oAsociado.Identificacion = txtMantAIdentificacion.Text;
                oAsociado.NombreEmpresa = txtMantANombreEmpresa.Text;
                oAsociado.Direccion = txtMantADireccion.Text;
                oAsociado.IdOperacion = cbxMantAOperacion.SelectedIndex + 1;

                return new Asociados().ModificarAsociado(oAsociado);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar la información del asociado", ex);
            }
        }

        public bool EliminarAsociado()
        {
            try
            {
                return new Asociados().EliminarAsociado(txtMantAIdentificacion.Text);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo eliminar la información del asociado", ex);
            }
        }

        public void BuscarAsociados()
        {
            try
            {
                dgvMantAsociados.DataSource = new Asociados().ConsultarAsociado(txtMantABuscar.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la información del asociado", ex);
            }
        }

        private void dgvMantAsociados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMantAIdentificacion.Text = dgvMantAsociados.CurrentRow.Cells["Identificacion"].Value.ToString();
            txtMantANombreEmpresa.Text = dgvMantAsociados.CurrentRow.Cells["NombreEmpresa"].Value.ToString();
            txtMantADireccion.Text = dgvMantAsociados.CurrentRow.Cells["Direccion"].Value.ToString();
            cbxMantAOperacion.Text = dgvMantAsociados.CurrentRow.Cells["Operacion"].Value.ToString();
        }

        private void btnModificarA_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea modificar la información del asociado?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    ModificarAsociado();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Información modificada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar la información del asociado", ex);
            }
        }

        private void limpiarControles()
        {
            txtMantAIdentificacion.Text = "";
            txtMantANombreEmpresa.Text = "";
            txtMantADireccion.Text = "";
            cbxMantAOperacion.SelectedValue = 0;
            DataTable dt = (DataTable)dgvMantAsociados.DataSource;
            dt.Clear();
        }

        private void HabilitarControles(bool Habilitar)
        {
            txtMantAIdentificacion.ReadOnly = !Habilitar;
            txtMantANombreEmpresa.ReadOnly = !Habilitar;
            txtMantADireccion.ReadOnly = !Habilitar;
        }

        private void btnEliminarA_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea eliminar el registro del asociado?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    EliminarAsociado();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Registro eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el registro del asociado", ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        public void Validaciones()
        {
            txtMantABuscar.MaxLength = 11;
            txtMantANombreEmpresa.MaxLength = 29;
            txtMantAIdentificacion.MaxLength = 11;
            txtMantADireccion.MaxLength = 299;
        }

        private void txtMantAIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMantABuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxMantAOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
