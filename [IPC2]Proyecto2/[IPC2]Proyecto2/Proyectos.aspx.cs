using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class Proyectos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null || Session["pass"] != null || Session["usuario"] != null)
            {
                int rororo =  Int32.Parse(Session["rol"].ToString());
                if (rororo == 3 || rororo == 4 || rororo == 5)
                {
                    btnCrear.Visible = false;
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    btnRol.Visible = false;
                    btnPerfil.Visible = false;
                    btnCarga.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No tiene permisos validos para entrar");
                Response.Redirect("Inicio.aspx");
            }
        }
        //Cerrar Sesión
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Session["rol"] = null;
            Session["pass"] = null;
            Session["usuario"] = null;
            Response.Redirect("Inicio.aspx");
        }
        //Crear Proyecto
        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PCrear.aspx");
        }
        //Modificar Proyecto
        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PModificar.aspx");
        }
        //Eliminar Proyecto
        protected void Button5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PEliminar.aspx");
        }
        //Asignar Gerente
        protected void Button6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PAsignarGerente.aspx");
        }
        //Asignar trabajador
        protected void Button7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PAsignarTrabajador.aspx");
        }
        //proyectos asignados
        protected void Button8_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PAsignados.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PCasosTotales.aspx");
        }

        protected void btnCarga_Click(object sender, EventArgs e)
        {
            Response.Redirect("PCargaMasiva.aspx");
        }
    }
}