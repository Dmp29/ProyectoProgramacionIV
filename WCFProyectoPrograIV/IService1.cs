using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFProyectoPrograIV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml)]

        void insertarPago(PagoLlenar objPago);

        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml)]

        List<Pago> mostrarPagos();

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Pago
    {
        [DataMember]
        public string IdAsociado { get; set; }

        [DataMember]
        public string Identificacion { get; set; }

        [DataMember]
        public string IdOperacion { get; set; }

        [DataMember]
        public decimal Cuota { get; set; }

        [DataMember]
        public decimal MontoPago { get; set; }

        [DataMember]
        public float IndParcial { get; set; }

        [DataMember]
        public float Interes { get; set; }
    }

    [DataContract]
    public class PagoLlenar
    {
        [DataMember]
        public int IdAsociado { get; set; }

        [DataMember]
        public string Identificacion { get; set; }

        [DataMember]
        public int IdOperacion { get; set; }

        [DataMember]
        public decimal Cuota { get; set; }

        [DataMember]
        public decimal MontoPago { get; set; }

        [DataMember]
        public int IndParcial { get; set; }

        [DataMember]
        public int Interes { get; set; }
    }
}
