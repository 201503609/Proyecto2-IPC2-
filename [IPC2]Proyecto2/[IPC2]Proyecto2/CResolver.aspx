<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CResolver.aspx.cs" Inherits="_IPC2_Proyecto2.CResolver" %>

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
                    <asp:Parameter DefaultValue="1" Name="estado" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            
            <br />
            <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
            <br />
            
        </div>
        <div>

            Estado Actual:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEstadoV" placeholder="Estado Actual" runat="server" Enabled="False"></asp:TextBox>
            <br />
            Actual Situacion:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtSituacion" placeholder="Situacion" runat="server" Enabled="False" EnableTheming="True"></asp:TextBox>

            <br />
            Nueva Situacion:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <br />

        </div>
        <div>

            <asp:Button ID="btnResolver" runat="server" Text="Resolver" OnClick="btnResolver_Click" />

        </div>
    </form>
</body>
</html>
