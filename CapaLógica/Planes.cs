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
    public class Planes
    {
        public bool InsertarPlan(Plan oPlan)
        {
            return new clsPlan().insertarPlan(oPlan);
        }

        public DataTable ConsultarPlan(string Identificacion)
        {
            return new clsPlan().buscarPlan(Identificacion);
        }

        public bool ModificarPlan(Plan oPlan)
        {
            return new clsPlan().modificarPlan(oPlan);
        }

        public bool EliminarPlan(string Identificacion)
        {
            return new clsPlan().EliminarPlan(Identificacion);
        }
    }
}
