<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormUsuario.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetUsuarios.css" rel="stylesheet" type="text/css" />
    <title></title>
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
            <span class="textHeader">USUARIOS</span>
        </div>
        <div class="auto-style2" >
            <asp:Table runat="server" HorizontalAlign="Center" Height="174px">
                <asp:TableRow CssClass="rowsTable">
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Id Empleado</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_IdEmpleado" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Usuario</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Usuario" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Contraseña</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_Contraseña" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Lugar de Nacimiento</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_LugarNacimiento" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Email Alternativo</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_EmailAlternativo" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <span>Lugar Favorito</span>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Left">
                        <asp:TextBox ID="txt_LugarFavorito" runat="server" CssClass="txtDatos"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table><br /><br />
        </div>
        <div class="auto-style1" >
            <asp:Button ID="BtnAgregar" CsscClass="ButtonUsuario" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
            <asp:Button ID="BtnActualizar" CsscClass="ButtonUsuario" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" />
            <asp:Button ID="BtnEliminar" CsscClass="ButtonUsuario" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar" />
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
