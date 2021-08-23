using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemaGasolinera.Clases
{
    public class csbombagasolina
    {
        public DataSet listado_bombagasolina()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from bombagasolina ", cn);

                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public DataSet datos_bombagasolina(int NoBombaGasolina)
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from bombagasolina where NoBombaGasolina = " + NoBombaGasolina + "", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public Int32 insertar_bombagasolina(int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into bombagasolina(IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas) values (" + IdTipoGasolina + ", " + CantidadGasolina + ", " + MontoTotalGas + ", '" + Caracteristicas + "')", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 actualizar_bombagasolina(int NoBombaGasolina, int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update bombagasolina set IdTipoGasolina = " + IdTipoGasolina + ", CantidadGasolina = " + CantidadGasolina + ", MontoTotalGas = " + MontoTotalGas + ", Caracteristicas = '" + Caracteristicas + "' where NoBombaGasolina = " + NoBombaGasolina + "", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 eliminar_bombagasolina(int NoBombaGasolina)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from bombagasolina where NoBombaGasolina = " + NoBombaGasolina + "", cn);
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