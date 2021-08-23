using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormTipoGasolina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebTipoGasolina.wsTipoGasolinaSoapClient ws = new WServicioWebTipoGasolina.wsTipoGasolinaSoapClient();

            DataSet ds = ws.precios_gasolina();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebTipoGasolina.wsTipoGasolinaSoapClient ws = new WServicioWebTipoGasolina.wsTipoGasolinaSoapClient();
            ws.actualizar_tipoGas(Convert.ToInt32(lbl_IdTipoGas.Text), txt_Nombre.Text, Convert.ToDouble(txt_Precio.Text));

            DataSet ds = ws.precios_gasolina();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_IdTipoGas.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_Nombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_Precio.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
        }
    }
}