using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFProyectoPrograIV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        SqlConnection conn = new SqlConnection("Data Source = DavidMoraPC\\SQL2017; Initial Catalog = BDProyectoPrograIV; Integrated Security = True");

        public void insertarPago(PagoLlenar objPago)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into Pago(IdAsociado, Identificacion, IdOperacion, Cuota, MontoPago, IndParcial, Interes) values(@IdAsociado,@Identificacion,@IdOperacion,@Cuota,@MontoPago,@IndParcial,@Interes)");

            cmd.Parameters.AddWithValue("@IdAsociado", objPago.IdAsociado);
            cmd.Parameters.AddWithValue("@Identificacion", objPago.Identificacion);
            cmd.Parameters.AddWithValue("@IdOperacion", objPago.IdOperacion);
            cmd.Parameters.AddWithValue("@Cuota", objPago.Cuota);
            cmd.Parameters.AddWithValue("@MontoPago", objPago.MontoPago);
            cmd.Parameters.AddWithValue("@IndParcial", objPago.IndParcial);
            cmd.Parameters.AddWithValue("@Interes", objPago.Interes);

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public List<Pago> mostrarPagos()
        {
            DataTable objTable = new DataTable();
            List<Pago> Lista = new List<Pago>();

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Pa.Identificacion, Aso.NombreEmpresa, Op.DescripcionOperacion, Pa.Cuota, Pa.MontoPago, Pa.IndParcial, Pa.Interes FROM Pago Pa JOIN Operacion Op ON Pa.IdOperacion = Op.IdOperacion Join Asociado Aso ON Pa.IdAsociado = Aso.IdAsociado");

            cmd.Connection = conn;

            SqlDataReader DR = cmd.ExecuteReader();


            if (DR.HasRows)
            {

                while (DR.Read())
                {
                    Pago objPago = new Pago();
                    objPago.Identificacion = DR.GetString(0);
                    objPago.IdAsociado = DR.GetString(1);
                    objPago.IdOperacion = DR.GetString(2);
                    objPago.Cuota = DR.GetDecimal(3);
                    objPago.MontoPago = DR.GetDecimal(4);
                    objPago.IndParcial = DR.GetInt32(5);
                    objPago.Interes = DR.GetInt32(6);
                    Lista.Add(objPago);
                }
            }
            else
            {
                throw new Exception("No existen Pagos");
            }

            conn.Close();

            return Lista;
        }

        public List<Pago> mostrarPagosID(string Identificacion)
        {
            DataTable objTable = new DataTable();
            List<Pago> Lista1 = new List<Pago>();

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Pa.Identificacion, Aso.NombreEmpresa, Op.DescripcionOperacion, Pa.Cuota, Pa.MontoPago, Pa.IndParcial, Pa.Interes FROM Pago Pa JOIN Operacion Op ON Pa.IdOperacion = Op.IdOperacion Join Asociado Aso ON Pa.IdAsociado = Aso.IdAsociado where Pa.Identificacion = " + Identificacion);

            cmd.Connection = conn;

            SqlDataReader DR = cmd.ExecuteReader();

            if (DR.HasRows)
            {

                while (DR.Read())
                {
                    Pago objPago = new Pago();
                    objPago.Identificacion = DR.GetString(0);
                    objPago.IdAsociado = DR.GetString(1);
                    objPago.IdOperacion = DR.GetString(2);
                    objPago.Cuota = DR.GetDecimal(3);
                    objPago.MontoPago = DR.GetDecimal(4);
                    objPago.IndParcial = DR.GetInt32(5);
                    objPago.Interes = DR.GetInt32(6);
                    Lista1.Add(objPago);
                }
            }
            else
            {
                throw new Exception("No existen Pagos");
            }

            conn.Close();

            return Lista1;
        }
    }
}
