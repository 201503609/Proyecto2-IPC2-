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
                p.asignarGerente(proyecto, gerente);
            }
            else
            {
                DialogResult result = MessageBox.Show("El proyecto ya posee un gerente, desea cambiarlo ?", "Cambiar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    p.actulizarGerente(equipo, gerente);
                }
                else if (result == DialogResult.No)
                {

                }
            }



        }
    }
}