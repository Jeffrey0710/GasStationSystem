<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormVenta.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormVenta1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetVenta.css" rel="stylesheet" type="text/css" />
    <title>Venta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <span class="textHeader">VENTA</span>
        </div>
        <div class="factura">
            <asp:Table runat="server" HorizontalAlign="Center" BorderStyle="Solid" CssClass="tableFactura">
                <asp:TableRow >
                    <asp:TableCell>.</asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right" CssClass="titleFactura">
                        <span>GASOLINERA</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left" CssClass="titleFactura">
                        <span> S. A.</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right">.</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura" Width="400px">
                        <span>Factura No</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox CssClass="camposBlanco" ID="txtFactura" runat="server" Enabled="False"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell CssClass="camposFactura2" HorizontalAlign="Center">
                        <span>Fecha</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox CssClass="camposBlanco" ID="txtfecha" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura">
                        <span>Empleado</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList CssClass="camposBlanco" ID="DDempleado" runat="server">
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura">
                        <span>Cliente</span>
                    </asp:TableCell>
                    <asp:TableCell >
                        <asp:DropDownList CssClass="camposBlanco" ID="DDcliente" runat="server">
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura">
                        <span>Forma de Pago</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList CssClass="camposBlanco" ID="DDformapago" runat="server">
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura">
                        <span>Tipo de Gasolina</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList CssClass="camposBlanco" ID="DDtipogas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDtipogas_SelectedIndexChanged1">
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell CssClass="camposFactura2" HorizontalAlign="Center">
                        <span>Precio</span>
                    </asp:TableCell>
                    <asp:TableCell>
                         <asp:TextBox CssClass="camposBlanco" ID="txtprecio" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura">
                         <span>No. Bomba Gasolina</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox CssClass="camposBlanco" ID="txtnobombagas" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell CssClass="camposFactura">
                        <span>Cantidad comprada</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox CssClass="camposBlanco" ID="txtcantcomprada" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">.</asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right">.</asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right">.</asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Button CssClass="BtnFactura" ID="btnagregar" runat="server" Text="Agregar " OnClick="btnagregar_Click" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:GridView ID="GVarticulo" runat="server" AutoGenerateColumns="False" DataKeyNames="IdArticulo" OnRowCommand="GVarticulo_RowCommand1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                                <Columns>
                                    <asp:CommandField HeaderText="Quitar" SelectText="Quitar" ShowSelectButton="True" />
                                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                                    <asp:BoundField DataField="Precio" HeaderText="Precio" />
                                    <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" />
                                </Columns>
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
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>.</asp:TableCell>
                    <asp:TableCell CssClass="camposFactura" HorizontalAlign="Right">
                        <span>Total Factura</span>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox CssClass="camposBlanco" ID="txttotalfactura" runat="server" Enabled="False"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Button CssClass="BtnFactura" ID="btnguardar" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        
    </form>
</body>
</html>
