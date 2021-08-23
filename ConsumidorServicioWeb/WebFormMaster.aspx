<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMaster.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" type="image/x-icon" href="/images/icon.ico" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="StyleSheets/StyleSheetMaster.css" rel="stylesheet" type="text/css" />
    <title>Master</title>
</head>
<body>
    <div class="bg-2">
            <span class="t-stroke-shadow">SISTEMA GASOLINERA</span>
    </div>
    <form id="form1" runat="server"> 
        <br /><br /><br />
        <div class="ContenidoMaster">
            <asp:Table ID="Table2" runat="server" CssClass="TableMaster"
                CellPadding="50" 
                GridLines="Both"
                HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnVenta" runat="server" Width="150px" Height="150px" ImageUrl="images/venta.png" OnClick="BtnVenta_Click"/>
                        <br /><h3 >VENTA</h3>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnAbastecimiento" runat="server" Width="150px" Height="150px" ImageUrl="images/abastecimiento.png" OnClick="BtnAbastecimiento_Click"/>
                        <br /><h3 >ABASTECIMIENTO</h3>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnReportes" runat="server" Width="150px" Height="150px" ImageUrl="images/reportes.png" OnClick="BtnReportes_Click"/>
                        <br /><h3 >REPORTES</h3>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div><br /><br /><br />
        <div>
            
            <asp:Table ID="Table1" runat="server" CssClass="TableMaster"
                CellPadding="40" 
                GridLines="Both"
                HorizontalAlign="Center" Width="80%">
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnUsuario" runat="server" Width="100px" Height="150px" ImageUrl="images/Usuario.png" OnClick="BtnUsuario_Click"/>
                        <br /><h3 >USUARIOS</h3>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnEmpleado" runat="server" Width="100px" Height="150px" ImageUrl="images/Empleado.png" OnClick="BtnEmpleado_Click"/>
                        <br /><h3 >EMPLEADOS</h3>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnCliente" runat="server" Width="100px" Height="150px" ImageUrl="images/Cliente.png" OnClick="BtnCliente_Click"/>
                        <br /><h3 >CLIENTES</h3>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnBomba" runat="server" Width="150px" Height="150px" ImageUrl="images/bombaGas.png" OnClick="BtnBomba_Click"/>
                        <br /><h3 >BOMBA GASOLINA</h3>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnTipoG" runat="server" Width="150px" Height="150px" ImageUrl="images/tipoGas.png" OnClick="BtnTipoG_Click"/>
                        <br /><h3 >TIPO GASOLINA</h3>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" ForeColor="#336699" CssClass="TableColumnMaster">
                        <asp:ImageButton ID="BtnFormaP" runat="server" Width="150px" Height="150px" ImageUrl="images/formaPago.png" OnClick="BtnFormaP_Click"/>
                        <br /><h3 >FORMA DE PAGO</h3>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
