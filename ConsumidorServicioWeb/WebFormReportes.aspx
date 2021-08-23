<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormReportes.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormReportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetReportes.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contentReportes">
            <h1 class="textReportes">
                Reportes
            </h1>
        </div> <br />
        <div class="BtnsReportes" >
            <asp:Table runat="server"  HorizontalAlign="Center" Width="70%">
                <asp:TableRow >
                    <asp:TableCell HorizontalAlign="Center"  CssClass="CellsButton">
                            <asp:Button ID="BtnReporteFactura" runat="server" OnClick="BtnReporteFactura_Click" Text="Reporte Factura"/>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" CssClass="CellsButton">
                             <asp:Button ID="BtnReporteVentas" runat="server" OnClick="BtnReporteVentas_Click" Text="Reporte Ventas" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
