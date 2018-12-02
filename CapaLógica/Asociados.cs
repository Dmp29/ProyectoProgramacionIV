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
    public class Asociados
    {
        public bool InsertarAsociado(Asociado oAsociado)
        {
            return new clsAsociado().InsertarAsociado(oAsociado);
        }

        public DataTable ConsultarAsociado(string Identificacion)
        {
            return new clsAsociado().BuscarAsociado(Identificacion);
        }

        public bool ModificarAsociado(Asociado oAsociado)
        {
            return new clsAsociado().ModificarAsociado(oAsociado);
        }

        public bool EliminarAsociado(string Identificacion)
        {
            return new clsAsociado().EliminarAsociado(Identificacion);
        }

        public DataTable ObtenerOperacion()
        {
            return new clsAsociado().getOperacion();
        }
    }
}
