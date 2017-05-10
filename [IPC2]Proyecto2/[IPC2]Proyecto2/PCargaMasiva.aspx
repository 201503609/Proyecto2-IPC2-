<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PCargaMasiva.aspx.cs" Inherits="_IPC2_Proyecto2.PCargaMasiva" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Carga Masiva</title>
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
            <h1><a href="Proyectos.aspx">Proyectos</a></h1>
        </header>

        <!-- Main -->
        <section id="main" class="wrapper">
            <div class="container">
                <header class="major">
                    <h2>Menú de carga</h2>
                    <p>Seleccione el archivo que desee cargar</p>
                </header>
            </div>
        </section>

        <div>
            Seleccione el archivo:&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />

        </div>
        <div>
            <center>    
                <asp:Button ID="btnCargar" runat="server" Text="Cargar Archivo" OnClick="btnCargar_Click" />
            </center>
            <br />
        </div>
        <hr />

        <!-- Main1 -->
        <section id="main1" class="wrapper">
            <div class="container">
                <header class="major">
                    <h2>Menú de Bitacora</h2>
                    <p>Seleccione el rango de fechas que desee visualizar</p>
                </header>
            </div>
        </section>
        <div class="6u$ 12u$(3)">
            Fecha Inicio:<asp:DropDownList  align="right" ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="fechaHora" DataValueField="fechaHora">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [fechaHora] FROM [Bitacora]"></asp:SqlDataSource>
            <br />
            Fecha Final:<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="fechaHora" DataValueField="fechaHora">
            </asp:DropDownList>

        </div>
        <div>
            <br />
            <center>
                <asp:Button ID="btnBitacora" runat="server" Text="Cargar Bitacora" align="center" OnClick="btnBitacora_Click" />
            </center>
            <br />
        </div>
        <div>

            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>

        </div>
        <hr />

        <!-- Main2 -->
        <section id="main2" class="wrapper">
            <div class="container">
                <header class="major">
                    <h2>Detalle de Bitacora</h2>
                    <p>Seleccione el id de la bitacora que desee vizualizar</p>
                </header>
            </div>
        </section>
        <div class="6u$ 12u$(3)">

            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="idBitacora" DataValueField="idBitacora">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [idBitacora] FROM [Bitacora]"></asp:SqlDataSource>
            <br />
            <center>
                <asp:Button ID="Button1" runat="server" Text="Cargar Detalle Bitacora" OnClick="Button1_Click" />
            </center>
            <br />
        </div>
        <div>

            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>

        </div>
        <hr />

        <!-- Main3 -->
        <section id="main3" class="wrapper">
            <div class="container">
                <header class="major">
                    <h2>Archivos cargados</h2>
                    <p>Seleccione el id de la bitacora que desee ver el archivo</p>
                </header>
            </div>
        </section>
        <div class="6u$ 12u$(3)">

            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource3" DataTextField="idBitacora" DataValueField="ubicacion">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [idBitacora], [ubicacion] FROM [Bitacora]"></asp:SqlDataSource>

        </div>
        <div>

            <center>
                <asp:Button ID="Button2" runat="server" Text="Abrir" OnClick="Button2_Click" />
            </center>

        </div>
    </form>
</body>
</html>
