using CapaDatos;
using CapaDatos.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class Clientes
    {
        public DataTable obtenerGenero()
        {
            return new clsCliente().getGenero();
        }

        public bool InsertarCliente(Cliente oCliente)
        {
            return new clsCliente().registrarCliente(oCliente);
        }

        public DataTable ConsultarCliente(string Identificacion)
        {
            return new clsCliente().buscarCliente(Identificacion);
        }

        public bool ModificarCliente(Cliente oCliente)
        {
            return new clsCliente().modificarCliente(oCliente);
        }

        public bool EliminarCliente(string Identificacion)
        {
            return new clsCliente().EliminarCliente(Identificacion);
        }
    }
}
