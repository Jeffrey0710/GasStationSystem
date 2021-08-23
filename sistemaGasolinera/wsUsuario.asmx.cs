using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listado_usuarios()
        {
            return new Clases.csUsuario().listado_usuarios();
        }

        [WebMethod]
        public DataSet usuario(string usuario, string contraseña)
        {
            return new Clases.csUsuario().usuario(usuario, contraseña);

        }

        [WebMethod]
        public Int32 insertar_usuario(int idEmpleados, string usuario, string contraseña, string lugarNacimiento, string emailAlternativo, string lugarFavorito)
        {
            return new Clases.csUsuario().insertar_usuario(idEmpleados, usuario, contraseña, lugarNacimiento, emailAlternativo, lugarFavorito);
        }

        [WebMethod]
        public Int32 actualizar_usuario(int idEmpleados, string usuario, string contraseña, string lugarNacimiento, string emailAlternativo, string lugarFavorito)
        {
            return new Clases.csUsuario().actualizar_usuario(idEmpleados, usuario, contraseña, lugarNacimiento, emailAlternativo, lugarFavorito);
        }

        [WebMethod]
        public Int32 eliminar_usuario(string usuario)
        {
            return new Clases.csUsuario().eliminar_usuario(usuario);
        }
    }
}
