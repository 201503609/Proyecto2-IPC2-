<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CAsignarEditor.aspx.cs" Inherits="_IPC2_Proyecto2.CAsignarEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
            Caso:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT titulo FROM Caso WHERE (estado = 1) OR (estado = 2) OR (estado = 4)"></asp:SqlDataSource>
            <br />
            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
    
            <br />
    
        </div>
        <div>

            Editor Actual:
            <asp:TextBox ID="txtViejo" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            Editor Nuevo:&nbsp; <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="correo" DataValueField="correo">
            </asp:DropDownList>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BugTrackerConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([estado] = @estado)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Activo" Name="estado" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>
        <div>


            <br />
            <asp:Button ID="btnAsignarT" runat="server" Text="Asignar" OnClick="btnAsignarT_Click" />


        </div>
    </form>
</body>
</html>
