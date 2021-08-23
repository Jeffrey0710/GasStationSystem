using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace sistemaGasolinera
{
    /// <summary>
    /// Descripción breve de wsbombagasolina
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsbombagasolina : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet listado_bombagasolina()
        {
            return new Clases.csbombagasolina().listado_bombagasolina();
        }

        [WebMethod]
        public DataSet datos_bombagasolina(int NoBombaGasolina)
        {
            return new Clases.csbombagasolina().datos_bombagasolina(NoBombaGasolina);
        }

        [WebMethod]
        public Int32 insertar_bombagasolina(int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas)
        {
            return new Clases.csbombagasolina().insertar_bombagasolina(IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas);
        }

        [WebMethod]
        public Int32 actualizar_bombagasolina(int NoBombaGasolina, int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas)
        {
            return new Clases.csbombagasolina().actualizar_bombagasolina(NoBombaGasolina, IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas);
        }

        [WebMethod]
        public Int32 eliminar_bombagasolina(int NoBombaGasolina)
        {
            return new Clases.csbombagasolina().eliminar_bombagasolina(NoBombaGasolina);
        }

    }
}
