using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class PAsignarGerente : System.Web.UI.Page
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
            Usuario u = new Usuario();
            int equipo = 0;
            int gerente = u.ObtenerId(DropDownList2.Text);
            int proyecto = p.ObtenerId(DropDownList1.Text);
            equipo = p.existenciaGerente(proyecto);
            if (equipo == 0)
            {
                if (gerente == 2)
                {
                    p.asignarGerente(proyecto, gerente);
                    Response.Redirect("PAsignarGerente.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente un usuario de tipo 2 puede ser Gerente");
                }
                
            }
            else
            {
                DialogResult result = MessageBox.Show("El proyecto ya posee un gerente, desea cambiarlo ?", "Cambiar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (gerente == 2)
                    {
                        p.actulizarGerente(equipo, gerente);
                        Response.Redirect("PAsignarGerente.aspx");
                    }
                    else
                    {
                        MessageBox.Show("Unicamente un usuario de tipo 2 puede ser Gerente");
                    }
                }
                else if (result == DialogResult.No)
                {

                }
            }



        }
    }
}