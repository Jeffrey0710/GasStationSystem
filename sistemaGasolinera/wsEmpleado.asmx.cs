using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsEmpleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEmpleado : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet listado_empleados()
        {
            return new Clases.csEmpleado().listado_empleado();
        }

        [WebMethod]
        public DataSet datos_empleado(int idEmpleado)
        {
            return new Clases.csEmpleado().datos_empleado(idEmpleado);
        }

        [WebMethod]
        public Int32 insertar_empleado(string nombre, string puesto, int telefono, string email)
        {
            return new Clases.csEmpleado().insertar_empleado(nombre, puesto, telefono, email);
        }

        [WebMethod]
        public Int32 actualizar_empleado(int idEmpleado, string nombre, string puesto, int telefono, string email)
        {
            return new Clases.csEmpleado().actualizar_empleado(idEmpleado, nombre, puesto, telefono, email);
        }

        [WebMethod]
        public Int32 eliminar_empleado(int idEmpleado)
        {
            return new Clases.csEmpleado().eliminar_empleado(idEmpleado);
        }
    }
}
