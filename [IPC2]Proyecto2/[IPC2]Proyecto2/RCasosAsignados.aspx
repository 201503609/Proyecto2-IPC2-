<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RCasosAsignados.aspx.cs" Inherits="_IPC2_Proyecto2.RCasosAsignados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Casos Asignados</title>
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
    
            <asp:Button ID="Button1" runat="server" Text="Cargar" OnClick="Button1_Click" />
    
        </div>
        <div>

            Casos Activos o Reactivos por usuario<br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </div>
        <div>

            Casos Cerrados por usuario<br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
