<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterIn.Master" AutoEventWireup="true" CodeBehind="RegEmpresa.aspx.cs" Inherits="SafeWeb.Inicio.RegEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="RegistroEmp">
        <h2>Registro Empresa</h2>
        <div class="RegistroFo" style="text-align:left; width:60%;">
            <table class="RegForm margenIzq" style="width:80%">
                <tr>
                    <td class="auto-style1">Rut</td>
                    <td class="auto-style3"><asp:TextBox ID="txtRutEmpresa" runat="server"></asp:TextBox> -
                        <asp:TextBox ID="txtDvEmpresa" runat="server" Width="21px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="">Razon Social</td>
                    <td class=""><asp:TextBox ID="txtRazonSocial" runat="server" Width="170px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="">Nombre Empresa</td>
                    <td class=""><asp:TextBox ID="txtNombreEmpresa" runat="server" Width="170px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="">Rubro</td>
                    <td class=""><asp:TextBox ID="txtRubro" runat="server" Width="170px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Direccion</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Comuna</td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblError" class="rojo" runat="server" Text=""></asp:Label>
                    </td>
                    <td><asp:Button ID="btnRegUser" runat="server" Text="Registrar" OnClick="btnRegUser_Click" /></td>
                </tr>
             </table>
        </div>
    </div>
</asp:Content>
