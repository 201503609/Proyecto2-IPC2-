using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class Casos : System.Web.UI.Page
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

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Session["rol"] = null;
            Session["pass"] = null;
            Session["usuario"] = null;
            Response.Redirect("Inicio.aspx");
        }
        //Crear Casos
        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CCrear.aspx");
        }
        //Editar Casos
        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CEditar.aspx");
        }
        //Cerrar Caso
        protected void Button5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CCerrar.aspx");
        }
        //Asignar Trabajador
        protected void Button6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CAsignarEditor.aspx");
        }
        //Resolver Caso
        protected void Button7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CResolver.aspx");
        }
        //Cambiar Situacion
        protected void Button8_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CSituacion.aspx");
        }
        //Consultar Caso
        protected void Button9_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CHistorial.aspx");
        }
        //Reactivar Caso
        protected void Button10_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CReactivar.aspx");
        }
    }
}