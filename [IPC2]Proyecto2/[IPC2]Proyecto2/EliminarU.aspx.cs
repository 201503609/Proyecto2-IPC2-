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
            int rolUsuarioLogueado = Int32.Parse(Session["Rol"].ToString());
            int rolUsuarioEditado = u.ObtenerRo(TextBox1.Text);
            if (rolUsuarioEditado == 1)
            {
                MessageBox.Show("No se pueden eliminar usuarios de este tipo");
            }
            else if (rolUsuarioEditado == 2)
            {
                if (rolUsuarioLogueado == 1)
                {
                    u.eliminarUsuario(TextBox1.Text);
                    Response.Redirect("EliminarU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario puede eliminar usuarios de este tipo");
                }
            }
            else if (rolUsuarioEditado == 3 || rolUsuarioEditado == 4 || rolUsuarioEditado == 5)
            {
                if (rolUsuarioLogueado == 1 || rolUsuarioLogueado == 2)
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