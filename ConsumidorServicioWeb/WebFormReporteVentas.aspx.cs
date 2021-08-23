using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ConsumidorServicioWeb
{
    public partial class WebFormReporteVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WServicioWebReporteVentas.wsReporteVentasSoapClient reporte = new WServicioWebReporteVentas.wsReporteVentasSoapClient();
                DataSet dsReporte = new DataSet();

                dsReporte = reporte.reporteVenta();

                GVReporteVentas.DataSource = dsReporte;
                GVReporteVentas.DataBind();
            }
        }

        protected void BtnVerReporte_Click(object sender, EventArgs e)
        {

            dsFiltrarVentas dsReporte = new dsFiltrarVentas();
            DataTable table = dsReporte.Tables["dtFiltrarVentas"];

            foreach (GridViewRow row in GVReporteVentas.Rows)
            {
                DataRow rows = table.NewRow();

                rows["Fecha"] = row.Cells[0].Text;
                rows["NoFactura"] = row.Cells[1].Text;
                rows["NombreCliente"] = row.Cells[2].Text;
                rows["MontoTotal"] = row.Cells[3].Text;
                table.Rows.Add(rows);
            }

            ReportDocument CrystalReport = new ReportDocument();
            CrystalReport = new ReportDocument();
            CrystalReport.Load(Server.MapPath("~/rptFiltrarVentas.rpt"));
            CrystalReport.SetDataSource(dsReporte);
            CrystalReportViewer1.ReportSource = CrystalReport;
            ExportFormatType formatType = ExportFormatType.NoFormat;
            formatType = ExportFormatType.PortableDocFormat;
            CrystalReport.ExportToHttpResponse(formatType, Response, true, "rptFiltrarVentas");

        }
    }
}
