using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Session["rol"] = null;
            Session["pass"] = null;
            Session["usuario"] = null;
            Response.Redirect("Inicio.aspx");
        }

        //Proyectos del sistema
        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RProyectosTotales.aspx");
        }

        //casos por proyecto
        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RCasosTotales.aspx");
        }
        //Contador de casos
        protected void Button7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RContadoresCasos.aspx");
        }
        //Bugs
        protected void Button5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RBugs.aspx");
        }
        //Casos asignados
        protected void Button6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RCasosAsignados.aspx");
        }
    }
}