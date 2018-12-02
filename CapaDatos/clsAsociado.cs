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
    public class clsAsociado
    {
        public bool InsertarAsociado(Asociado oAsociado)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Insert into Asociado(NombreEmpresa, Identificacion, Direccion, IdOperacion) values (@NombreEmpresa, @Identificacion, @Direccion, @IdOperacion)");
                oSQLC.Parameters.AddWithValue("@NombreEmpresa", oAsociado.NombreEmpresa);
                oSQLC.Parameters.AddWithValue("@Identificacion", oAsociado.Identificacion);
                oSQLC.Parameters.AddWithValue("@Direccion", oAsociado.Direccion);
                oSQLC.Parameters.AddWithValue("@IdOperacion", oAsociado.IdOperacion);
                oSQLC.CommandType = CommandType.Text;

                return new clsConexion().Comands(oSQLC);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo insertar el asociado", ex);
            }
        }

        public DataTable BuscarAsociado(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("SELECT Aso.NombreEmpresa, Aso.Identificacion, Aso.Direccion, Op.DescripcionOperacion FROM Asociado Aso JOIN Operacion Op ON Aso.IdOperacion = Op.IdOperacion where Aso.Identificacion = " + Identificacion);
                return new clsConexion().SelectData(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo consultar el asociado", ex);
            }
        }

        public bool ModificarAsociado(Asociado oAsociado)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("UPDATE Asociado SET NombreEmpresa = @NombreEmpresa, Identificacion = @Identificacion, Direccion = @Direccion, IdOperacion = @IdOperacion WHERE Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@NombreEmpresa", oAsociado.NombreEmpresa);
                oSQLC.Parameters.AddWithValue("@Identificacion", oAsociado.Identificacion);
                oSQLC.Parameters.AddWithValue("@Direccion", oAsociado.Direccion);
                oSQLC.Parameters.AddWithValue("@IdOperacion", oAsociado.IdOperacion);
                
                return new clsConexion().Comands(oSQLC);
            }

            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el asociado", ex);
            }
        }

        public bool EliminarAsociado(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("DELETE Asociado Where Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", Identificacion);

                return new clsConexion().Comands(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el asociado", ex);
            }
        }
        public DataTable getOperacion()
        {
            return new clsConexion().SelectData(new SqlCommand("Select IdOperacion, DescripcionOperacion From Operacion"));
        }
    }
}
