<%@ Page Title="" Language="C#" MasterPageFile="~/Tecnico/MasterTec.Master" AutoEventWireup="true" CodeBehind="EvaluacionTerreno.aspx.cs" Inherits="SafeWeb.Tecnico.EvaluacionTerreno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="TablaEvaluacion" runat="server" CssClass="izq limpio panEvaluacion">
        <table class="centro formEvaluacion">
            <tr>
                <th>Identificacion de riesgo</th>
                <th>Codigo</th>
                <th colspan="3">Probabilidad</th>
                <th colspan="3">Severidad</th>
                <th>Valor del riesgo</th>
                <th>Prioridad</th>
                <th>Medidas Preventivas</th>
                <th>Resp. Seguimiento y control</th>
            </tr>
            <tr>
                <td>Caida a destino nivel (al fondo de excavacion)</td>
                <td><asp:TextBox ID="CodRegistro" runat="server" CssClass="CodRegistro"></asp:TextBox></td>
                <td><asp:RadioButton ID="probabilidad1" runat="server" GroupName="probabilidad"/></td>
                <td><asp:RadioButton ID="probabilidad2" runat="server" GroupName="probabilidad"/></td>
                <td><asp:RadioButton ID="probabilidad3" runat="server" GroupName="probabilidad"/></td>
                <td><asp:RadioButton ID="severidad1" runat="server" GroupName="severidad"/></td>
                <td><asp:RadioButton ID="severidad2" runat="server" GroupName="severidad"/></td>
                <td><asp:RadioButton ID="severidad3" runat="server" GroupName="severidad"/></td>
                <td><asp:DropDownList ID="ValorRiesgo" runat="server">
                    <asp:ListItem Value="1" Text="Trivial"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Tolerable"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Moderado"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Importante"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Intolerable"></asp:ListItem>
                    </asp:DropDownList></td>
                <td><asp:DropDownList ID="Prioridad" runat="server">
                    <asp:ListItem Value="1" Text="Baja"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Mediana"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Mediana-Alta"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Alta"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Inmediata"></asp:ListItem>
                    </asp:DropDownList></td>
                <td><textarea id="MedidasPreventivas" cols="20" rows="2"></textarea></td>
                <td><textarea id="SegYControl" cols="20" rows="2"></textarea></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>