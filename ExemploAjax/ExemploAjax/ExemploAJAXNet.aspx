<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExemploAJAXNet.aspx.cs" Inherits="ExemploAjax.ExemploAJAXNet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #993300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            
            <h1>Exemplo de AJAX com Framework AJAX.NET</h1>
            
            <asp:Label ID="Label1" runat="server" ></asp:Label>
            <hr />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" >

                <ContentTemplate>

                    <asp:Button ID="Button1" runat="server" Text="Testar" OnClick="Button1_Click" />
                    <br />  
                    <asp:Label ID="mensagemLabel" runat="server" ></asp:Label>
                    <br />

                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                        <ProgressTemplate>
                            <span class="auto-style1">Aguarde</span>
                        </ProgressTemplate>
                    </asp:UpdateProgress>

                </ContentTemplate>

            </asp:UpdatePanel>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
