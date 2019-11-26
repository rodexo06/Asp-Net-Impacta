<%@ Page Title="Livro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Livro.aspx.cs" Inherits="ExercicioModelFirst.Livro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

    <asp:GridView runat="server"
        ID="livrosGridView"
        CssClass="table"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Livro"
                HeaderText="Livro" />
            <asp:BoundField DataField="Tipo"
                HeaderText="Tipo”" />
            <asp:BoundField DataField="Preco"
                DataFormatString="{0:c}"
                HeaderText="Preço"
                ItemStyle-HorizontalAlign="Right"
                ItemStyle-Wrap="false" />
            <asp:BoundField DataField="DataPub"
                HeaderText="Publicado Em"
                DataFormatString="{0:d}" />
            <asp:BoundField DataField="Notas"
                HeaderText="Observações" />
        </Columns>

        <EmptyDataTemplate>
            <p>Nenhum resultado encontrado</p>
        </EmptyDataTemplate>
            
    </asp:GridView>
</asp:Content>
