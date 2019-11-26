<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploEntityFramework.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Teste Entity</h1>
            <asp:Label ID="NomeLabel" runat="server" Text="Nome: "></asp:Label><br />
            <asp:TextBox ID="NomeTextBox" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="EmailLabel" runat="server" Text="Email: "></asp:Label><br />
            <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="IncluirButton" runat="server" Text="Incluir" OnClick="IncluirButton_Click" />
            <asp:Button ID="ProdutoButton" runat="server" Text="Produtos" OnClick="ProdutoButton_Click"/>
              <br />  <hr/>
            <asp:GridView ID="ListaGridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
