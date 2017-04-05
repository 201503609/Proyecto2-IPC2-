using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class CrearU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.crearUsuario(txtCorreo.Text,txtContraseña.Text,txtNombre.Text,txtApellido.Text,txtFecha.Text,txtDireccion.Text,Int32.Parse(txtTelefono.Text),Int32.Parse(txtRol.Text));
        }
    }
}