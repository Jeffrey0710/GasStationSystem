<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server" class="FormLogin">
        <div >
            <asp:Table ID="table1" runat="server" CssClass="TableLogin"
                CellPadding="50" 
                GridLines="Both"
                HorizontalAlign="Center" Width="20%" Height="200px">
                <asp:TableRow HorizontalAlign="Center" CssClass="TableRowLogin">
                    <asp:TableCell>
                        <asp:Image runat="server" Cssclass="ImageLogin" ImageUrl="images/login.png" align="center" Width="100px" Height="100px"/>
                        <p>Usuario</p>
                        <asp:TextBox ID="txtUsuario" runat="server" Width="170px"></asp:TextBox>
                        <p>Contraseña</p>
                        <asp:TextBox ID="txtContraseña" TextMode="Password" runat="server" Width="170px" ValidateRequestMode="Inherit"></asp:TextBox>
                        <br /><br /><br />
                        <asp:Button ID="BtnIngresar" CssClass="BtnLogin" runat="server" OnClick="BtnIngresar_Click" Text="INGRESAR" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>

