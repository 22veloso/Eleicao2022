<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votacao.aspx.cs" Inherits="Eleicao2022.Votacao1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 340px;
        }
        .auto-style3 {
            margin-left: 9px;
        }
        .auto-style4 {
            margin-left: 49px;
        }
        .auto-style5 {
            margin-left: 50px;
        }
        .auto-style6 {
            margin-left: 17px;
        }
        .auto-style7 {
            margin-left: 58px;
            margin-top: 5px;
        }
        .auto-style9 {
            margin-left: 26px;
        }
        .auto-style10 {
            margin-left: 19px;
        }
        .auto-style11 {
            margin-left: 20px;
        }
        .auto-style12 {
            margin-left: 28px;
        }
    </style>
</head>
<body style="height: 359px">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <br />
            <asp:Label ID="lblDados" runat="server"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="TbResultado" runat="server" Height="33px" Width="262px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:Button ID="btn7" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style5" ForeColor="White" Height="36px" OnClick="btn7_Click" style="margin-left: 10px; margin-bottom: 11px" Text="7" Width="71px" />
            <asp:Button ID="btn8" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style11" ForeColor="White" Height="36px" OnClick="btn8_Click" style="margin-bottom: 11px" Text="8" Width="71px" />
            <asp:Button ID="btn9" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style10" ForeColor="White" Height="36px" OnClick="btn9_Click"  style="margin-bottom: 11px" Text="9" Width="71px" />
            <br />
            <asp:Button ID="Btn4" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style4" ForeColor="White" Height="37px" OnClick="Btn4_Click"  style="margin-left: 10px; margin-bottom: 12px" Text="4" Width="71px" />
            <asp:Button ID="Btn5" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style11" ForeColor="White" Height="36px" OnClick="Btn5_Click" style="margin-bottom: 12px" Text="5" Width="71px" />
            <asp:Button ID="Btn6" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style11" ForeColor="White" Height="36px" OnClick="Btn6_Click" style="margin-bottom: 12px" Text="6" Width="71px" />
            <br />
            <asp:Button ID="Btn1" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style3" ForeColor="White" Height="36px" OnClick="Btn1_Click" Text="1" Width="71px" />
            &nbsp;<asp:Button ID="Btn2" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style6" ForeColor="White" Height="36px" OnClick="Btn2_Click" Text="2" Width="71px" />
            <asp:Button ID="Btn3" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style11" ForeColor="White" Height="36px" OnClick="Btn3_Click" Text="3" Width="71px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn0" runat="server" BackColor="#666666" BorderColor="Black" CssClass="auto-style7" ForeColor="White" Height="36px" OnClick="Btn0_Click" Text="0" Width="72px" />
            <br />
            <br />
            <asp:Button ID="BtnBranco" runat="server" BackColor="White" Text="Branco" Width="71px" />
            <asp:Button ID="BtnCorrigir" runat="server" BackColor="#CC3300" CssClass="auto-style12" Text="Corrigir" Width="71px" />
            <asp:Button ID="BtnConfirmar" runat="server" BackColor="#33CC33" CssClass="auto-style9" OnClick="BtnConfirmar_Click" Text="Confirmar" Width="72px" style="height: 26px" />
            <br />
&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;</div>
    </form>
</body>
</html>
