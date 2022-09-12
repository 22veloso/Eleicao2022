<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votacao.aspx.cs" Inherits="Eleicao2022.Votacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 288px;
        }
        .auto-style4 {
            margin-left: 7px;
        }
        .auto-style5 {
            margin-left: 6px;
        }
        .auto-style6 {
            margin-left: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nome do Candidato:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Telefone:"></asp:Label>
        <br />
        <asp:TextBox ID="TbNomeCan" runat="server" BorderStyle="Inset" Width="356px"></asp:TextBox>
        <asp:TextBox ID="TbTelefoneCan" runat="server" BorderStyle="Inset" CssClass="auto-style5" Width="141px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Sigla do Partido:"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="N° do Partido:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Descrição do Partido:"></asp:Label>
        <br />
        <asp:TextBox ID="TbSigla" runat="server" BorderStyle="Inset" Width="96px"></asp:TextBox>
        <asp:TextBox ID="TbNumPartido" runat="server" BorderStyle="Inset" CssClass="auto-style5" Width="90px"></asp:TextBox>
        <asp:TextBox ID="TbDescPartido" runat="server" BorderStyle="Inset" CssClass="auto-style4" Width="296px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnSalvar" runat="server" Height="35px" OnClick="BtnSalvar_Click" Text="Salvar" Width="89px" />
&nbsp;<asp:Button ID="BtnLimpar" runat="server" CssClass="auto-style6" Height="35px" OnClick="BtnLimpar_Click" Text="Limpar" Width="89px" />
        <br />
        <br />
        <br />
    </form>
     
</body>
</html>
