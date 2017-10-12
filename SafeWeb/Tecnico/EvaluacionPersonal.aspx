<%@ Page Title="" Language="C#" MasterPageFile="~/Tecnico/MasterTec.Master" AutoEventWireup="true" CodeBehind="EvaluacionPersonal.aspx.cs" Inherits="SafeWeb.Tecnico.EvaluacionPersonal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanEvaluacionPersonal" runat="server" CssClass="PEPersonal">
        <label>Datos demográficos</label>
        <label>Sexo</label>
        <asp:RadioButtonList ID="RbSexo" runat="server" >
            <asp:ListItem Value="0" Text="Masculino">Masculino</asp:ListItem>
            <asp:ListItem Value="1" Text="Femenino">Femenino</asp:ListItem>
        </asp:RadioButtonList><br />
        <label>¿Que edad tiene?</label>
        <asp:RadioButtonList ID="RbEdad" runat="server">
            <asp:ListItem Value="0" Text="">Menos de 25 Años</asp:ListItem>
            <asp:ListItem Value="1" Text="">Entre 26 y 35 Años</asp:ListItem>
            <asp:ListItem Value="2" Text="">Entre 36 y 45 Años</asp:ListItem>
            <asp:ListItem Value="3" Text="">Entre 46 y 55 Años</asp:ListItem>
            <asp:ListItem Value="4" Text="">Mas de 55 Años</asp:ListItem>
        </asp:RadioButtonList><br />
        <label>Salud y bienestar personal</label>
        <table class="formEvaluacion blanco centro">
            <tr><th>N°</th><th>Pregunta</th><th>Excelente</th><th>Muy buena</th><th>Buena</th>
            <th>Regular</th><th>Mala</th></tr>
            <tr>
                <td>SG1</td><td>En general diría ud. que su salud es</td>
                <td><asp:RadioButton ID="salud1" runat="server" GroupName="RbSalud"/></td>
                <td><asp:RadioButton ID="salud2" runat="server" GroupName="RbSalud"/></td>
                <td><asp:RadioButton ID="salud3" runat="server" GroupName="RbSalud"/></td>
                <td><asp:RadioButton ID="salud4" runat="server" GroupName="RbSalud"/></td>
                <td><asp:RadioButton ID="salud5" runat="server" GroupName="RbSalud"/></td>
            </tr>
        </table><br />
        <label>Para usted ¿Qué tan CIERTA O FALSA es cada una de estas afirmaciones respecto a su salud?</label>
        <table class="formEvaluacion blanco centro">
            <tr><th>N°</th><th>Pregunta</th><th>Totalmente Cierta</th><th>Casi Siempre Cierta</th><th>No sé</th>
            <th>Casi Siempre Falsa</th><th>Totalmente Falsa</th></tr>
            <tr>
                <td>SG2</td>
                <td>Me enfermo con más facilidad que otras personas</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>SG3</td>
                <td>Estoy tan saludable como cualquier persona</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>SG4</td>
                <td>Creo que mi salud va a empeorar</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>SG5</td>
                <td>Mi salud es excelente</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table><br />
        <label>En los ultimos 12 meses ¿Ha tenido algun accidente laboral?</label>
        <asp:RadioButtonList ID="RbAccidente" runat="server" >
            <asp:ListItem Value="0" Text="No">No</asp:ListItem>
            <asp:ListItem Value="1" Text="Si">Si</asp:ListItem>
        </asp:RadioButtonList><br />
        <br />
        <label>Usted tiene o ha tenido alguna enfermedad diagnosticada que haya sido provocada y/o agravada por el trabajo</label>
        <asp:RadioButtonList ID="RbEnfermedad" runat="server" >
            <asp:ListItem Value="0" Text="No">No</asp:ListItem>
            <asp:ListItem Value="1" Text="Si">Si</asp:ListItem>
        </asp:RadioButtonList><br />

    </asp:Panel>
</asp:Content>
