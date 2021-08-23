<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacturaaspx.aspx.cs" Inherits="ventas_online.frmFacturaaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 236px;
        }
        .auto-style2 {
            width: 321px;
        }
        .auto-style3 {
            width: 236px;
            height: 23px;
        }
        .auto-style4 {
            width: 321px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 236px;
            height: 26px;
        }
        .auto-style7 {
            width: 321px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 244px;
        }
        .auto-style10 {
            height: 26px;
            width: 244px;
        }
        .auto-style11 {
            height: 23px;
            width: 244px;
        }
        .auto-style12 {
            width: 236px;
            height: 42px;
        }
        .auto-style13 {
            width: 321px;
            height: 42px;
        }
        .auto-style14 {
            width: 244px;
            height: 42px;
        }
        .auto-style15 {
            height: 42px;
        }
        .auto-style16 {
            width: 1081px;
            height: 408px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style16">
            <br />
            <br />
            <table style="width:100%;" border>
                <tr>
                    <td class="auto-style1">GASOLINERA S.A</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Factura No. </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtFactura" runat="server" Enabled="False" Height="16px" Width="178px" ></asp:TextBox>
                        <br />
                    </td>
                    <td class="auto-style10">Fecha </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Empleado </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DDempleado" runat="server" Height="16px" Width="184px">
                        </asp:DropDownList>
                        <br />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Cliente</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DDcliente" runat="server" Height="27px" Width="179px">
                        </asp:DropDownList>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Forma de Pago</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DDformapago" runat="server" Height="25px" Width="182px">
                        </asp:DropDownList>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Tipo de Gaolina<br />
                        <br />
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DDtipogas" runat="server" Height="16px" Width="180px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">Precio </td>
                    <td>
                        <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">No. Bomba Gasolina</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtnobombagas" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">Cantidad comprada</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtcantcomprada" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15">
                        <asp:Button ID="btnagregar" runat="server" Height="25px" Text="Agregar " Width="129px" OnClick="btnagregar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" rowspan="2">
                        <asp:GridView ID="GVarticulo" runat="server" Height="135px" Width="400px" AutoGenerateColumns="False" DataKeyNames="IdArticulo">
                            <Columns>
                                <asp:CommandField HeaderText="Quitar" SelectText="Quitar" ShowSelectButton="True" />
                                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                                <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style9">Total Factura<br />
                        <br />
                    </td>
                    <td>
                        <asp:TextBox ID="txttotalfactura" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnguardar" runat="server" Height="24px" Text="Guardar" Width="125px" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
