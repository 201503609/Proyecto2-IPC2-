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
    public partial class ModificarU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            ArrayList carga = new ArrayList();
            carga = u.obtenerDatos(DropDownList1.Text);
            int i = 0;
            foreach (string item in carga)
            {
                switch (i)
                {
                    case 0:
                        txtCorreo.Text = item;
                        break;
                    case 1:
                        txtContra.Text = item;
                        break;
                    case 2:
                        txtNombre.Text = item;
                        break;
                    case 3:
                        txtApellido.Text = item;
                        break;
                    case 4:
                        txtFecha.Text = item;
                        break;
                    case 5:
                        txtDireccion.Text = item;
                        break;
                    case 6:
                        txtTelefono.Text = item;
                        break;
                }

                i++;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            string user = DropDownList1.Text;
            u.modificarUsuario(txtCorreo.Text,txtContra.Text,txtNombre.Text,txtApellido.Text,txtFecha.Text,txtDireccion.Text,Int32.Parse(txtTelefono.Text),user);
        }
    }
}