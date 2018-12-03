using CapaDatos.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsUsuario
    {
        public List<Usuario> ListaUsuario;
        public clsConexion oCN = new clsConexion();

        public bool insertarUsuario(Usuario oUsuario)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Insert into Usuario(NombreUsuario, Contrasena, Identificacion) values (@NombreUsuario, @Contrasena, @Identificacion)");
                oSQLC.Parameters.AddWithValue("@NombreUsuario", oUsuario.NombreUsuario);
                oSQLC.Parameters.AddWithValue("@Contrasena", oUsuario.Contrasena);
                oSQLC.Parameters.AddWithValue("@Identificacion", oUsuario.Identificacion);
                oSQLC.CommandType = CommandType.Text;

                return new clsConexion().Comands(oSQLC);
            }
            catch (Exception ex)
            {

                throw new Exception ("No se pudo insertar el usuario", ex);
            }
        }

        public DataTable consultarUsuario(string nombreUsuario, string Contrasena)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Select NombreUsuario, Contrasena From Usuario Where NombreUsuario = '" + nombreUsuario + "' And Contrasena = '" + Contrasena + "'");
                return new clsConexion().SelectData(oSQLC);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo consultar el usuario", ex);
            }
        }

        public bool eliminarUsuario(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("DELETE Usuario Where Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", Identificacion);

                return new clsConexion().Comands(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el cliente", ex);
            }
        }

   /*     public void ConsultarRolUsuario(Usuario objUsuario)
        {
            try
            {
                oCN.StringConexion();

                SqlCommand oSQLC = new SqlCommand("SELECT RO.DescripcionRol, US.NombreUsuario FROM Persona PE JOIN Rol RO ON RO.IdRol = PE.IdRol JOIN Usuario Us ON Us.Identificacion = PE.Identificacion Where RO.DescripcionRol = ro.DescripcionRol AND US.NombreUsuario = us.NombreUsuario");

                oSQLC.CommandType = CommandType.Text;

                oSQLC.Connection = oCN.StringConexion();
                oCN.OpenConnection();
                SqlDataReader oSQLDR = oSQLC.ExecuteReader();
                ListaUsuario = new List<Usuario>();
                while (oSQLDR.Read())
                {
                    objUsuario.DescripcionRol = oSQLDR.GetString(0);
                    objUsuario.NombreUsuario = oSQLDR.GetString(1);
                    ListaUsuario.Add(objUsuario);
                    break;
                }  
                oCN.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo consultar el rol del usuario", ex);
            }
        }*/
    }
}

