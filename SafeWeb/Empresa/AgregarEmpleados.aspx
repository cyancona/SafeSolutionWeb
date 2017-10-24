<%@ Page Title="" Language="C#" MasterPageFile="~/Empresa/MasterEmp.Master" AutoEventWireup="true" CodeBehind="AgregarEmpleados.aspx.cs" Inherits="SafeWeb.Empresa.AgregarEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:GridView ID="grdEmpleados" runat="server" AllowPaging="True"></asp:GridView>
            </td>
            <td>
                <asp:FileUpload ID="fuExcel" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
