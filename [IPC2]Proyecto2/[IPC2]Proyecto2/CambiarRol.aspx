<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarRol.aspx.cs" Inherits="_IPC2_Proyecto2.CambiarRol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
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
    <div>

        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtRol" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cambiar Rol" />

    </div>

    </form>
</body>
</html>
