﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class PCrear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Proyecto p = new Proyecto();
            p.crearProyecto(txtNombre.Text,txtFechaIn.Text,txtFechaFin.Text,txtPresupuesto.Text,txtDuracion.Text);
        }
    }
}