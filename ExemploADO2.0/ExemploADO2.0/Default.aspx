<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploADO2._0.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Teste ADO.NET 2.0</h1>
            <a href="Shippers.aspx">Shippers.aspx</a> &nbsp;&nbsp<a href="Transaction.aspx">Transaction.aspx</a>
            <asp:Label runat="server" ID="labelEntrada"></asp:Label>
            <br /> 
            <br />
            <asp:Label runat="server" Text="Digite um Pais:"></asp:Label>
            <asp:TextBox ID="paisTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="pesquisarButton" runat="server" Text="Pesquisar" OnClick="pesquisarButton_Click"/>
            <hr />
            <asp:GridView ID="listaGridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
