using CapaDatos.Resources;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsPersona
    {

        clsConexion conexion = new clsConexion();

        public bool registrarPersona(Persona oPersona)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Insert into Persona(Identificacion, Nombre, Apellido1, Apellido2, NumTelefono, Direccion, IdGenero, IdRol) values(@Identificacion,@Nombre,@Apellido1,@Apellido2,@NumTelefono,@Direccion,@IdGenero,@IdRol)");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", oPersona.Identificacion);
                oSQLC.Parameters.AddWithValue("@Nombre", oPersona.Nombre);
                oSQLC.Parameters.AddWithValue("@Apellido1", oPersona.Apellido1);
                oSQLC.Parameters.AddWithValue("@Apellido2", oPersona.Apellido2);
                oSQLC.Parameters.AddWithValue("@NumTelefono", oPersona.NumTelefono);
                oSQLC.Parameters.AddWithValue("@Direccion", oPersona.Direccion);
                oSQLC.Parameters.AddWithValue("@IdGenero", oPersona.IdGenero);
                oSQLC.Parameters.AddWithValue("@IdRol", oPersona.IdRol);

                return new clsConexion().Comands(oSQLC);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo insertar la persona indicada", ex);
            }
        }

        public DataTable consultarPersona(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand ("SELECT Pe.Identificacion, Pe.Nombre, Pe.Apellido1, Pe.Apellido2, Pe.NumTelefono, Pe.Direccion, Ge.DescripcionGenero, Ro.DescripcionRol FROM Persona Pe JOIN Genero Ge ON Pe.IdGenero = Ge.IdGenero JOIN Rol Ro ON Pe.IdRol = Ro.IdRol where Pe.Identificacion =" + Identificacion);
                return new clsConexion().SelectData(oSQLC);
                
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo consultar a la persona", ex);
            }
        }

        public bool modificarPersona(Persona oPersona)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("UPDATE Persona SET Nombre = @Nombre, Apellido1 = @Apellido1, Apellido2 = @Apellido2, NumTelefono = @NumTelefono, Direccion = @Direccion, IdGenero = @IdGenero, IdRol = @IdRol  WHERE Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", oPersona.Identificacion);
                oSQLC.Parameters.AddWithValue("@Nombre", oPersona.Nombre);
                oSQLC.Parameters.AddWithValue("@Apellido1", oPersona.Apellido1);
                oSQLC.Parameters.AddWithValue("@Apellido2", oPersona.Apellido2);
                oSQLC.Parameters.AddWithValue("@NumTelefono", oPersona.NumTelefono);
                oSQLC.Parameters.AddWithValue("@Direccion", oPersona.Direccion);
                oSQLC.Parameters.AddWithValue("@IdGenero", oPersona.IdGenero);
                oSQLC.Parameters.AddWithValue("@IdRol", oPersona.IdRol);

                return new clsConexion().Comands(oSQLC);
            }

            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el cliente", ex);
            }
        }

        public bool EliminarPersona(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("DELETE Persona Where Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", Identificacion);

                return new clsConexion().Comands(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el cliente", ex);
            }
        }

        public DataTable getRol()
        {
            return new clsConexion().SelectData(new SqlCommand("Select IdRol, DescripcionRol From Rol"));
        }

        public DataTable getGenero()
        {
            return new clsConexion().SelectData(new SqlCommand("Select IdGenero, DescripcionGenero From Genero"));
        }
    }
}
