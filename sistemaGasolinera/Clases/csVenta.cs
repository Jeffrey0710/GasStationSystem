using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemaGasolinera.Clases
{
    public class csVenta
    {
        public DataSet listado_venta()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from venta", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public DataSet datos_venta(int NoFactura)
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from venta where NoFactura = " + NoFactura + "", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public Int32 insertar_venta(int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into venta (IdClientes, IdEmpleados, IdFormaPago, IdTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada) values (" + idClientes + ",'" + idEmpleados + "','" + idFormaPago + "','" + idTipoGasolina + "','" + NoBombaGasolina + "','" + Fecha + "','" + MontoTotal + "','" + CantidadComprada + "')", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 actualizar_venta(int NoFactura, int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update venta set IdClientes = " + idClientes + ", IdEmpleados = '" + idEmpleados + "', IdFormaPago = '" + idFormaPago + "', IdTipoGasolina = '" + idTipoGasolina + "', NoBombaGasolina = '" + NoBombaGasolina + "', Fecha = '" + Fecha + "', MontoTotal = '" + MontoTotal + "', CantidadComprada = '" + CantidadComprada + "' where NoFactura = '" + NoFactura + "'", cn);

                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 eliminar_venta(int NoFactura)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from venta where NoFactura = " + NoFactura + "", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }
    }
}