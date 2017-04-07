<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CCrear.aspx.cs" Inherits="_IPC2_Proyecto2.CCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Caso</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header id="header">
            <h1><a href="Casos.aspx">Casos</a></h1>
        </header>

        <div class="6u 12u$(3)">
    
        Proyecto:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombre] FROM [Proyectos] WHERE ([estado] = @estado)">
            <SelectParameters>
                <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
        <div class="6u 12u$(3)">

        Titulo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
        <br />
        Fecha Limite:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFechaLim" runat="server"></asp:TextBox>
        <br />
        Avance:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAvance" runat="server"></asp:TextBox>
        <br />
        Descripcion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
        <br />
        Editor:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="correo" DataValueField="correo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([estado] = @estado)">
            <SelectParameters>
                <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        Estado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        Situacion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSituacion" runat="server"></asp:TextBox>
        <br />
        Categoria:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
        <br />
        Prioridad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPrioridad" runat="server"></asp:TextBox>
        <br />
        Fecha Entrega:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFechaEnt" runat="server"></asp:TextBox>
        

    </div>
        <div class="6u 12u$(3)">
    
        <asp:Button ID="Button1" class="button fit small" runat="server" Text="Crear" OnClick="Button1_Click" />
    
    </div>
    <div>

    </div>
    </form>
</body>
</html>
