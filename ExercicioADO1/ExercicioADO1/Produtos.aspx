<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="ExercicioADO1.Produtos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Northwind - Produtos</h1>

        <div id="arrumar">
            <div >
                <span>Pesquisar por: </span>
                <asp:Button ID="categoriaButton" runat="server" Text="Categoria" OnClick="categoriaButton_Click" />
                <asp:Button ID="fornecedorButton" runat="server" Text="Fornecedor" OnClick="fornecedorButton_Click" />
            </div>
            <br />
            <div>
                <asp:MultiView ID="MultiView1" runat="server">

                    <asp:View ID="View1" runat="server">

                        <asp:Label ID="categoriaLabel" runat="server" Text="Escolha uma categoria:"></asp:Label>
                        <asp:DropDownList ID="categoriaDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="categoriaDropDownList_SelectedIndexChanged  "></asp:DropDownList>
                        <br />

                    </asp:View>

                    <asp:View ID="View2" runat="server">

                        <asp:Label ID="forncecedorLabel" runat="server" Text="Escolha um Fornecedor:"></asp:Label>
                        <asp:DropDownList ID="fornecedorDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="fornecedorDropDownList_SelectedIndexChanged"></asp:DropDownList>
                        <br />

                    </asp:View>
                </asp:MultiView>
                <br />
                <asp:GridView ID="produtosGridView" runat="server" AutoGenerateColumns="false">

                    <Columns>
                        <asp:BoundField HeaderText="Produto" DataField="ProductName" />

                        <asp:BoundField HeaderText="Preço de Venda" DataField="UnitPrice" DataFormatString= "{0:C}">
                            <ItemStyle  HorizontalAlign="Right" /> <HeaderStyle HorizontalAlign="Right" />
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Unidade em Estoque" DataField="UnitsInStock" DataFormatString= "{0:N0}">
                            <ItemStyle  HorizontalAlign="Right" /> <HeaderStyle HorizontalAlign="Right" />
                        </asp:BoundField>

                    </Columns>

                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
