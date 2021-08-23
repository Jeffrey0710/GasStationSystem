using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sistemaGasolinera.Clases
{
    public class csUsuario
    {
        public DataSet listado_usuarios()
        {
            DataSet dsi = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from usuarios", cn);

                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }


        public DataSet usuario(string usuario, string contraseña)
        {
            DataSet dsi = new DataSet();

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from usuarios where usuario = '" + usuario + "' and contraseña = '" + contraseña + "'", cn);
                da.Fill(dsi);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return dsi;
        }

        public Int32 insertar_usuario(int idEmpleados, string usuario, string contraseña, string lugarNacimiento, string emailAlternativo, string lugarFavorito)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into usuarios (IdEmpleados, Usuario, Contraseña, LugarNacimiento, EmailAlternativo, LugarFavorito) values (" + idEmpleados + ",'" + usuario + "','" + contraseña + "','" + lugarNacimiento + "','" + emailAlternativo + "','" + lugarFavorito + "')", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 actualizar_usuario(int idEmpleados, string usuario, string contraseña, string lugarNacimiento, string emailAlternativo, string lugarFavorito)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update usuarios set IdEmpleados = " + idEmpleados + ", Usuario = '" + usuario + "', Contraseña = '" + contraseña + "', LugarNacimiento = '" + lugarNacimiento + "', EmailAlternativo = '" + emailAlternativo + "', LugarFavorito = '" + lugarFavorito + "' where Usuario = '" + usuario + "'", cn);

                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

            }
            return respuesta;
        }

        public Int32 eliminar_usuario(string usuario)
        {
            Int32 respuesta = 0;

            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConexion"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from usuarios where Usuario = '" + usuario + "'", cn);

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