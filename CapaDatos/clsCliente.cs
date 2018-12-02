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
    public class clsCliente
    {
        public DataTable getGenero()
        {
            return new clsConexion().SelectData(new SqlCommand("Select IdGenero, DescripcionGenero From Genero"));
        }

        public bool registrarCliente(Cliente oCliente)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Insert into Cliente(Identificacion, Nombre, Apellido1, Apellido2, IdGenero) values(@Identificacion,@Nombre,@Apellido1,@Apellido2,@IdGenero)");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", oCliente.Identificacion);
                oSQLC.Parameters.AddWithValue("@Nombre", oCliente.Nombre);
                oSQLC.Parameters.AddWithValue("@Apellido1", oCliente.Apellido1);
                oSQLC.Parameters.AddWithValue("@Apellido2", oCliente.Apellido2);
                oSQLC.Parameters.AddWithValue("@IdGenero", oCliente.IdGenero);

                return new clsConexion().Comands(oSQLC);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo insertar el cliente indicado", ex);
            }
        }

        public DataTable buscarCliente(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("SELECT Cl.Identificacion, Cl.Nombre, Cl.Apellido1, Cl.Apellido2, Ge.DescripcionGenero FROM Cliente Cl JOIN Genero Ge ON Cl.IdGenero = Ge.IdGenero where Cl.Identificacion = " + Identificacion);
                return new clsConexion().SelectData(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo consultar a la persona", ex);
            }
        }

        public bool modificarCliente(Cliente oCliente)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("UPDATE Cliente SET Nombre = @Nombre, Apellido1 = @Apellido1, Apellido2 = @Apellido2, IdGenero = @IdGenero WHERE Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", oCliente.Identificacion);
                oSQLC.Parameters.AddWithValue("@Nombre", oCliente.Nombre);
                oSQLC.Parameters.AddWithValue("@Apellido1", oCliente.Apellido1);
                oSQLC.Parameters.AddWithValue("@Apellido2", oCliente.Apellido2);
                oSQLC.Parameters.AddWithValue("@IdGenero", oCliente.IdGenero);

                return new clsConexion().Comands(oSQLC);
            }

            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el cliente", ex);
            }
        }

        public bool EliminarCliente(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("DELETE Cliente Where Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", Identificacion);

                return new clsConexion().Comands(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el cliente", ex);
            }
        }
    }
}
