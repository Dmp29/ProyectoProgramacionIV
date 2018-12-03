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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    public partial class RegistroPlanesPago : MetroFramework.Forms.MetroForm
    {

        public Planes oPlan = new Planes();

        public RegistroPlanesPago()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        private void btnRegistroPA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdentificacionPA.Text) || string.IsNullOrEmpty(txtIntereses.Text) || string.IsNullOrEmpty(txtMontoPA.Text) || string.IsNullOrEmpty(txtPlazoPA.Text))
                {
                    MetroMessageBox.Show(this, "Por favor, inserte los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    return;
                }
                TablaAmortizacion();
                insertarPlan();
                MetroMessageBox.Show(this, "Plan insertado correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);
                limpiarControles();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar su solicitud", ex);
            }
        }

        public bool insertarPlan()
        {
            try
            {
                Plan oPlan = new Plan();
                oPlan.Identificacion = txtIdentificacionPA.Text;
                oPlan.MontoFinanciado = Convert.ToDecimal(txtMontoPA.Text);
                oPlan.Plazo = Convert.ToInt32(txtPlazoPA.Text);
                oPlan.Intereses = Convert.ToInt32(txtIntereses.Text);
                oPlan.Pago = Convert.ToDecimal(txtPago.Text);

                return new Planes().InsertarPlan(oPlan);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo completar su inserción", ex);
            }
        }

        public void TablaAmortizacion()
        {
            // Declaración de variables
            double Monto = 0;
            int Plazo = 0;
            double InteresAnual = 0;
            double Resultado = 0;
            double Cuota = 0;
            double Interes = 0;
            double TotalInteres = 0;
            double Principal = 0;
            double TotalAmortizado = 0;
            double TotalCuota = 0;
            double CuotaInicial = 0;
            double Acumulado = 0;
            // Variables para validaciones
            Regex isnumber = new Regex(@"^-?[0-9]+(\.?[0-9]+)?$");
            // Toma los valores de las cajas de texto y los asigna a las variables
            Monto = Convert.ToDouble(this.txtMontoPA.Text);
            Plazo = Convert.ToInt32(this.txtPlazoPA.Text);
            InteresAnual = Convert.ToDouble(this.txtIntereses.Text);

            // Calcula el interés anual
            InteresAnual = InteresAnual / 100 / 12;
            Resultado = (1 - Math.Pow(1 + InteresAnual, Plazo * -1)) / InteresAnual;

            // Calcula monto de la cuota.
            Cuota = Monto / Resultado;
            txtPago.Text = Cuota.ToString("N2"); // Asigna el monto de la cuota a la caja de texto.

            double SaldoFinal = Monto;

            // Recorre el ciclo hasta que I sea menor al plazo + 1.
            for (int I = 1; I < Plazo + 1; I = I + 1)
            {

                Interes = Math.Round(SaldoFinal * InteresAnual, 2);// Calculo del interes.
                TotalInteres += Interes; // Se acumulan los intereses en cada iteración.
                Acumulado += Interes; // Se acumulan los intereses en cada iteración.
                CuotaInicial = SaldoFinal;
                Principal = Math.Round(Cuota - Interes, 2);// Calculo para determinar el Principal.
                TotalAmortizado += Principal; // Acumula el principal.
                SaldoFinal -= Principal;// Rebaja la cuota (el principal) en cada mes.
                TotalCuota += Cuota; // Acumula la cuota.
                // Insertar datos al DatagridView.
                dgvPlan.Rows.Add(I.ToString(), Cuota.ToString("N2"), Interes.ToString("N2"), Principal.ToString("N2"), SaldoFinal.ToString("N2"));
            }
        }

        public void limpiarControles()
        {
            txtIdentificacionPA.Text = String.Empty;
            txtIntereses.Text = String.Empty;
            txtMontoPA.Text = String.Empty;
            txtPlazoPA.Text = String.Empty;
        }

        public void Validaciones()
        {
            txtIdentificacionPA.MaxLength = 12;
            txtMontoPA.MaxLength =  9;
            txtPlazoPA.MaxLength = 2;
            txtIntereses.MaxLength = 12;
        }

        private void txtIdentificacionPA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMontoPA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlazoPA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIntereses_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RegistroPlanesPago_Load(object sender, EventArgs e)
        {
            txtPago.Enabled = false;
            dgvPlan.Enabled = true;
        }
    }
}
