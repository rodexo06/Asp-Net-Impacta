<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploAjax.Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <ajaxToolkit:MaskedEditExtender ID="TextBox1_MaskedEditExtender" runat="server" TargetControlID="TextBox1" Mask="99999-999" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Exemplo" OnClick="Button1_Click" />
            <ajaxToolkit:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" ConfirmText="Confirma isso?" TargetControlID="Button1" />
            <br />
            <br />
            <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="2" Width="598px">
                <ajaxToolkit:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
                    <HeaderTemplate>
                        Dados do Painel
                    </HeaderTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                    <HeaderTemplate>
                        Dados
                    </HeaderTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                    <HeaderTemplate>
                        teste
                    </HeaderTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
            <br />
            <br />
            <br />
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
