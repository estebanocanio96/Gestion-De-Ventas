<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionDeventas.aspx.cs" Inherits="Gestion_De_Ventas.GestionDeventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="width: 262px">Gestion de Ventas</h1>
        <div style="width: 228px">
            <h2>Ingresar Nueva Venta</h2>
            <asp:TextBox ID="txtFecha" runat="server" placeholder="Fecha de Venta"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtVendedor" runat="server" placeholder="Nombre del Vendedor"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtDetalle" runat="server" placeholder="Detalle de Venta"></asp:TextBox>
            <br />
            <br />          
            <asp:TextBox ID="txtMonto" runat="server" placeholder="Monto de Venta"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregarVenta" runat="server" Text="Agregar venta" OnClick="btnAgregarVenta_Click" />
        </div>
        <div style="width: 359px">
            <h2>Historial de Ventas</h2>
            <asp:GridView ID="gvVentas" runat="server" AutoGenerateColumns="true" Width="351px"></asp:GridView>
        </div>
    </form>
</body>
</html>
