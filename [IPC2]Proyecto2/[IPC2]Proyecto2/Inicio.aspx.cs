using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class Inicio : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["rol"] = null;
            Session["pass"] = null;
            Session["usuario"] = null;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            string usu = "";
            string usuario = txt_nom.Text;
            string contraseña = txt_contra.Text;
            int rol = 0;
            rol = u.ObtenerRolWorker(usuario,contraseña);
            if (rol != 0)
            {
                usu = u.ObtenerCorreoWorker(usuario);
                Session["rol"] = rol;
                Session["pass"] = contraseña;
                Session["usuario"] = usu;
                Response.Redirect("Inicio2.aspx");
            }
            else
            {
                rol = u.ObtenerRol(usuario, contraseña);
                if (rol != 0)
                {
                    Session["rol"] = rol;
                    Session["pass"] = contraseña;
                    Session["usuario"] = usuario;
                    Response.Redirect("Inicio2.aspx");
                }
                else
                {
                    MessageBox.Show("Revisar datos");
                }
            }
        }

    }
}