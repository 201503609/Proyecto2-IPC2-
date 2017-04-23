<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecordarContra.aspx.cs" Inherits="_IPC2_Proyecto2.RecordarContra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Recordar Contraseña</title>
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
            <h1><a href="Inicio.aspx">Inicio</h1>
            </a>
        </header>
        <div class="6u 12u$(small)">
    
            Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNom" runat="server" placeholder="Correo" required></asp:TextBox>
            <br />
            Fecha Nacimiento:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFecha" runat="server" placeholder ="Fecha" required></asp:TextBox>
            <br />
            Telefono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTel" runat="server" placeholder ="Telefono" required></asp:TextBox>
    
            <br />
    
        </div>
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Recordar" />

        </div>
    </form>
</body>
</html>
