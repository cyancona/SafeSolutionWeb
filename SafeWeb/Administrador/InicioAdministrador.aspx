<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/MasterAdm.Master" AutoEventWireup="true" CodeBehind="InicioAdministrador.aspx.cs" Inherits="SafeWeb.Administrador.InicioAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="InicioAdmin" runat="server" CssClass="central centro">
        <asp:ImageButton ID="RegistroEmp" runat="server" ImageUrl="~/Images/upFile.png" Width="120px"/>
        <asp:ImageButton ID="RegistroUs" runat="server" />
    </asp:Panel>
</asp:Content>
