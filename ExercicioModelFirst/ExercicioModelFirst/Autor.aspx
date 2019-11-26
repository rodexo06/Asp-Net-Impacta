<%@ Page Title="Editora" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Autor.aspx.cs" Inherits="ExercicioModelFirst.Autor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>. 
        <asp:Label runat="server" ID="mensagemLabel"></asp:Label></h2>

    <asp:GridView runat="server"
        ID="autoresGridView"
        CssClass="table"
        AutoGenerateColumns="false">
        <Columns>
            <asp:HyperLinkField runat="server"
                DataNavigateUrlFields="AutorId"
                DataTextField="NomeCompleto"
                HeaderText="Autor"
                DataNavigateUrlFormatString="~/Livros.aspx?autorId={0}" />

            <asp:BoundField runat="server"
                DataField="Endereco"
                HeaderText="Endereço" />
            <asp:BoundField runat="server"
                DataField="Cidade"
                HeaderText="Cidade" />
            <asp:BoundField runat="server"
                DataField="Estado"
                HeaderText="Estado" />
            <asp:BoundField runat="server"
                DataField="CEP"
                HeaderText="CEP" />
        </Columns>
    </asp:GridView>

</asp:Content>
