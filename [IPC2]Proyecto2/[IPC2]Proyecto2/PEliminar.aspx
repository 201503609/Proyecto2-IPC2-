﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PEliminar.aspx.cs" Inherits="_IPC2_Proyecto2.PEliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Proyectos:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombre] FROM [Proyectos] WHERE ([estado] = @estado)">
            <SelectParameters>
                <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
    
    </div>

    <div>


        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>


        <asp:Button ID="Button2" runat="server" Text="Eliminar" OnClick="Button2_Click" />


    </div>
    </form>
</body>
</html>