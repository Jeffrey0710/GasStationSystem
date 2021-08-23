using MySql.Data.MySqlClient;
using System;
using System.Web.UI;

namespace ConsumidorServicioWeb
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server = localhost; Port = 3306; User Id = root; Password = ******; DataBase = sistema_gasolina");
        MySqlCommand cmd = new MySqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "select count(*) from Usuarios where Usuario = '" + txtUsuario.Text + "'and Contraseña = '" + txtContraseña.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());

                if (valor == 1)
                {
                    string script = "alert('BIENVENIDO');";
                    
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                    Response.Redirect("WebFormMaster.aspx");
                }
                else
                {
                    string script = "alert('NO EXISTE');";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }

            }
            catch (Exception ex) { }
            cn.Close();
        }
    }
}

//Test
/*
 */
