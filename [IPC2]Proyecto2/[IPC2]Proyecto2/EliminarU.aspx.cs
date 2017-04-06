using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class EliminarU : System.Web.UI.Page
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
            TextBox1.Text = DropDownList1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            int rol = Int32.Parse(Session["Rol"].ToString());
            int rol2 = Int32.Parse(TextBox1.Text);
            if (rol2 == 1)
            {
                MessageBox.Show("No se pueden crear usuarios de este tipo");
            }
            else if (rol2 == 2)
            {
                if (rol == 1)
                {
                    u.eliminarUsuario(TextBox1.Text);
                    Response.Redirect("EliminarU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario puede eliminar usuarios de este tipo");
                }
            }
            else if (rol2 == 3 || rol2 == 4 || rol2 == 5)
            {
                if (rol == 1 || rol == 2)
                {
                    u.eliminarUsuario(TextBox1.Text);
                    Response.Redirect("EliminarU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario y Administrador(Gerente) pueden eliminar usuarios de este tipo");
                }
            }
        }
    }
}