using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class CambiarRol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null || Session["pass"] != null || Session["usuario"] != null)
            {

            }
            else
            {
                MessageBox.Show("No tiene permisos validos para entrar");
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            int rol = Int32.Parse(Session["Rol"].ToString());
            int rol2 = Int32.Parse(DropDownList1.Text);
            int resul = cambioRol(txtRol.Text);

            if (rol2 == 1)
            {
                MessageBox.Show("No se pueden cambiar el rol a usuarios de este tipo");
            }
            else if (rol2 == 2)
            {
                if (rol == 1)
                {
                    u.cambiarRol(txtCorreo.Text, resul);
                    Response.Redirect("CambiarRol.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario puede cambiar el rol a usuarios de este tipo");
                }
            }
            else if (rol2 == 3 || rol2 == 4 || rol2 == 5)
            {
                if (rol == 1 || rol == 2)
                {
                    u.cambiarRol(txtCorreo.Text, resul);
                    Response.Redirect("CambiarRol.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario y Administrador(Gerente) pueden cambiar el rol a usuarios de este tipo");
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = DropDownList1.Text;

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        public int cambioRol(string text)
        {
            if (text == "Super usuario")
            {
                return 1;
            }
            else if (text == "Administrador")
            {
                return 2;
            }
            else if (text == "Arquitecto")
            {
                return 3;
            }
            else if (text == "Developer")
            {
                return 4;
            }
            else if (text == "Tester")
            {
                return 5;
            }
            else
            {
                return 0;
            }
            
        }
    }
}