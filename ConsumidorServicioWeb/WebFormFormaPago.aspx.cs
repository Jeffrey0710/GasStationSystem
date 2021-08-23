using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormFormaPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebFormaPago.wsFormaPagoSoapClient ws = new WServicioWebFormaPago.wsFormaPagoSoapClient();

            DataSet ds = ws.formas_pago();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebFormaPago.wsFormaPagoSoapClient ws = new WServicioWebFormaPago.wsFormaPagoSoapClient();
            ws.insertar_formaPago(txt_Nombre.Text);

            DataSet ds = ws.formas_pago();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_IdFormaPago.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_Nombre.Text = GridView1.SelectedRow.Cells[0].Text.ToString();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWebFormaPago.wsFormaPagoSoapClient ws = new WServicioWebFormaPago.wsFormaPagoSoapClient();
            ws.eliminar_formaPago(Convert.ToInt32(lbl_IdFormaPago.Text));

            DataSet ds = ws.formas_pago();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}