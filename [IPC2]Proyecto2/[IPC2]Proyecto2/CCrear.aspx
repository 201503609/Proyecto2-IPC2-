<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CCrear.aspx.cs" Inherits="_IPC2_Proyecto2.CCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Proyecto:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombre] FROM [Proyectos]"></asp:SqlDataSource>
    
    </div>
    <div>

        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtFechaLim" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtAvance" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEditor" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtSituacion" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtPrioridad" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtFechaEnt" runat="server"></asp:TextBox>
        

    </div>
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />
    
    </div>
    <div>

    </div>
    </form>
</body>
</html>
