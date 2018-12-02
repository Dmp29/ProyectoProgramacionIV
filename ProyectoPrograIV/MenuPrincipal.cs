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
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void registroDeAsociadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroAsociados Registro = new RegistroAsociados();
            Registro.Show();
            this.Close();
        }

        private void registroDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPlanesPago Registro = new RegistroPlanesPago();
            Registro.Show();
            this.Close();
        }

        private void registroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPlanes Mantenimiento = new MantenimientoPlanes();
            Mantenimiento.Show();
            this.Close();
        }

        private void mantenimientoDeCatálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogos Mantenimiento = new MantenimientoCatalogos();
            Mantenimiento.Show();
            this.Close();
        }

        private void realizaciónDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizacionPagos Pagos = new RealizacionPagos();
            Pagos.Show();
            this.Close();
        }

        private void consultaDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPagos Consulta = new ConsultaPagos();
            Consulta.Show();
            this.Close();
        }

        private void creaciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionUsuarios Creacion = new CreacionUsuarios();
            Creacion.Show();
            this.Close();
        }

        private void creaciónDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionRoles Creacion = new CreacionRoles();
            Creacion.Show();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void mantenimientoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios MantCliente = new MantenimientoUsuarios();
            MantCliente.Show();
            this.Close();
        }

        private void creaciónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionCliente CreacCliente = new CreacionCliente();
            CreacCliente.Show();
            this.Close();
        }

        private void mantenimientoDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoClientes MantCliente = new MantenimientoClientes();
            MantCliente.Show();
            this.Close();
        }

        private void mantenimientoDeAsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoAsociados MantAsociados = new MantenimientoAsociados();
            MantAsociados.Show();
            this.Close();
        }
    }
}
