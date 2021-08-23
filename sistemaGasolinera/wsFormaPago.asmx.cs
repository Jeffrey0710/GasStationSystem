using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsFormaPago
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsFormaPago : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet formas_pago()
        {
            return new Clases.csFormaPago().formas_pago();
        }

        [WebMethod]
        public Int32 insertar_formaPago(string nombre)
        {
            return new Clases.csFormaPago().insertar_formaPago(nombre);
        }

        [WebMethod]
        public Int32 eliminar_formaPago(int idFormaPago)
        {
            return new Clases.csFormaPago().eliminar_formaPago(idFormaPago);
        }
    }
}
