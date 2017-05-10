<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CCrear.aspx.cs" Inherits="_IPC2_Proyecto2.CCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Crear Caso</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="description" content="" />
    <meta name="keywords" content="" />
    <!--[if lte IE 8]><script src="js/html5shiv.js"></script><![endif]-->
    <script src="js/jquery.min.js"></script>
    <script src="js/skel.min.js"></script>
    <script src="js/skel-layers.min.js"></script>
    <script src="js/init.js"></script>
    <noscript>
			<link rel="stylesheet" href="css/skel.css" />
			<link rel="stylesheet" href="css/style.css" />
			<link rel="stylesheet" href="css/style-xlarge.css" />
	</noscript>
    
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
        Estado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="nombreEstado" DataValueField="nombreEstado">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombreEstado] FROM [Estado]"></asp:SqlDataSource>
        <br />
        Situacion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList7" runat="server" DataSourceID="SqlDataSource4" DataTextField="nombreSituacion" DataValueField="nombreSituacion">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombreSituacion] FROM [Situacion]"></asp:SqlDataSource>
        <br />
        Categoria:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource5" DataTextField="nombreCate" DataValueField="nombreCate">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombreCate] FROM [Categoria]"></asp:SqlDataSource>
        <br />
        Prioridad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource6" DataTextField="nombrePrioridad" DataValueField="nombrePrioridad">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombrePrioridad] FROM [Prioridad]"></asp:SqlDataSource>
        <br />
        Fecha Entrega:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFechaEnt" runat="server"></asp:TextBox>
        

    </div>
        <div class="6u 12u$(3)">
    
        <asp:Button ID="Button1" class="button fit small" runat="server" Text="Crear" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
