using CapaDatos;
using CapaDatos.Resources;
using System;
using System.Collections.Generic;
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
    }
}
