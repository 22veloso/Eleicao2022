<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Eleicao2022.Votacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 443px;
        }
        .auto-style4 {
            margin-left: 8px;
        }
        .auto-style5 {
            margin-left: 6px;
        }
        .auto-style6 {
            margin-left: 10px;
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
        &nbsp;<br />
        <br />
        <asp:Label ID="Label11" runat="server" BorderStyle="None" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" ForeColor="#3366CC" Text="Cadastro das Escolas:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Digite o nome da Escola:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="CEP:"></asp:Label>
        <br />
        <asp:TextBox ID="TbNomeEscola" runat="server" BorderStyle="Inset" Width="406px"></asp:TextBox>
        <asp:TextBox ID="TbCep" runat="server" BorderStyle="Inset" CssClass="auto-style5" Width="110px"></asp:TextBox>
        &nbsp;<asp:Button ID="BtnLimpar1" runat="server" CssClass="auto-style6" Height="23px" OnClick="BtnLimpar_Click" Text="Pesquisar" Width="80px" />
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Bairro:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="Logradouro:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="N°:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TbBairro" runat="server" BorderStyle="Inset" Width="96px"></asp:TextBox>
        <asp:TextBox ID="TbLogradouro" runat="server" BorderStyle="Inset" CssClass="auto-style4" Width="319px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="TbNumEs" runat="server" BorderStyle="Inset" CssClass="auto-style5" Width="81px"></asp:TextBox>
        &nbsp;
        <br />
        <br />
&nbsp;<asp:Button ID="BtnSalvar" runat="server" Height="35px" OnClick="BtnSalvar_Click" Text="Salvar" Width="89px" BackColor="#3366FF" />
&nbsp;<asp:Button ID="BtnPesquisa" runat="server" CssClass="auto-style6" Height="35px" OnClick="BtnLimpar_Click" Text="Limpar" Width="89px" BackColor="Red" />
        <asp:Button ID="BtnArquivo" runat="server" CssClass="auto-style6" Height="35px" OnClick="BtnLimpar_Click" Text="Arquivo" Width="89px" />
        &nbsp;&nbsp;
        <asp:Button ID="BtnGerarUrnas" runat="server" BackColor="#CCCC00" Height="34px" Text="Gerar Urnas" Width="88px" />
&nbsp;&nbsp;
        <asp:Button ID="BtnVotacao" runat="server" BackColor="Lime" ForeColor="Black" Height="34px" Text="Iniciar Votação" Width="92px" />
        <br />
    </form>
     
</body>
</html>
