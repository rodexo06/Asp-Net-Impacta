<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploADO.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Exemplo ADO</h1>
            <asp:Button ID="clienteButton" runat="server" Text="Cliente" OnClick="clienteButton_Click"/>
            <hr />
            <asp:ListBox ID="listaListBox" DataValueField="CustomerId" DataTextField="CompanyName" 
                AutoPostBack="true" OnSelectedIndexChanged="listaListBox_SelectedIndexChanged"
                runat="server" Visible="false"   Rows="10"></asp:ListBox>
            <br /><br />

                <asp:Label ID="mensagemLabel" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
