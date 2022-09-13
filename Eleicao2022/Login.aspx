<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Eleicao2022.Cadastro_de_Candidatos" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
</head>
<body style="background-color: #DFDF00">
    <form id="form1" runat="server">
        <div style="text-align: center">
           <div style="padding-top:10%"></div>
            <asp:Label ID="Label3" runat="server" BorderColor="#000066" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Overline="True" Font-Size="Large" ForeColor="#006600" Height="30px" Text="Eleições 2022" Width="164px"></asp:Label>
            </br>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#009933" Text="Administrador:"></asp:Label>
            </br>
            <asp:TextBox ID="tbAdmin" runat="server"></asp:TextBox>
            </br>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#009933" Text="Senha:"></asp:Label>
            </br>
            <asp:TextBox ID="tbSenha" runat="server" TextMode="Password"></asp:TextBox>
            </br></br>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="128px" />
        </div>
    </form>
</body>
</html>
