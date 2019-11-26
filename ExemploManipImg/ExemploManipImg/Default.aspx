<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploManipImg.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Imagens</h1>
            Categoria: <asp:TextBox ID="categoriaTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:FileUpload ID="imagemFileUpload" runat="server" />
            <asp:Button ID="enviarButton" runat="server" Text="Enviar" OnClick="enviarButton_Click"/>
            <hr />
            <asp:Label ID="mensagemLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Image ID="image" runat="server" Width="500"/>

        </div>
    </form>
</body>
</html>
