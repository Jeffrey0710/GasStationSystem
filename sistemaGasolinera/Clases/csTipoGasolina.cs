using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemaGasolinera.Clases
{
    public class csTipoGasolina
    {
        public DataSet precios_gasolina()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("Select * from tipogasolina", cn);
                da.Fill(dsi);

                cn.Close();
            }
            catch(Exception ex)
            {

            }
            return dsi;
        }

        public DataSet tipoGas(int idTipoGas)
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from tipogasolina where IdTipoGasolina = " + idTipoGas + "", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public Int32 actualizar_tipoGas(int idTipoGas, string nombre, double precio)
        {
            Int32 respuesta = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update tipogasolina set IdTipoGasolina = " + idTipoGas + ", Nombre = '" + nombre + "', Precio = " + precio + " where IdTipoGasolina = '" + idTipoGas + "'", cn);
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