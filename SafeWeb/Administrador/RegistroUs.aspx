<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/MasterAdm.Master" AutoEventWireup="true" CodeBehind="RegistroUs.aspx.cs" Inherits="SafeWeb.Administrador.RegistroUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <!--Panel registro de Empresa-->
    <asp:Panel ID="panEmpresa" runat="server" CssClass="RegistroFo limpio">
        <table class="izq blanco">
            <tr>
                <td class="">Rut</td>
                <td class="">
                    <asp:TextBox ID="txtRutemp" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                    -
                    <asp:TextBox ID="txtDvemp" runat="server" Width="21px" MaxLength="1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Razón Social</td>
                <td class="">
                    <asp:TextBox ID="txtRazonSocial" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Nombre Empresa</td>
                <td class="">
                    <asp:TextBox ID="txtNomEmpresa" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Direccion</td>
                <td class="">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Rubro</td>
                <td class="">
                    <asp:TextBox ID="txtRubro" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Region<br />
                    Provincia<br />
                    Comuna</td>
                <td>
                    <asp:DropDownList ID="ddRegion" runat="server" AutoPostBack="true"
                        DataValueField="id_region" DataTextField="nom_region" OnSelectedIndexChanged="ddRegion_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="ddProvincia" runat="server" AutoPostBack="true"
                        DataTextField="nom_provincia" DataValueField="id_provincia" OnSelectedIndexChanged="ddProvincia_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="ddComuna" runat="server" AutoPostBack="true"
                        DataTextField="nom_comuna" DataValueField="id_comuna">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
        </table>
    </asp:Panel>
    <!--Panel de registro para medico-->
    <asp:Panel ID="panMedico" runat="server" CssClass="RegistroFo limpio">
        <table>
            <tr>
                <td class="">Rut</td>
                <td class="">
                    <asp:TextBox ID="txtRutMed" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                    -
                        <asp:TextBox ID="txtDvMed" runat="server" Width="21px" MaxLength="1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Nombre</td>
                <td class="">
                    <asp:TextBox ID="txtNombreMed" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Apellido Paterno</td>
                <td class="">
                    <asp:TextBox ID="txtAppaterno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Apellido Materno</td>
                <td class="">
                    <asp:TextBox ID="txtApmaterno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="">Especialidad</td>
                <td class="">
                    <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="EnvioFormulario" runat="server" CssClass="centro">
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnRegistro" runat="server" Text="Registrar" OnClick="btnRegistro_Click" />
    </asp:Panel>
</asp:Content>
