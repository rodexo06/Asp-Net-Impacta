    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="ExemploADO2._0.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Exemplo Transactions</h1>
                <label>Retirar uma unidade do estoque</label>
                <asp:DropDownList ID="produtoRetirarDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ProdutoRetirarDropDownList_SelectedIndexChanged"  DataTextField="ProductName" DataValueField="ProductId"></asp:DropDownList>
                <br />
                <label>Total no estoque </label>
                <asp:Label ID="produtoLabel" runat="server"></asp:Label>
            <br />
                <label>Inserir uma unidade do estoque</label>
               <asp:DropDownList ID="produtoInserirDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="produtoInserirDropDownList_SelectedIndexChanged" DataTextField="ProductName" DataValueField="ProductId"></asp:DropDownList>
                <br />
                <label>Total no estoque </label>
                <asp:Label ID="produto2Label" runat="server" ></asp:Label>
            <br />
                <asp:Button ID="executeButton" runat="server" Text="Execute" OnClick="executeButton_Click"/>

            <br /><br />
            <asp:Label ID="mensagemLabel" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
