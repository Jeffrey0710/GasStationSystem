using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebVenta.wsVentaSoapClient ws = new WServicioWebVenta.wsVentaSoapClient();

            DataSet ds = ws.listado_venta();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebVenta.wsVentaSoapClient ws = new WServicioWebVenta.wsVentaSoapClient();
            ws.insertar_venta(Convert.ToInt32(txt_IdCliente.Text), Convert.ToInt32(txt_IdEmpleado.Text), Convert.ToInt32(txt_FormaPago.Text), Convert.ToInt32(txt_TipoGasolina.Text), Convert.ToInt32(txt_NoBomba.Text), txt_Fecha.Text, Convert.ToDouble(txt_MontoTotal.Text), Convert.ToInt32(txt_CantidadComprada.Text));

            DataSet ds = ws.listado_venta();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebVenta.wsVentaSoapClient ws = new WServicioWebVenta.wsVentaSoapClient();
            ws.actualizar_venta(Convert.ToInt32(lbl_NoFact.Text), Convert.ToInt32(txt_IdCliente.Text), Convert.ToInt32(txt_IdEmpleado.Text), Convert.ToInt32(txt_FormaPago.Text), Convert.ToInt32(txt_TipoGasolina.Text), Convert.ToInt32(txt_NoBomba.Text), txt_Fecha.Text, Convert.ToDouble(txt_MontoTotal.Text), Convert.ToInt32(txt_CantidadComprada.Text));

            DataSet ds = ws.listado_venta();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_NoFact.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_IdCliente.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_IdEmpleado.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_FormaPago.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_TipoGasolina.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            txt_NoBomba.Text = GridView1.SelectedRow.Cells[6].Text.ToString();
            txt_Fecha.Text = GridView1.SelectedRow.Cells[7].Text.ToString();
            txt_MontoTotal.Text = GridView1.SelectedRow.Cells[8].Text.ToString();
            txt_CantidadComprada.Text = GridView1.SelectedRow.Cells[9].Text.ToString();
        }
    }
}