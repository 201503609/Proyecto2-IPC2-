using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class PModificar : System.Web.UI.Page
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
            Proyecto p = new Proyecto();
            ArrayList carga = new ArrayList();
            carga = p.obtenerDatos(DropDownList1.Text);
            int i = 0;
            foreach (string item in carga)
            {
                switch (i)
                {
                    case 0:
                        txtNombre.Text = item;
                        break;
                    case 1:
                        txtFechaIn.Text = item;
                        break;
                    case 2:
                        txtFechaFin.Text = item;
                        break;
                    case 3:
                        txtPresupuesto.Text = item;
                        break;
                    case 4:
                        txtDuracion.Text = item;
                        break;
                    case 5:
                        txtProject.Text = item;
                        break;
                }

                i++;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Proyecto p = new Proyecto();
            string name = DropDownList1.Text;
            p.modificarProyecto(txtNombre.Text,txtFechaIn.Text,txtFechaFin.Text,txtPresupuesto.Text,txtDuracion.Text,name,txtProject.Text);
        }
    }
}