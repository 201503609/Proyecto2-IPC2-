<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarRol.aspx.cs" Inherits="_IPC2_Proyecto2.CambiarRol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Cambiar Rol</title>
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar " />

        </div>
        <div class="6u$ 12u$(3)">
            Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:TextBox ID="txtCorreo" placeholder="Correo" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            Nuevo Rol:
            <asp:TextBox ID="txtRol" placeholder="Rol" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cambiar Rol" class="button fit small" />

        </div>

    </form>
</body>
</html>
