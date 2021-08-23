<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormBombaGasolina.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormBombaGasolina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetBombaGas.css" rel="stylesheet" type="text/css" />
    <title>Bomba Gasolina</title>
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
            width:800px;
            margin-left:auto;
            margin-right:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <span class="textHeader">BOMBA GASOLINA</span>
        </div>
        <div class="auto-style2" >
            <asp:Label runat="server" ID="lbl_NoBomba"></asp:Label>
            <asp:Table runat="server" HorizontalAlign="Center" >
                <asp:TableRow CssClass="rowsTable">
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Id Tipo Gasolina</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_IdTipoGasolina" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Cantidad Gasolina</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_CantidadGas" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Monto Total</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_MontoTotal" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Caracteristicas</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Caracteristicas" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table><br /><br />
        </div>
        <div class="auto-style1" >
            <asp:Button ID="BtnAgregar" CsscClass="ButtonBombaGas" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
            <asp:Button ID="BtnActualizar" CsscClass="ButtonBombaGas" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" />
            <asp:Button ID="BtnEliminar" CsscClass="ButtonBombaGas" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar" />
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
