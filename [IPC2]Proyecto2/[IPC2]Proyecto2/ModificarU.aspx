<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarU.aspx.cs" Inherits="_IPC2_Proyecto2.ModificarU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Modificar</title>
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
            Usuarios:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="correo" DataValueField="correo">
        </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
        </div>
        <div class="6u$ 12u$(3)">

            WorkerId:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtWorker" placeholder="WorkerID" runat="server"></asp:TextBox>
            <br />

            Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtCorreo" placeholder="Correo" runat="server"></asp:TextBox>
            <br />
            Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtContra" placeholder="Contraseña" runat="server"></asp:TextBox>
            <br />
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtApellido" placeholder="Apellido" runat="server"></asp:TextBox>
            <br />
            Fe. Nacimiento:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFecha" placeholder="DD/MM/AAAA" runat="server"></asp:TextBox>
            <br />
            Direccion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDireccion" placeholder="Direccion" runat="server"></asp:TextBox>
            <br />
            Telefono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtTelefono" placeholder="Telefono" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modificar" />
            <br />

        </div>

    </form>
</body>
</html>
