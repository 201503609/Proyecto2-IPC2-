﻿using System;
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
            //if (Session["rol"] != null || Session["pass"] != null || Session["usuario"] != null)
            //{
            //    MessageBox.Show("Tiene permisos validos para entrar");
            //}
            //else
            //{
            //    MessageBox.Show("No tiene permisos validos para entrar");
            //    Response.Redirect("Inicio.aspx");
            //}
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

        protected void Button7_Click1(object sender, EventArgs e)
        {

        }
    }
}