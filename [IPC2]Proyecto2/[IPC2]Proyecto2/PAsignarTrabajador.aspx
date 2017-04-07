﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PAsignarTrabajador.aspx.cs" Inherits="_IPC2_Proyecto2.PAsignarTrabajador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Asignar Trabajador</title>
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
    
            Proyectos:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre">
            </asp:DropDownList>
    
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombre] FROM [Proyectos] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
    
        </div>
        <div class="6u 12u$(3)">


            Trabajador:&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="correo" DataValueField="correo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>


        </div>

        <div class="6u 12u$(3)">


            <asp:Button ID="btnAsignar" runat="server" Text="Asignar Trabajador" OnClick="btnAsignar_Click" />


        </div>
    </form>
</body>
</html>
