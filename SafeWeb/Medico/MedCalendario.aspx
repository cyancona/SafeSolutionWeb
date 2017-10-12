<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/MasterMed.Master" AutoEventWireup="true" CodeBehind="MedCalendario.aspx.cs" Inherits="SafeWeb.Medico.MedCalendario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Contenido" runat="server" CssClass="content mitad">
        <asp:Calendar ID="CalendarVisitas" runat="server" CssClass="izq margenIzq mitad" 
            OnSelectionChanged="CalendarVisitas_SelectionChanged" BackColor="#F4F4F4" BorderColor="#0099CC" 
            BorderStyle="Dotted" BorderWidth="1px" ForeColor="#006666" FirstDayOfWeek="Monday" 
            Height="196px" Width="196px">
            <DayStyle Font-Size="Medium" ForeColor="#006666" />
            <SelectedDayStyle BackColor="Gray" />
        </asp:Calendar>
    </asp:Panel>
    <asp:Panel ID="ListVisitasM" runat="server" CssClass="listadoVisitas mitad">
        <asp:GridView ID="GridVisitas" runat="server" CssClass="grdVisitas" OnSelectedIndexChanged="GridVisitas_SelectedIndexChanged"></asp:GridView>
    </asp:Panel>
    <asp:Panel ID="FilaVisitasM" runat="server" CssClass="limpio centro">
        <img alt="" width="30" src="../Images/upFile.png" class="" style="margin:5px"/>
        <asp:FileUpload ID="SubListado" runat="server"  />
    </asp:Panel>
</asp:Content>
