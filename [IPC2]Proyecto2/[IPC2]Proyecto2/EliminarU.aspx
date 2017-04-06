<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarU.aspx.cs" Inherits="_IPC2_Proyecto2.EliminarU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Eliminar Usuario</title>
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
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click"  class="button fit small"  />
        </div>
        <div class="6u$ 12u$(3)">
            Usuario:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" placeholder="Usuario" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; 
        <asp:Button ID="Button2" runat="server" Text="Eliminar" OnClick="Button2_Click"  class="button fit small"  />
        </div>
    </form>
</body>
</html>
