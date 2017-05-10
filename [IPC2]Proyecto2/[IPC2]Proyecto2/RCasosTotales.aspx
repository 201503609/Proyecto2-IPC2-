<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RCasosTotales.aspx.cs" Inherits="_IPC2_Proyecto2.RCasosTotales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Casos Totales</title>
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
            <h1><a href="Reportes.aspx">Reportes</a></h1>
            
        </header>

        <div>
    
            Proyectos:
    
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombre] FROM [Proyectos] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            Filtros<br />
            Categoria:<asp:RadioButton ID="RadioButton1" runat="server" Text="Usar" />
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombreCate" DataValueField="idCategoria">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [idCategoria], [nombreCate] FROM [Categoria]"></asp:SqlDataSource>
            <br />
            Estado:<asp:RadioButton ID="RadioButton2" runat="server" Text="Usar" />
            <br />
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="nombreEstado" DataValueField="idEstado">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [idEstado], [nombreEstado] FROM [Estado]"></asp:SqlDataSource>
            <br />
            Situacion:<asp:RadioButton ID="RadioButton3" runat="server" Text="Usar" />
            <br />
            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="nombreSituacion" DataValueField="idSituacion">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [idSituacion], [nombreSituacion] FROM [Situacion]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cargar" OnClick="Button1_Click" />
    
            <br />
    
        </div>
        <div>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
