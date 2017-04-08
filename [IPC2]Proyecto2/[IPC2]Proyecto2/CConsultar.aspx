<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CConsultar.aspx.cs" Inherits="_IPC2_Proyecto2.CConsultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"
    <title>Consultar Caso</title>
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
        <div class="6u 12u$(3)">
            <p>Se mostraran todos los datos que esten relacionados al caso</p>
        </div>
        <div class="6u 12u$(3)">
    
            Casos:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
        </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [titulo] FROM [Caso]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Consultar Casos" OnClick="Button1_Click" />
        </div>
        <div class="6u 12u$(3)">


            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />


        </div>
        <div class="6u 12u$(3)">


            Datos del Creador del Caso:<asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
         </div>
        <div class="6u 12u$(3)">


            Datos del proyecto al que pertenece el caso:<asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <br />
         </div>
        <div class="6u 12u$(3)">


            Datos de el ultimo editor del caso:<asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
            <br />
         </div>
        <div class="6u 12u$(3)">


            Categoria a la que pertenece el caso:<asp:GridView ID="GridView5" runat="server">
            </asp:GridView>
            <br />
         </div>
        <div class="6u 12u$(3)">


            Prioridad del caso:<asp:GridView ID="GridView6" runat="server">
            </asp:GridView>
            <br />
         </div>
        <div class="6u 12u$(3)">


            Estado del caso:<asp:GridView ID="GridView7" runat="server">
            </asp:GridView>
            <br />


        </div>
        <div class="6u 12u$(3)">


            Situacion del caso:<asp:GridView ID="GridView8" runat="server">
            </asp:GridView>


        </div>

    </form>
</body>
</html>
