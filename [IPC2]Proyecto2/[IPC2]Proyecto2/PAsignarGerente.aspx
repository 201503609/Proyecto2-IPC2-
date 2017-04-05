<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PAsignarGerente.aspx.cs" Inherits="_IPC2_Proyecto2.PAsignarGerente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Proyecto:

        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre">
        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [nombre] FROM [Proyectos] WHERE ([estado] = @estado)">
            <SelectParameters>
                <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

    </div>
    <div>


        Gerente:<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="correo" DataValueField="correo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([rol] = @rol)">
            <SelectParameters>
                <asp:Parameter DefaultValue="2" Name="rol" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </div>
    <div>


        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Asignar Gerente" />


    </div>
    </form>
</body>
</html>
