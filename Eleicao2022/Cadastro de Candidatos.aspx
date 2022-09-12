<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro de Candidatos.aspx.cs" Inherits="Eleicao2022.Cadastro_de_Candidatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 580px;
        }
        .auto-style2 {
            width: 1605px;
            height: 1228px;
        }
    </style>
    </head>
<body>
  
     <form id="form1" runat="server" style="background-color: #DFDF00" class="auto-style2" target="_top">
     <div class="mb-3 row">
    <div class="col-sm-10">
        <br />
        <asp:Label ID="Label3" runat="server" BorderColor="#000066" CssClass="auto-style1" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Overline="True" Font-Size="Large" ForeColor="#006600" Height="30px" Text="Eleições 2022" Width="164px"></asp:Label>
&nbsp;<br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#009933" Text="Administrador:"></asp:Label>
        <br />
    </div>
         <asp:TextBox ID="tbAdmin" runat="server" ></asp:TextBox>
  </div>
  <div class="mb-3 row">
         <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#009933" Text="Senha:"></asp:Label>
         </div>
         <asp:TextBox ID="tbSenha" runat="server"></asp:TextBox>
     <p>
         <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="128px" />
         </p>
    </form>
     </form>
</body>
</html>
