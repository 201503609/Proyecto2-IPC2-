<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearU.aspx.cs" Inherits="_IPC2_Proyecto2.CrearU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Crear Usuarios</title>
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
        <div class="6u 12u$(4)">

            <asp:TextBox ID="txtCorreo" placeholder="Correo" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtContraseña" placeholder="Contraseña" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtApellido" placeholder="Apellido" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtFecha" placeholder="Fecha Nacimiento" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtDireccion" placeholder="Direccion" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtTelefono" placeholder="Telefono" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtRol" placeholder="Rol" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <br />

        </div>
    </form>
</body>
</html>
