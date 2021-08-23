using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebCliente.wsClienteSoapClient ws = new WServicioWebCliente.wsClienteSoapClient();
            DataSet ds = ws.listado_clientes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebCliente.wsClienteSoapClient ws = new WServicioWebCliente.wsClienteSoapClient();
            ws.insertar_cliente(txt_Nombre.Text, Convert.ToInt32(txt_Nit.Text), txt_Direccion.Text, Convert.ToInt32(txt_Telefono.Text));

            DataSet ds = ws.listado_clientes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebCliente.wsClienteSoapClient ws = new WServicioWebCliente.wsClienteSoapClient();
            ws.actualizar_cliente(Convert.ToInt32(Lbl_IdCliente.Text), txt_Nombre.Text, Convert.ToInt32(txt_Nit.Text), txt_Direccion.Text, Convert.ToInt32(txt_Telefono.Text));

            DataSet ds = ws.listado_clientes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_IdCliente.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_Nombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_Nit.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_Direccion.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_Telefono.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWebCliente.wsClienteSoapClient ws = new WServicioWebCliente.wsClienteSoapClient();
            ws.eliminar_cliente(Convert.ToInt32(Lbl_IdCliente.Text));

            DataSet ds = ws.listado_clientes();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}