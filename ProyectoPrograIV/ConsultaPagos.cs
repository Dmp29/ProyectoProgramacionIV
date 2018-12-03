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
using WCFProyectoPrograIV;

namespace ProyectoPrograIV
{
    public partial class ConsultaPagos : MetroFramework.Forms.MetroForm
    {
        public ConsultaPagos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Service1 Servicio = new Service1();
           // dgvCargarPago.DataSource = Servicio.mostrarPagos();

            if (txtBuscar.Text == "")
            {
                dgvCargarPago.DataSource = Servicio.mostrarPagos();
                MetroMessageBox.Show(this, "A continuación se reflejarán todos los pagos", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);
            }
            else
            {
                dgvCargarPago.DataSource = Servicio.mostrarPagosID(txtBuscar.Text);
                MetroMessageBox.Show(this, "Consulta realizada correctamente", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ConsultaPagos_Load(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 11;
        }
    }
}
