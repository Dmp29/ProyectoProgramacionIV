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
    public class clsPlan
    {
        public bool insertarPlan(Plan oPlan)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Insert into PlanP(Identificacion, MontoFinanciado, Plazo, Intereses, Pago) values(@Identificacion,@MontoFinanciado,@Plazo,@Intereses,@Pago)");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", oPlan.Identificacion);
                oSQLC.Parameters.AddWithValue("@MontoFinanciado", oPlan.MontoFinanciado);
                oSQLC.Parameters.AddWithValue("@Plazo", oPlan.Plazo);
                oSQLC.Parameters.AddWithValue("@Intereses", oPlan.Intereses);
                oSQLC.Parameters.AddWithValue("@Pago", oPlan.Pago);

                return new clsConexion().Comands(oSQLC);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo insertar el plan de pago indicado", ex);
            }
        }

        public DataTable buscarPlan(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("Select Identificacion,MontoFinanciado,Plazo,Intereses,Pago FROM PLANP WHERE Identificacion = " + Identificacion);
                return new clsConexion().SelectData(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo consultar el plan de pago", ex);
            }
        }

        public bool modificarPlan(Plan oPlan)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("UPDATE PlanP SET MontoFinanciado = @MontoFinanciado, Plazo = @Plazo, Intereses = @Intereses, Pago = @Pago WHERE Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", oPlan.Identificacion);
                oSQLC.Parameters.AddWithValue("@MontoFinanciado", oPlan.MontoFinanciado);
                oSQLC.Parameters.AddWithValue("@Plazo", oPlan.Plazo);
                oSQLC.Parameters.AddWithValue("@Intereses", oPlan.Intereses);
                oSQLC.Parameters.AddWithValue("@Pago", oPlan.Pago);

                return new clsConexion().Comands(oSQLC);
            }

            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el plan de pago", ex);
            }
        }

        public bool EliminarPlan(string Identificacion)
        {
            try
            {
                SqlCommand oSQLC = new SqlCommand("DELETE PlanP Where Identificacion = @Identificacion");
                oSQLC.CommandType = CommandType.Text;

                oSQLC.Parameters.AddWithValue("@Identificacion", Identificacion);

                return new clsConexion().Comands(oSQLC);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el plan de pago", ex);
            }
        }
    }
}
