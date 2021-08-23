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
    public partial class WebFormReporteFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WServicioWebReporteFactura.wsReporteSoapClient reporte = new WServicioWebReporteFactura.wsReporteSoapClient();
                DataSet dsReporte = new DataSet();

                dsReporte = reporte.reporteFactura();

                GVReporteFactura.DataSource = dsReporte;
                GVReporteFactura.DataBind();
            }
        }

        protected void BtnVerReporte_Click(object sender, EventArgs e)
        {

            dsBuscarFactura dsReporte = new dsBuscarFactura();
            DataTable table = dsReporte.Tables["dtReporteFactura"];

            foreach (GridViewRow row in GVReporteFactura.Rows)
            {
                DataRow rows = table.NewRow();

                rows["NoFactura"] = row.Cells[0].Text;
                rows["NombreCliente"] = row.Cells[1].Text;
                rows["TipoGasolina"] = row.Cells[2].Text;
                rows["NombreEmpleado"] = row.Cells[3].Text;
                rows["FormaPago"] = row.Cells[4].Text;
                table.Rows.Add(rows);
            }

            ReportDocument CrystalReport = new ReportDocument();
            CrystalReport = new ReportDocument();
            CrystalReport.Load(Server.MapPath("~/rptReporteFactura.rpt"));
            CrystalReport.SetDataSource(dsReporte);
            CrystalReportViewer1.ReportSource = CrystalReport;
            ExportFormatType formatType = ExportFormatType.NoFormat;
            formatType = ExportFormatType.PortableDocFormat;
            CrystalReport.ExportToHttpResponse(formatType, Response, true, "rptReporteFactura");
        }
    }
}