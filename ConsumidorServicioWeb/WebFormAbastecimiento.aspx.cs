using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormAbastecimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebAbastecimiento.wsAbastecimientoSoapClient ws = new WServicioWebAbastecimiento.wsAbastecimientoSoapClient();
            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebAbastecimiento.wsAbastecimientoSoapClient ws = new WServicioWebAbastecimiento.wsAbastecimientoSoapClient();
            ws.insertar_abastecimiento(Convert.ToInt32(txt_TipoGasolina.Text), Convert.ToDouble(txt_CantidadMts3.Text), txt_NombreProveedor.Text, txt_Fecha.Text);
            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebAbastecimiento.wsAbastecimientoSoapClient ws = new WServicioWebAbastecimiento.wsAbastecimientoSoapClient();
            ws.actualizar_abastecimiento(Convert.ToInt32(lbl_IdAbastecimiento.Text), Convert.ToInt32(txt_TipoGasolina.Text), Convert.ToDouble(txt_CantidadMts3.Text), txt_NombreProveedor.Text, txt_Fecha.Text);

            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_IdAbastecimiento.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_TipoGasolina.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_CantidadMts3.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_NombreProveedor.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_Fecha.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWebAbastecimiento.wsAbastecimientoSoapClient ws = new WServicioWebAbastecimiento.wsAbastecimientoSoapClient();
            ws.eliminar_abastecimiento(Convert.ToInt32(lbl_IdAbastecimiento.Text));

            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}