<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CCerrar.aspx.cs" Inherits="_IPC2_Proyecto2.CCerrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Cerrar Caso</title>
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
        <div>
    
            Casos:<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT  titulo FROM Caso 
Inner Join Proyectos as P
ON idProyecto = proyectoId
Where P.estado = 'activo'"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
    
        </div>
        <div>

            <br />
            <asp:TextBox ID="txtCaso"  placeholder="Caso" runat="server"></asp:TextBox>

        </div>
        <div>

            <br />
            <asp:Button ID="Button2" runat="server" Text="Cerrar" OnClick="Button2_Click" />

        </div>
        <div>

        </div>
    </form>
</body>
</html>
