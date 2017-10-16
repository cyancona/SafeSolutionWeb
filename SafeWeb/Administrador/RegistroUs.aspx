<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/MasterAdm.Master" AutoEventWireup="true" CodeBehind="RegistroUs.aspx.cs" Inherits="SafeWeb.Administrador.RegistroUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Panel ID="RegistroUsuario" runat="server" CssClass="RegistroUser centro">
        <h2>Registro Usuario</h2>
        <asp:Panel ID="TipoUsuario" runat="server" CssClass="TipoUser limpio central">
            <asp:DropDownList ID="TipoUser" runat="server" OnSelectedIndexChanged="TipoUser_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="0" Text="Empleado" />
                <asp:ListItem Value="1" Text="Trabajador" /> 
                <asp:ListItem Value="2" Text="Tecnico" />
                <asp:ListItem Value="3" Text="Ingeniero" />
                <asp:ListItem Value="4" Text="Expositor" />
            </asp:DropDownList>
        </asp:Panel>
        <asp:Panel ID="FormularioRegistro" runat="server" CssClass="RegistroFo limpio">
            <table class="izq blanco">
                <tr>
                    <td class="">Rut</td>
                    <td class="">
                        <asp:TextBox ID="txtRutser" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                        -
                        <asp:TextBox ID="txtDvuser" runat="server" Width="21px" MaxLength="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Nombre</td>
                    <td class="">
                        <asp:TextBox ID="txtNomuser" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Apellido Paterno</td>
                    <td class="">
                        <asp:TextBox ID="txtAppaterno" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Apellido Materno</td>
                    <td class="">
                        <asp:TextBox ID="txtApMaterno" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <asp:Panel ID="OtrosPn" runat="server">
                <tr>
                    <td class="">Fecha Nacimiento</td>
                    <td class="">
                        <asp:TextBox ID="txtNacimiento" runat="server" Width="106px" Enabled="true"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtNacimiento_CalendarExtender" runat="server" BehaviorID="txtNacimiento_CalendarExtender" TargetControlID="txtNacimiento" />
                    </td>
                </tr>
                <tr>
                    <td class="">Sexo</td>
                    <td class="">
                        <asp:RadioButtonList ID="RbSexUser" runat="server">
                            <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                            <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="">Telefono fijo</td>
                    <td>
                        <asp:TextBox ID="txtTelUser" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Telefono Personal</td>
                    <td>
                        <asp:TextBox ID="txtCelular" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Dirección</td>
                    <td></td>
                </tr>
                <tr>
                    <td class="">Comuna</td>
                    <td></td>
                </tr>
                </asp:Panel>
                <tr>
                    <td class="">
                    </td>
                    <td>
                        <asp:Button ID="btnRegUser" runat="server" OnClick="btnRegUser_Click" Text="Registrar" />
                        <br />
                        <asp:Label ID="lblError" runat="server" Text="" CssClass="rojo"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
