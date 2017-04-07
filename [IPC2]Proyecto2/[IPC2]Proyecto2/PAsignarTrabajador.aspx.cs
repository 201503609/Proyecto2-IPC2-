using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class PAsignarTrabajador : System.Web.UI.Page
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

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            Proyecto p = new Proyecto();
            Usuario u = new Usuario();
            int equipo = 0;
            int usuario = u.ObtenerId(DropDownList2.Text);
            int proyecto = p.ObtenerId(DropDownList1.Text);
            equipo = p.existenciaTrabajador(proyecto,usuario);
            if (equipo == 0)
            {
                p.asignarTrabajador(proyecto, usuario);
                Response.Redirect("PAsignarTrabajador.aspx");
            }
            else
            {
                DialogResult result = MessageBox.Show("El trabajador ya ha sido asignado al proyecto");
            }

        }
    }
}