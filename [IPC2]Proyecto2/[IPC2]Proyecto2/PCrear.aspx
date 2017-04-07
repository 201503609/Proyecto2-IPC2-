<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PCrear.aspx.cs" Inherits="_IPC2_Proyecto2.PCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Crear Proyecto</title>
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
        </header>

        <div class="6u 12u$(3)">
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" ></asp:TextBox>
            <br />
            Fecha inicio:
            <asp:TextBox ID="txtFechaIn" runat="server" placeholder="DD/MM/AAAA"></asp:TextBox>
            <br />
            Fecha Fin:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFechaFin" runat="server" placeholder="DD/MM/AAAA"></asp:TextBox>
            <br />
            Presupuesto:
            <asp:TextBox ID="txtPresupuesto" runat="server" placeholder="Q"></asp:TextBox>
            <br />
            Duración:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDuracion" runat="server" placeholder="DD"></asp:TextBox>
            <br />
        </div>

        <div class="6u 12u$(3)">

            <asp:Button class="button fit small" ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />

        </div>


    </form>
</body>
</html>
