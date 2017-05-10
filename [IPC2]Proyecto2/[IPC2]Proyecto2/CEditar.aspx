<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CEditar.aspx.cs" Inherits="_IPC2_Proyecto2.CEditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Editar Caso</title>
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
        </header>

        <div class="6u 12u$(small)">
    
            Caso:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
            </asp:DropDownList>
    
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT  titulo FROM Caso 
Inner Join Proyectos as P
ON idProyecto = proyectoId
Where P.estado = 'activo'"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
    
        </div>
        <div class="6u 12u$(small)">

            Descripcion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDescripcion" placeholder="Descipcion" runat="server"></asp:TextBox>
            <br />
            Editado por:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEditor" placeholder="Editor" runat="server" Enabled="False"></asp:TextBox>
            <br />
            Estado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEstado" placeholder="Estado" runat="server"></asp:TextBox>
            <br />
            Situacion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtSituacion" placeholder="Situacion" runat="server"></asp:TextBox>
            <br />
            Categoria:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCategoria" placeholder="Categoria" runat="server"></asp:TextBox>
            <br />
            Prioridad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPrioridad" placeholder="Prioridad" runat="server"></asp:TextBox>
            <br />
            Fecha Entrega:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFeEnt" placeholder="DD/MM/AAAA" runat="server"></asp:TextBox>

        </div>
        <div class="6u 12u$(small)">

            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />

        </div>
    </form>
</body>
</html>
