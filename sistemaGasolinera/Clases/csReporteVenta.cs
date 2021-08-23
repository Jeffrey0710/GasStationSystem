using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemaGasolinera.Clases
{
    public class csReporteVenta
    {

        public DataSet reporteVenta()
        {
            DataSet dsi = new DataSet();

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select v.Fecha as FechaVenta, v.NoFactura, cl.Nombre as NombreCliente, v.MontoTotal as MontoTotal from venta v  join clientes cl on cl.IdClientes = v.IdClientes", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }
    }
}