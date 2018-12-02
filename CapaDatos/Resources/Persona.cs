using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Resources
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NumTelefono { get; set; }
        public string Direccion { get; set; }
        public int IdGenero { get; set; }
        public int IdRol { get; set; }
    }
}
