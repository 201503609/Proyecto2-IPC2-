using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class CCerrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtCaso.Text = DropDownList1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Caso c = new Caso();
            Usuario u = new Usuario();
            string caso = (DropDownList1.Text);
            int idCaso = c.obtenerIdCaso(caso);
            int estado, situacion;
            estado = 3;
            c.cerrarCaso(idCaso);
            c.crearHistorial(idCaso, "", "", "Cerrado", " ", "", "", "", Session["usuario"].ToString());
            Response.Redirect("CCerrar.aspx");
        }

    }
}