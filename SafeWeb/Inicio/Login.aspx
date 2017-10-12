<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterIn.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SafeWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Estilos/Login.css" type="text/css" />
    <asp:Panel ID="PanelLogin" runat="server" CssClass="centro blanco margen_panel">
        
        <table style="width: 50%; padding:10px;" class="centro" >
            <tr>
                <td>Usuario</td>
                <td><asp:TextBox ID="txtUsername" runat="server" CssClass="centro" Width="173px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="171px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Rol</td>
                <td><asp:DropDownList ID="ddRol" runat="server" CssClass="cien">
                    <asp:ListItem Value="0" Text="Supervisor"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Trabajador"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Medico"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Expositor"></asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
        </table>
        <asp:Button ID="btnInicia" runat="server" Text="Iniciar Sesion" OnClick="btnInicia_Click" />
    </asp:Panel>
</asp:Content>
