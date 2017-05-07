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
    public partial class CAsignarEditor : System.Web.UI.Page
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

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Caso c = new Caso();
            ArrayList carga = new ArrayList();
            carga = c.datosEditablesdelCaso(DropDownList1.Text);
            int i = 0;
            Usuario u = new Usuario();
            foreach (string item in carga)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        txtViejo.Text = u.ObtenerCorreo(Int32.Parse(item));
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
                i++;
            }
        }

        protected void btnAsignarT_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            Caso c = new Caso();
            Proyecto p = new Proyecto();

            string caso = (DropDownList1.Text);
            int idCaso = c.obtenerIdCaso(caso);
            int trabViejo, trabNuevo;
            trabViejo = u.ObtenerId(txtViejo.Text);
            trabNuevo = u.ObtenerId(DropDownList2.Text);
            ArrayList carga = new ArrayList();
            string[] hola = new string[12];
            carga = c.datosCompletosdeCaso(DropDownList1.Text);
            int i = 0, proy;
            foreach (string item in carga)
            {
                hola[i] = item;
                i++;
            }

            proy = Int32.Parse(hola[3]);
            MessageBox.Show(proy.ToString());
            int pr = p.existenciaTrabajador(proy,trabNuevo);
            if (pr != 0)
            {
                c.AsignarCaso(idCaso,trabNuevo);
                c.crearHistorial(idCaso,"",DropDownList2.Text,"","","","","",Session["usuario"].ToString());
                c.crearNotificacion(DropDownList2.Text,"Se te ha asignado al caso " + caso);
            }
            else
            {
                MessageBox.Show("El trabajador debe estar asignado al proyecto");
            }

        }
    }
}