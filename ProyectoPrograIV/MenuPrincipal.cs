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
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public Personas oPersona = new Personas();

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

    
        private void registroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPlanes Mantenimiento = new MantenimientoPlanes();
            Mantenimiento.Show();
            this.Close();
        }

        private void RegistrodePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPagos Registro = new RegistroPagos();
            Registro.Show();
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

        private void creaciónDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreacionCliente CreacCliente = new CreacionCliente();
            CreacCliente.Show();
            this.Close();
        }

        private void mantenimientoDeClientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MantenimientoClientes MantCliente = new MantenimientoClientes();
            MantCliente.Show();
            this.Close();
        }

        private void mantenimientoDeAsociadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoAsociados MantAsociados = new MantenimientoAsociados();
            MantAsociados.Show();
            this.Close();
        }

        private void registroDePagosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            RegistroPagos Registro = new RegistroPagos();
            Registro.Show();
            this.Close();
        }

        private void registroDePlanesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPlanesPago RegistroPlanesPago = new RegistroPlanesPago();
            RegistroPlanesPago.Show();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
