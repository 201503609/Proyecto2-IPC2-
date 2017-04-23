<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContra.aspx.cs" Inherits="_IPC2_Proyecto2.CambiarContra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Cambiar contraseña</title>
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
        <header id="header">
            <h1><a href="Inicio.aspx">Inicio</h1>
            </a>
        </header>
        <div class="6u 12u$(small)">
    
            Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            Contraseña anterior:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtVieja" runat="server" Type="password"></asp:TextBox>
            <br />
            Nueva contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNueva" runat="server" Type="password"></asp:TextBox>
    
        </div>

        <div class="6u 12u$(small)">


            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cambiar Contraseña" />


        </div>
    </form>
</body>
</html>
