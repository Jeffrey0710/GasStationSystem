using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumidorServicioWeb
{
    public partial class WebFormMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormVenta.aspx");
        }

        protected void BtnAbastecimiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormAbastecimiento.aspx");
        }

        protected void BtnUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormUsuario.aspx");
        }

        protected void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormEmpleado.aspx");
        }

        protected void BtnCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormCliente.aspx");
        }

        protected void BtnBomba_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormBombaGasolina.aspx");
        }

        protected void BtnTipoG_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormTipoGasolina.aspx");
        }

        protected void BtnFormaP_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormFormaPago.aspx");
        }

        protected void BtnReportes_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormReportes.aspx");
        }
    }
}