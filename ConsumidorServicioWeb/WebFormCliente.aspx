<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCliente.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetClientes.css" rel="stylesheet" type="text/css" />
    <title>Clientes</title>
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
            <span class="textHeader">CLIENTES</span>
        </div>
        <div class="auto-style2" >
            <asp:Label runat="server" ID="Lbl_IdCliente"></asp:Label>
            <asp:Table runat="server" HorizontalAlign="Center" >
                <asp:TableRow CssClass="rowsTable">
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Nombre</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Nombre" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Nit</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Nit" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Dirección</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Direccion" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Teléfono</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Telefono" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table><br /><br />
        </div>
        <div class="auto-style1" >
            <asp:Button ID="BtnAgregar" CsscClass="ButtonCliente" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
            <asp:Button ID="BtnActualizar" CsscClass="ButtonCliente" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" />
            <asp:Button ID="BtnEliminar" CsscClass="ButtonCliente" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar" />
            <br />
        </div>
        <div class="auto-style3">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
        </div>
    </form>
</body>
</html>
