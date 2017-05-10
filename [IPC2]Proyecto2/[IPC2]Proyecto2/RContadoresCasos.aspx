<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RContadoresCasos.aspx.cs" Inherits="_IPC2_Proyecto2.RContadoresCasos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Contadores</title>
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
            <h1><a href="Reportes.aspx">Reportes</a></h1>

        </header>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click" />
        </div>

        <div class="row">
            <div class="6u 12u$(3)">
                Segun Categoria:
                <ul class="actions fit small">
                    <div>
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </div>
                    <div>
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </div>
                    <div>
                        <asp:GridView ID="GridView3" runat="server">
                        </asp:GridView>
                    </div>
                    <div>
                        <asp:GridView ID="GridView4" runat="server">
                        </asp:GridView>
                    </div>
                </ul>
            </div>
            <div class="6u 12u$(3)">
                Segun Estado:
                <ul class="actions fit small">
                    <div>

                        <asp:GridView ID="GridView5" runat="server">
                        </asp:GridView>

                    </div>
                    <div>

                        <asp:GridView ID="GridView6" runat="server">
                        </asp:GridView>

                    </div>
                    <div>

                        <asp:GridView ID="GridView7" runat="server">
                        </asp:GridView>

                    </div>
                    <div>

                        <asp:GridView ID="GridView8" runat="server">
                        </asp:GridView>

                    </div>
                </ul>
            </div>
            <div class="6u 12u$(3)">
                Segun Prioridad:
                <ul class="actions fit small">
                    <div>

                        <asp:GridView ID="GridView9" runat="server">
                        </asp:GridView>

                    </div>
                    <div>

                        <asp:GridView ID="GridView10" runat="server">
                        </asp:GridView>

                    </div>
                    <div>

                        <asp:GridView ID="GridView11" runat="server">
                        </asp:GridView>

                    </div>
                    <div>

                        <asp:GridView ID="GridView12" runat="server">
                        </asp:GridView>

                    </div>
                </ul>
            </div>

        </div>
    </form>
</body>
</html>
