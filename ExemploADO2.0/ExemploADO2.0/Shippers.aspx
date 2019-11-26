<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shippers.aspx.cs" Inherits="ExemploADO2._0.Shippers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ADO.NET - SHIPPERS</h1>
            <a href="Default.aspx">Default</a> &nbsp;&nbsp<a href="Transaction.aspx">Transaction.aspx</a>
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
            <br />
            <br />

            <asp:Label runat="server" Text="Nome:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox><br />
            <asp:Label runat="server" Text="Telefone:"></asp:Label>&nbsp; <asp:TextBox ID="telefoneTextBox" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="incluirButton" runat="server" Text="Incluir" OnClick="incluirButton_Click" /><hr />

            <asp:GridView ID="listaGridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
