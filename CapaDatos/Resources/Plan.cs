using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Resources
{
    public class Plan
    {
        public string Identificacion { get; set; }
        public decimal MontoFinanciado { get; set; }
        public int Plazo { get; set; }
        public int Intereses { get; set; }
        public decimal Pago { get; set; }
    }
}
