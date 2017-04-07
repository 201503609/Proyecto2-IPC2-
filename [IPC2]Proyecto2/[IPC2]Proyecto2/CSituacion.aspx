<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CSituacion.aspx.cs" Inherits="_IPC2_Proyecto2.CSituacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
            Caso:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [titulo] FROM [Caso]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
    
        </div>
        <div>

            <br />
            Estado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEstado" placeholder="Estado" runat="server" Enabled="False"></asp:TextBox>
            <br />
            Actual Situacion:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtSituacion" placeholder="Actual Situacion" runat="server" Enabled="False"></asp:TextBox>
            <br />
            Nueva Situacion:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNueva" placeholder="Nueva Situacion" runat="server"></asp:TextBox>

        </div>
        <div>

            <br />
            <asp:Button ID="Button2" runat="server" Text="Cambiar Situacion" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
