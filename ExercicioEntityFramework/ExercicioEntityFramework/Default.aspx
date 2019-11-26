<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExercicioEntityFramework.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Styles/css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Exercicio Entity Framework</h1>

            <section>
                <span>Pesquisar por: </span>
                <asp:Button ID="categoriaButton" runat="server" Text="Categoria" OnClick="categoriaButton_Click" />
                <asp:Button ID="fornecedorButton" runat="server" Text="Fornecedor" OnClick="fornecedorButton_Click" />
            </section>

            <section>
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <div>
                            <asp:Label ID="categoriaLabel" runat="server" Text="Escolha uma categoria: "></asp:Label>
                            <asp:DropDownList ID="categoriaDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="categoriaDropDownList_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <div>
                            <asp:Label ID="FornecedorLabel" runat="server" Text="Escolha um fornecedor: "></asp:Label>
                            <asp:DropDownList ID="FornecedorDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FornecedorDropDownList_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </asp:View>
                </asp:MultiView>
                <section>
                    <section>
                        <asp:GridView ID="produtosGridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField HeaderText="Produto" DataField="Nome" />

                                <asp:BoundField HeaderText="Preço de Venda" DataField="Preco" DataFormatString="{0:C}">
                                    <ItemStyle HorizontalAlign="Right" />
                                    <HeaderStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="Unidades em Estoque" DataField="Estoque" DataFormatString="{0:N0}">
                                    <ItemStyle HorizontalAlign="Right" />
                                    <HeaderStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                    </section>
                </section>
            </section>
        </div>
    </form>
</body>
</html>
