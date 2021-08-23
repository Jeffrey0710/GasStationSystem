using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumidorServicioWeb
{
    public partial class WebFormReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnReporteFactura_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormReporteFactura.aspx");
        }

        protected void BtnReporteVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormReporteVentas.aspx");
        }
    }
}