<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="_IPC2_Proyecto2.Inicio" %>

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
<body class="landing">
    <form id="form1" runat="server">

        <!-- Header -->
        <header id="header">
            <h1><a href="Inicio.aspx">Inicio</a></h1>
            
        </header>
        <!-- Banner -->
        <section id="banner">
            <h2>BugTracker</h2>
            <div class="container 100%">

                <div class="row uniform">
                    <div class="6u 12u$(small)">
                        <asp:TextBox ID="txt_nom" runat="server" placeholder="Usuario" required></asp:TextBox>
                    </div>
                    <div class="6u$ 12u$(small)">
                        <asp:TextBox ID="txt_contra" runat="server" type="password" placeholder="Contraseña" required ></asp:TextBox>
                    </div>
                    <div class="12u$">
                        <ul class="actions">
                            <li>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Iniciar Sesión" Height="36px" Width="161px" />
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>

    </form>
</body>
</html>
