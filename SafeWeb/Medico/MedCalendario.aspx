<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/MasterMed.Master" AutoEventWireup="true" CodeBehind="MedCalendario.aspx.cs" Inherits="SafeWeb.Medico.MedCalendario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Panel ID="Contenido" runat="server" CssClass="centro">
        <asp:Calendar ID="CalendarVisitaMedica" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
    </asp:Panel>
    <asp:Panel ID="ListVisitasM" runat="server" CssClass="listadoVisitas mitad">
        <asp:GridView ID="GridVisitas" runat="server" CssClass="grdVisitas" 
            OnSelectedIndexChanged="GridVisitas_SelectedIndexChanged" AllowPaging="True" Width="800px">
            <AlternatingRowStyle BackColor="Silver" />
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="FilaVisitasM" runat="server" CssClass="limpio centro">
        
    </asp:Panel>
</asp:Content>
