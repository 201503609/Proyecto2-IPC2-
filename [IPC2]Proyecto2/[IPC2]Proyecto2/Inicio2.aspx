﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio2.aspx.cs" Inherits="_IPC2_Proyecto2.Inicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Inicio</title>
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
            <h1><a href="Inicio2.aspx">Inicio</a></h1>
            <nav id="nav">
                <ul>
                    <li><a href="Usuarios.aspx">Usuarios</a></li>
                    <li><a href="Proyectos.aspx">Proyectos</a></li>
                    <li><a href="Casos.aspx">Casos</a></li>
                    <li><a href="NotificacionesU.aspx">Notificaciones</a></li>
                    <li><a href="Reportes.aspx">Reportes</a></li>
                    <li><asp:Button  class="button special" ID="btn_cerrar" runat="server" OnClick="Button2_Click1" Text="Cerrar Sesión" /></li>
                </ul>
            </nav>
        </header>
        <!-- Banner -->
        <section id="banner">
            <h2>BugTracker</h2>
            <p>BIENVENIDO</p>
        </section>
    </form>
</body>
</html>
