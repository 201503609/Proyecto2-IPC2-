<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proyectos.aspx.cs" Inherits="_IPC2_Proyecto2.Proyectos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Proyectos</title>
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
            <h1><a href="Proyectos.aspx">Proyectos</h1>
            </a>
            <nav id="nav">
                <ul>
                    <li><a href="Inicio2.aspx">Inicio</a></li>
                    <li><a href="Usuarios.aspx">Usuarios</a></li>
                    <li><a href="Casos.aspx">Casos</a></li>
                    <li>
                        <asp:Button class="button special" ID="btn_cerrar" runat="server" OnClick="Button2_Click1" Text="Cerrar Sesión" /></li>
                </ul>
            </nav>
        </header>

        <!-- Main -->
        <section id="main" class="wrapper">
            <div class="container">
                <header class="major">
                    <h2>Gestión de proyectos</h2>
                </header>
            </div>
            <div class="row">
                <div class="6u 12u$(3)">
                    <ul class="actions fit small
                        ">
                        <asp:Button class="button alt fit small" ID="btnCrear" runat="server" OnClick="Button3_Click1" Text="Crear Proyecto" />
                        <asp:Button class="button fit small" ID="btnModificar" runat="server" OnClick="Button4_Click1" Text="Modificar Proyecto" />
                        <asp:Button class="button alt fit small" ID="btnPerfil" runat="server" OnClick="Button7_Click1" Text="Asignar Trabajadores" Style="height: 29px" />
                 
                    </ul>
                </div>
                <div class="6u$ 12u$(3)">
                    <ul class="actions fit small">
                        <asp:Button class="button fit small" ID="btnEliminar" runat="server" OnClick="Button5_Click1" Text="Eliminar Proyecto" Style="height: 29px" />
                        <asp:Button class="button alt fit small" ID="btnRol" runat="server" OnClick="Button6_Click1" Text="Asignar  Gerente" />
                        <asp:Button class="button fit small" ID="btnProyPer" runat="server" OnClick="Button8_Click1" Text="Proyectos Asignados" />
                    </ul>
                </div>
                <div class="6u$ 12u$(3)">
                    <ul class="actions fit small">
                        <asp:Button class="button fit small" ID="Button1" runat="server" OnClick="Button1_Click" Text="Casos del proyecto" />
                        <asp:Button class="button alt fit small" ID="btnCarga" runat="server" Text="Cargar Proyectos" OnClick="btnCarga_Click" />
                     </ul>
                </div>
            </div>

        </section>
    </form>
</body>
</html>
