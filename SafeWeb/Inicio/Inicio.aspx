<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterIn.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SafeWeb.Inicio.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 282px;
        }
        .auto-style2 {
            font-size: 70%;
            width: 238px;
        }
        table tr td{
            margin:10px;
            padding:10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenido">
        <table class="tablaContenido">
            <tr>
                <td class="auto-style1">
                    <img src="../Images/SafePrevencion-recuperado.png" style="width:70%;"/></td>
                <td class="auto-style2"><h1>Bienvenido</h1><br /><h4>Portal de administracion SAFE</h4></td>
                <td><textarea name="S1" class="txaDescripcion">Una pequeña descripcion sobre la empresa</textarea></td>
            </tr>
        </table>
    </div>
</asp:Content>
