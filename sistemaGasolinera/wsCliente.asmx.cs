using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCliente : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listado_clientes()
        {
            return new Clases.csCliente().listado_cliente();
        }

        [WebMethod]
        public DataSet datos_cliente(int idCliente)
        {
            return new Clases.csCliente().datos_cliente(idCliente);
        }

        [WebMethod]
        public Int32 insertar_cliente(string nombre, int nit, string direccion, int telefono)
        {
            return new Clases.csCliente().insertar_cliente(nombre, nit, direccion, telefono);
        }

        [WebMethod]
        public Int32 actualizar_cliente(int idCliente, string nombre, int nit, string direccion, int telefono)
        {
            return new Clases.csCliente().actualizar_cliente(idCliente, nombre, nit, direccion, telefono);
        }

        [WebMethod]
        public Int32 eliminar_cliente(int idCliente)
        {
            return new Clases.csCliente().eliminar_cliente(idCliente);
        }
    }
}
