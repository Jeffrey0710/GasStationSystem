using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebUsuario.wsUsuarioSoapClient ws = new WServicioWebUsuario.wsUsuarioSoapClient();
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebUsuario.wsUsuarioSoapClient ws = new WServicioWebUsuario.wsUsuarioSoapClient();
            ws.insertar_usuario(Convert.ToInt32(txt_IdEmpleado.Text), txt_Usuario.Text, txt_Contraseña.Text, txt_LugarNacimiento.Text, txt_EmailAlternativo.Text, txt_LugarFavorito.Text);
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebUsuario.wsUsuarioSoapClient ws = new WServicioWebUsuario.wsUsuarioSoapClient();
            ws.actualizar_usuario(Convert.ToInt32(txt_IdEmpleado.Text), txt_Usuario.Text, txt_Contraseña.Text, txt_LugarNacimiento.Text, txt_EmailAlternativo.Text, txt_LugarFavorito.Text);

            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_IdEmpleado.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_Usuario.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_Contraseña.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_LugarNacimiento.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            txt_EmailAlternativo.Text = GridView1.SelectedRow.Cells[6].Text.ToString();
            txt_LugarFavorito.Text = GridView1.SelectedRow.Cells[7].Text.ToString();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWebUsuario.wsUsuarioSoapClient ws = new WServicioWebUsuario.wsUsuarioSoapClient();
            ws.eliminar_usuario(txt_Usuario.Text);

            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
        
    }
}