<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormReporteFactura.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormReporteFactura" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetReporteFactura.css" rel="stylesheet" type="text/css" />
    <title>Reporte Factura</title>
    <style type="text/css">
         .auto-style1 {
            display: flex;
            justify-content: center;
            text-align: center;
        }
        .auto-style2 {
            margin-top:50px;
            padding-top:50px;
        }
        .auto-style3 {
            text-align: center;
            padding-top:50px;
            width:600px;
            margin-left:auto;
            margin-right:auto;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <span class="textHeader">REPORTE FACTURA</span>
        </div>
        <div class="auto-style2" >
        </div>
        <div class="auto-style1" >
            <asp:Button ID="BtnVerReporte" CsscClass="ButtonReporte" runat="server" OnClick="BtnVerReporte_Click" Text="Visualizar Reporte" />
            <br />
        </div>
        <div class="auto-style3">
            <asp:GridView ID="GVReporteFactura" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div><br /><br />
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
        </div>
    </form>
</body>
</html>
