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

        private void dgvMantClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Service1 Servicio = new Service1();
           // dgvCargarPago.DataSource = Servicio.mostrarPagos();

            if (txtBuscar.Text == "")
            {
                dgvCargarPago.DataSource = Servicio.mostrarPagos();

            }
            else
            {
                dgvCargarPago.DataSource = Servicio.mostrarPagosID(txtBuscar.Text);
            }
        }
    }
}
