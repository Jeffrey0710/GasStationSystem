using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormBombaGasolina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebBombaGasolina.wsbombagasolinaSoapClient ws = new WServicioWebBombaGasolina.wsbombagasolinaSoapClient();

            DataSet ds = ws.listado_bombagasolina();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebBombaGasolina.wsbombagasolinaSoapClient ws = new WServicioWebBombaGasolina.wsbombagasolinaSoapClient();
            ws.insertar_bombagasolina(Convert.ToInt32(txt_IdTipoGasolina.Text), Convert.ToInt32(txt_CantidadGas.Text), Convert.ToDouble(txt_MontoTotal.Text), txt_Caracteristicas.Text);

            DataSet ds = ws.listado_bombagasolina();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
        
        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebBombaGasolina.wsbombagasolinaSoapClient ws = new WServicioWebBombaGasolina.wsbombagasolinaSoapClient();
            ws.actualizar_bombagasolina(Convert.ToInt32(lbl_NoBomba.Text), Convert.ToInt32(txt_IdTipoGasolina.Text), Convert.ToInt32(txt_CantidadGas.Text), Convert.ToDouble(txt_MontoTotal.Text), txt_Caracteristicas.Text);

            DataSet ds = ws.listado_bombagasolina();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_NoBomba.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_IdTipoGasolina.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_CantidadGas.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_MontoTotal.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_Caracteristicas.Text = GridView1.SelectedRow.Cells[5].Text.ToString();

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWebBombaGasolina.wsbombagasolinaSoapClient ws = new WServicioWebBombaGasolina.wsbombagasolinaSoapClient();
            ws.eliminar_bombagasolina(Convert.ToInt32(lbl_NoBomba.Text));

            DataSet ds = ws.listado_bombagasolina();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}