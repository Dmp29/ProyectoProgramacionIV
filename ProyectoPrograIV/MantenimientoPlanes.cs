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
    public partial class MantenimientoPlanes : MetroFramework.Forms.MetroForm
    {
        public MantenimientoPlanes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMantBuscar.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                BuscarPlan();
                HabilitarControles(true);
                txtIdentificacion.ReadOnly = true;
                txtMantPago.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
            
        }

        public void BuscarPlan()
        {
            try
            {
                dgvPlanPago.DataSource = new Planes().ConsultarPlan(txtMantBuscar.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la información del plan de pago", ex);
            }
        }

        public bool ModificarPlan()
        {
            // Declaración de variables
            double Monto = 0;
            int Plazo = 0;
            double InteresAnual = 0;
            double Resultado = 0;
            double Cuota = 0;
            // Toma los valores de las cajas de texto y los asigna a las variables
            Monto = Convert.ToDouble(this.txtMantMontoFinanciado.Text);
            Plazo = Convert.ToInt32(this.txtMantPlazo.Text);
            InteresAnual = Convert.ToDouble(this.txtMantIntereses.Text);

            // Calcula el interés anual
            InteresAnual = InteresAnual / 100 / 12;
            Resultado = (1 - Math.Pow(1 + InteresAnual, Plazo * -1)) / InteresAnual;

            // Calcula monto de la cuota.
            Cuota = Monto / Resultado;

            try
            {
                Plan oPlan = new Plan();
                oPlan.Identificacion = txtIdentificacion.Text;
                oPlan.MontoFinanciado = Convert.ToDecimal(txtMantMontoFinanciado.Text);
                oPlan.Plazo = Convert.ToInt32(txtMantPlazo.Text);
                oPlan.Intereses = Convert.ToInt32(txtMantIntereses.Text);
                Convert.ToDecimal(Cuota);
                oPlan.Pago = Convert.ToDecimal(Cuota); 

                return new Planes().ModificarPlan(oPlan);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar la información del cliente", ex);
            }
        }

        public bool EliminarPlan()
        {
            try
            {
                return new Planes().EliminarPlan(txtIdentificacion.Text);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo eliminar la información del plan de pago", ex);
            }
        }

        public void BuscarPlanes()
        {
            try
            {
                dgvPlanPago.DataSource = new Planes().ConsultarPlan(txtMantBuscar.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la información del plan de pago", ex);
            }
        }

        private void limpiarControles()
        {
            txtIdentificacion.Text = "";
            txtMantMontoFinanciado.Text = "";
            txtMantPlazo.Text = "";
            txtMantIntereses.Text = "";
            txtMantPago.Text = "";
            DataTable dt = (DataTable)dgvPlanPago.DataSource;
            dt.Clear();
        }

        private void HabilitarControles(bool Habilitar)
        {
            txtIdentificacion.ReadOnly = !Habilitar;
            txtMantMontoFinanciado.ReadOnly = !Habilitar;
            txtMantPlazo.ReadOnly = !Habilitar;
            txtMantIntereses.ReadOnly = !Habilitar;
            txtMantPago.ReadOnly = !Habilitar;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea eliminar el plan de pago?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    EliminarPlan();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Registro eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el plan de pago", ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea modificar el plan de pago?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    ModificarPlan();
                    limpiarControles();
                    MetroMessageBox.Show(this, "Información modificada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar la información del plan de pago", ex);
            }
        }

        private void MantenimientoPlanes_Load(object sender, EventArgs e)
        {
            Validaciones();

            HabilitarControles(false);
        }

        public void Validaciones()
        {
            txtMantBuscar.MaxLength = 11;
            txtIdentificacion.MaxLength = 11;
            txtMantMontoFinanciado.MaxLength = 8;
            txtMantPlazo.MaxLength = 11;
            txtMantIntereses.MaxLength = 2;
            txtMantPago.MaxLength = 8;
        }

        private void dgvPlanPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdentificacion.Text = dgvPlanPago.CurrentRow.Cells["Identificacion"].Value.ToString();
            txtMantMontoFinanciado.Text = dgvPlanPago.CurrentRow.Cells["MontoFinanciado"].Value.ToString();
            txtMantPlazo.Text = dgvPlanPago.CurrentRow.Cells["Plazo"].Value.ToString();
            txtMantIntereses.Text = dgvPlanPago.CurrentRow.Cells["Intereses"].Value.ToString();
            txtMantPago.Text = dgvPlanPago.CurrentRow.Cells["Pago"].Value.ToString();
        }

        private void txtMantBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtMantMontoFinanciado_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtMantPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtMantIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtMantPago_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
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
    }
}
