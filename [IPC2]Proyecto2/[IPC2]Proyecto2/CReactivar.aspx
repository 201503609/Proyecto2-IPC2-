<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CReactivar.aspx.cs" Inherits="_IPC2_Proyecto2.CReactivar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Reactivar caso</title>
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
    
            Caso:<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [titulo] FROM [Caso] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="2" Name="estado" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
    
        </div>
        <div class="6u 12u$(small)">

            <br />
            Titulo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <br />
            <br />
            Nueva situacion:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombreSituacion" DataValueField="nombreSituacion">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombreSituacion] FROM [Situacion]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Reactivar" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
