<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PAsignados.aspx.cs" Inherits="_IPC2_Proyecto2.PAsignados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Proyectos Asignados</title>
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
            <h1><a href="Proyectos.aspx">Proyectos</a></h1>
        </header>

        <div class="6u 12u$(3)">
    
            Proyectos Asignados:<br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    
        </div>
        <div class="6u 12u$(3)">
    
        </div>
        <div>
    
        </div>
        <div>
    
        </div>
    </form>
</body>
</html>
