<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarU.aspx.cs" Inherits="_IPC2_Proyecto2.ModificarU" %>

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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([estado] = @estado)">
            <SelectParameters>
                <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
    </div>
    <div>

        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtDireccion" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modificar" />
        <br />

    </div>

    </form>
</body>
</html>
