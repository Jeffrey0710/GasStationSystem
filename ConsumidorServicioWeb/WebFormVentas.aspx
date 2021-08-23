<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormVentas.aspx.cs" Inherits="ConsumidorServicioWeb.WebFormVenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id Cliente<asp:TextBox ID="txt_IdCliente" runat="server"></asp:TextBox>
            <asp:Label ID="lbl_NoFact" runat="server"></asp:Label>
            <br />
            Id Empleado<asp:TextBox ID="txt_IdEmpleado" runat="server"></asp:TextBox>
            <br />
            Forma de Pago<asp:TextBox ID="txt_FormaPago" runat="server"></asp:TextBox>
            <br />
            Tipo de Gasolina<asp:TextBox ID="txt_TipoGasolina" runat="server"></asp:TextBox>
            <br />
            No. Bomba Gas<asp:TextBox ID="txt_NoBomba" runat="server"></asp:TextBox>
            <br />
            Fecha<asp:TextBox ID="txt_Fecha" runat="server"></asp:TextBox>
            <br />
            Monto Total<asp:TextBox ID="txt_MontoTotal" runat="server"></asp:TextBox>
            <br />
            Cantidad Comprada<asp:TextBox ID="txt_CantidadComprada" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnAgregar" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
            <asp:Button ID="BtnActualizar" runat="server" OnClick="BtnActualizar_Click" Text="Actualizar" />
            <br />
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
