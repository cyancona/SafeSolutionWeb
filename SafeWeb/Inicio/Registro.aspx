﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterIn.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="SafeWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="RegistroUsuario" runat="server" CssClass="RegistroUser centro">
        <h2>Registro Usuario</h2>
        <asp:Panel ID="TipoUsuario" runat="server" CssClass="TipoUser limpio central">
            <asp:DropDownList ID="TipoUser" runat="server" OnSelectedIndexChanged="TipoUser_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="0" Text="Empleado" />
                <asp:ListItem Value="1" Text="Trabajador" /> 
                <asp:ListItem Value="2" Text="Tecnico" />
                <asp:ListItem Value="3" Text="Ingeniero" />
                <asp:ListItem Value="4" Text="Expositor" />
                <asp:ListItem Value="5" Text="Medico" />
            </asp:DropDownList>
        </asp:Panel>
        <asp:Panel ID="FormularioRegistro" runat="server" CssClass="RegistroFo limpio">
            <table class="izq blanco">
                <tr>
                    <td class="">Rut</td>
                    <td class="">
                        <asp:TextBox ID="txtRutser" runat="server" MaxLength="8"></asp:TextBox>
                        -
                        <asp:TextBox ID="txtDvuser" runat="server" Width="21px"></asp:TextBox>
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
                        <asp:ImageButton ID="imgCalendar" runat="server" ImageUrl="~/Images/calendar.png" Width="30px" OnClick="imgCalendar_Click" />
                        <asp:Calendar ID="clNacimiento" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"  OnSelectionChanged="clNacimiento_SelectionChanged" NextPrevFormat="ShortMonth" />
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
                        <asp:TextBox ID="txtTelUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Telefono Personal</td>
                    <td>
                        <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="">Direccion</td>
                    <td></td>
                </tr>
                <tr>
                    <td class="">Comuna</td>
                    <td></td>
                </tr>
                <asp:Panel ID="EspecialidadPn" runat="server" Enabled="false">
                    <tr>
                        <td>Especialidad</td>
                        <td></td>
                    </tr>
                </asp:Panel>
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