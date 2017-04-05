<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PCrear.aspx.cs" Inherits="_IPC2_Proyecto2.PCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtFechaIn" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtFechaFin" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtPresupuesto" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
        <br />
    </div>
    <div>

        <asp:Button ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />

    </div>


    </form>
</body>
</html>
