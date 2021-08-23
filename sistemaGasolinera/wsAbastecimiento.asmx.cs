using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsAbastecimiento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsAbastecimiento : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listado_abastecimiento()
        {
            return new Clases.csAbastecimiento().listado_abastecimiento();
        }

        [WebMethod]
        public DataSet datos_abastecimiento(int idAbastecimiento)
        {
            return new Clases.csAbastecimiento().datos_abastecimiento(idAbastecimiento);
        }

        [WebMethod]
        public Int32 insertar_abastecimiento(int idTipodeGasolina, double cantidadMts3, string nombreProveedor, string fecha)
        {
            return new Clases.csAbastecimiento().insertar_abastecimiento(idTipodeGasolina, cantidadMts3, nombreProveedor, fecha);
        }

        [WebMethod]
        public Int32 actualizar_abastecimiento(int idAbastecimiento, int idTipodeGasolina, double cantidadMts3, string nombreProveedor, string fecha)
        {
            return new Clases.csAbastecimiento().actualizar_abastecimiento(idAbastecimiento, idTipodeGasolina, cantidadMts3, nombreProveedor, fecha);
        }

        [WebMethod]
        public Int32 eliminar_abastecimiento(int idAbastecimiento)
        {
            return new Clases.csAbastecimiento().eliminar_abastecimiento(idAbastecimiento);
        }

    }
}
