<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterIn.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SafeWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Estilos/Login.css" type="text/css" />
    <asp:Panel ID="PanelLogin" runat="server" CssClass="centro blanco margen_panel">
                <asp:Login ID="loginUsuario" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="271px" Width="286px" OnAuthenticate="loginUsuario_Authenticate" DisplayRememberMe="False">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                </asp:Login>
    </asp:Panel>
</asp:Content>
