<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DadosDesconectados.aspx.cs" Inherits="ExemploADO2._0.DadosDesconectados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Dados Desconectados</h1>
            <asp:Button ID="dataTableButton" runat="server" Text="Data Table" OnClick="dataTableButton_Click" />
            <hr />
            <asp:GridView ID="listaGridView" runat="server" OnPageIndexChanging="listaGridView_PageIndexChanging"></asp:GridView>

        </div>
    </form>
</body>
</html>
