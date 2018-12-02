using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class clsConexion
    {
        public SqlConnection oCN;

        public clsConexion()
        {
            oCN = new SqlConnection("Data Source = DavidMoraPC\\SQL2017; Initial Catalog = BDProyectoPrograIV; Integrated Security = True");

        }

        public SqlConnection StringConexion()
        {
            oCN = new SqlConnection("Data Source = DavidMoraPC\\SQL2017; Initial Catalog = BDProyectoPrograIV; Integrated Security = True");
            return oCN;
        }

        public bool OpenConnection()
        {
            try
            {
                oCN.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede abrir la conexión con la base de datos", ex);
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (oCN.State != System.Data.ConnectionState.Closed)
                {
                    oCN.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede cerrar la conexión con la base de datos", ex);
            }
        }

        public bool Comands(SqlCommand oSQLC)
        {
            try
            {
                if (OpenConnection())
                {
                    oSQLC.Connection = oCN;
                    oSQLC.ExecuteNonQuery();
                    oCN.Close();
                    return true;
                }
                oCN.Close();
                return false;
            }
            catch (Exception ex)
            {
                oCN.Close();
                throw new Exception("No se pudo completar la solicitud", ex);
            }
        }

        public DataTable SelectData(SqlCommand oSQLC)
        {
            try
            {
                oSQLC.Connection = oCN;
                DataTable oDT = new DataTable();
                SqlDataAdapter oSQLDA = new SqlDataAdapter(oSQLC);
                if (OpenConnection())
                {
                    oSQLDA.Fill(oDT);
                }
                CloseConnection();
                return oDT;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo obtener la información deseada", ex);
            }
        }
    }
}