<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro_Candidato.aspx.cs" Inherits="Eleicao2022.Cadastro_Candidato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style5 {
            margin-left: 6px;
        }
        .auto-style4 {
            margin-left: 8px;
        }
        </style>
</head>
<body style="height: 289px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Overline="True" Text="Cadastro de Candidatos:"></asp:Label>
            <br />
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
            <asp:Button ID="BtnSalvarCan" runat="server" OnClick="BtnSalvarCan_Click" Text="Salvar" Height="29px" Width="80px" />
        &nbsp;<asp:Button ID="BtnVoltar" runat="server" OnClick="BtnVoltar_Click" Text="Voltar" Height="29px" Width="80px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        &nbsp;</div>
    </form>
</body>
</html>
