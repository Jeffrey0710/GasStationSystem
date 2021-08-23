using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsVenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsVenta : System.Web.Services.WebService
    {



        [WebMethod]
        public DataSet listado_venta()
        {
            return new Clases.csVenta().listado_venta();
        }

        [WebMethod]
        public DataSet datos_venta(int NoFactura)
        {
            return new Clases.csVenta().datos_venta(NoFactura);
        }

        [WebMethod]
        public Int32 insertar_venta(int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada)
        {
            return new Clases.csVenta().insertar_venta(idClientes, idEmpleados, idFormaPago, idTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada);
        }

        [WebMethod]
        public Int32 actualizar_venta(int NoFactura, int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada)
        {
            return new Clases.csVenta().actualizar_venta(NoFactura, idClientes, idEmpleados, idFormaPago, idTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada);
        }

        [WebMethod]
        public Int32 eliminar_cliente(int NoFactura)
        {
            return new Clases.csVenta().eliminar_venta(NoFactura);
        }

    }
}
