<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Casos.aspx.cs" Inherits="_IPC2_Proyecto2.Casos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Casos</title>
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
            <nav id="nav">
                <ul>
                    <li><a href="Inicio2.aspx">Inicio</a></li>
                    <li><a href="Usuarios.aspx">Usuarios</a></li>
                    <li><a href="Proyectos.aspx">Proyectos</a></li>
                    <li>
                        <asp:Button class="button special" ID="btn_cerrar" runat="server" OnClick="Button2_Click1" Text="Cerrar Sesión" /></li>
                </ul>
            </nav>
        </header>

        <!-- Main -->
        <section id="main" class="wrapper">
            <div class="container">

                <header class="major">
                    <h2>Gestión de Casos</h2>
                </header>

            </div>
            <div class="row">
                <div class="6u 12u$(3)">
                    <ul class="actions alt fit small
                        ">
                        <asp:Button class="button fit small" ID="btnCrear" runat="server" OnClick="Button3_Click1" Text="Crear Caso" />
                        <asp:Button class="button alt fit small" ID="btnEditar" runat="server" OnClick="Button4_Click1" Text="Editar Caso" />
                        <asp:Button class="button fit small" ID="btnAsignar" runat="server" OnClick="Button6_Click1" Text="Asignar Trabajador" />
                        <asp:Button class="button alt fit small" ID="btnConsultar" runat="server" OnClick="Button9_Click1" Text="Historial Caso" Style="height: 29px" />                      
                        <asp:Button class="button fit small" ID="btnTotales" runat="server" OnClick="Button11_Click1" Text="Casos del sistema" Style="height: 29px" />    
                    </ul>
                </div>
                <div class="6u$ 12u$(3)">
                    <ul class="actions alt fit small">
                        <asp:Button class="button alt fit small" ID="btnResolver" runat="server" OnClick="Button7_Click1" Text="Resolver Caso" Style="height: 29px" />
                        <asp:Button class="button fit small " ID="btnSituacion" runat="server" OnClick="Button8_Click1" Text="Cambiar Situacion" Style="height: 29px" />
                        <asp:Button class="button alt fit small" ID="btnReactivar" runat="server" OnClick="Button10_Click1" Text="Reactivar Caso" Style="height: 29px" />                   
                        <asp:Button class="button fit small" ID="btnEliminar" runat="server" OnClick="Button5_Click1" Text="Cerrar Caso" Style="height: 29px" />                        
                        <asp:Button class="button alt fit small" ID="btnCon" runat="server" OnClick="Button12_Click1" Text="Consultar Caso" Style="height: 29px" />                        

                    </ul>

                </div>
            </div>
        </section>
    </form>
</body>
</html>
