<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarPerfilU.aspx.cs" Inherits="_IPC2_Proyecto2.ModificarPerfilU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Modificar Perfil</title>
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
            <h1><a href="Usuarios.aspx">Usuarios</h1>
            </a>
        </header>


        <div class="6u$ 12u$(3)">
            <asp:Button ID="Button2" runat="server" Text="Cargar información" OnClick="Button2_Click" />
        </div>

        <div class="6u$ 12u$(3)">
            Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox placeholder="Correo" ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Contraseña:
        <asp:TextBox placeholder="Contraseña" ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox placeholder="Nombre" ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp;
        <asp:TextBox placeholder="Apellido" ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Fecha:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox placeholder="DD/MM/AAAA" ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Direccion:&nbsp;&nbsp;
        <asp:TextBox placeholder="Direccion" ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Telefono:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox placeholder="telefono" ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="button alt fit small" ID="Button1" runat="server" OnClick="Button1_Click" Text="Modificar" />
            <br />
        </div>
    </form>
</body>
</html>
