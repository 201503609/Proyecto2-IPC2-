<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearU.aspx.cs" Inherits="_IPC2_Proyecto2.CrearU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtRol" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
        <br />
    
    </div>
    </form>
</body>
</html>
