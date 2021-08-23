using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemaGasolinera.Clases
{
    public class csReporte
    {
        public DataSet reporteFactura()
        {
            DataSet dsi = new DataSet();

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select v.NoFactura, cl.Nombre as NombreCliente, tg.Nombre as TipoGasolina, em.Nombre as NombreEmpleado, fp.Nombre as FormaPago from venta v join clientes cl on cl.IdClientes = v.IdClientes join tipogasolina tg on tg.IdTipoGasolina = v.IdTipoGasolina join empleados em on em.IdEmpleados = v.IdEmpleados join formapago fp on fp.IdFormaPago = v.IdFormaPago", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch(Exception ex)
            {

            }
            return dsi;
        }
    }
      
}
