using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class EliminarU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.eliminarUsuario(TextBox1.Text);
        }
    }
}