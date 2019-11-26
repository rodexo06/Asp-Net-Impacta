<%@ Page Title="Editora" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editora.aspx.cs" Inherits="ExercicioModelFirst.Editora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>

    <asp:GridView SelectedRowStyle-BackColor="#f7f7f7"
        CssClass="table"
        runat="server"
        ID="editorasGridView"
        AutoGenerateColumns="false"> 

        <Columns>
            <asp:HyperLinkField
                DataNavigateUrlFields="EditoraId"
                DataTextField="EditoraNome"
                DataNavigateUrlFormatString="Livros.aspx?editoraId={0}"
                HeaderText="Editora" />
            <asp:BoundField DataField="Cidade"
                HeaderText="Cidade" />
            <asp:BoundField DataField="Estado"
                HeaderText="Estado" />
            <asp:BoundField DataField="Pais"
                HeaderText="País" />
        </Columns>
    </asp:GridView>
</asp:Content>
