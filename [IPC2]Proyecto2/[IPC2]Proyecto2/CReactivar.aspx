<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CReactivar.aspx.cs" Inherits="_IPC2_Proyecto2.CReactivar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
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
        <div>

            <br />
            Titulo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <br />
            <br />
            Nueva situacion:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Reactivar" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
