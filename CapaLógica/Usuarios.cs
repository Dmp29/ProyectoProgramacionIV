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
    public class Usuarios
    {
        public bool insertarUsuario(Usuario oUsuario)
        {
            return new clsUsuario().insertarUsuario(oUsuario);
        }

        public DataTable consultarUsuario(string nombreUsuario, string Contrasena)
        {
            return new clsUsuario().consultarUsuario(nombreUsuario, Contrasena);
        }

        public bool eliminarUsuario(string Identificacion)
        {
            return new clsUsuario().eliminarUsuario(Identificacion);
        }

       /* public void consultarRolUsuario(Usuario objUsuario)
        {
            new clsUsuario().ConsultarRolUsuario(objUsuario);
        }*/

    }
}
