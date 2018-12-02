using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Resources;

namespace CapaLógica
{
    public class Personas
    {
        public bool InsertarPersona(Persona oPersona)
        {
            return new clsPersona().registrarPersona(oPersona);
        }

        public DataTable ConsultarPersona(string Identificacion)
        {
            return new clsPersona().consultarPersona(Identificacion);
        }

        public bool ModificarPersona(Persona oPersona)
        {
            return new clsPersona().modificarPersona(oPersona);
        }

        public bool EliminarPersona(string Identificacion)
        {
            return new clsPersona().EliminarPersona(Identificacion);
        }

        public DataTable obtenerRol()
        {
            return new clsPersona().getRol();
        }

        public DataTable obtenerGenero()
        {
            return new clsPersona().getGenero();
        }
    }
}
