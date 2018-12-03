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
using System.Xml;
using System.Xml.Serialization;
using WCFProyectoPrograIV;

namespace ProyectoPrograIV
{
    public partial class RegistroPagos : MetroFramework.Forms.MetroForm
    {
        public RegistroPagos()
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
            OpenFileDialog Buscar = new OpenFileDialog();
            if (Buscar.ShowDialog() == DialogResult.OK)
            {
                txtXML.Text = Buscar.FileName;
            }
        }

    private void btnAplicarPago_Click(object sender, EventArgs e)
        {

            XmlSerializer Sr = new XmlSerializer(typeof(PagoLlenar));
            XmlTextReader Tx = new XmlTextReader(txtXML.Text);

            PagoLlenar oPago = (PagoLlenar)Sr.Deserialize(Tx);
            Service1 oServicio = new Service1();

            oServicio.insertarPago(oPago);
        }

        private void RegistroPagos_Load(object sender, EventArgs e)
        {
            txtXML.ReadOnly = true;
        }
    }
}
