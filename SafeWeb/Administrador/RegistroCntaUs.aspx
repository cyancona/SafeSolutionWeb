<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/MasterAdm.Master" AutoEventWireup="true" CodeBehind="RegistroCntaUs.aspx.cs" Inherits="SafeWeb.Administrador.RegistroCntaUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="RegistroUsuario" runat="server" CssClass="RegistroUser centro">
        <h2>Registro Usuario</h2>

        <asp:Panel ID="TipoUsuario" runat="server" CssClass="TipoUser limpio central">
            <asp:DropDownList ID="ddTipoUser" runat="server" OnSelectedIndexChanged="TipoUser_SelectedIndexChanged"
                AutoPostBack="True" DataTextField="nombre_rol" DataValueField="id_rol">
            </asp:DropDownList>
        </asp:Panel>

        <asp:Panel ID="panCuentaUsuario" runat="server" CssClass="central centro cyan mitad">
            <table>
                <tr>
                    <td class="">Usuario</td>
                    <td class="">
                        <asp:TextBox ID="txtUsername" runat="server" Width="170px" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Password</td>
                    <td class="">
                        <asp:TextBox ID="txtPassword" runat="server" Width="170px" TextMode="Password" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Confirmar Password</td>
                    <td class="">
                        <asp:TextBox ID="txtConfirmar" runat="server" Width="170px" TextMode="Password" required="true"></asp:TextBox>
                        <asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtConfirmar" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="CompareValidator">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCuentaUserError" runat="server" Text=""></asp:Label>

                    </td>
                    <td>
                        <asp:Button ID="btnCuentaUsuario" runat="server" Text="Registrar Cuenta" OnClick="btnCuentaUsuario_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </asp:Panel>
</asp:Content>
