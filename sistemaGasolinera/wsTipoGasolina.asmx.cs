using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsTipoGasolina
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTipoGasolina : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet precios_gasolina()
        {
            return new Clases.csTipoGasolina().precios_gasolina();
        }

        [WebMethod]

        public DataSet tipoGas(int idTipoGas)
        {
            return new Clases.csTipoGasolina().tipoGas(idTipoGas);
        }

        [WebMethod]
        public Int32 actualizar_tipoGas(int idTipoGas, string nombre, double precio)
        {
            return new Clases.csTipoGasolina().actualizar_tipoGas(idTipoGas, nombre, precio);
        }
    }
}
