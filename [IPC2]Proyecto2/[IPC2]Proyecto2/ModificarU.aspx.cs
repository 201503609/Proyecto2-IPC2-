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
            int rolLogueado = Int32.Parse(Session["Rol"].ToString());
            int rolUEditado = u.ObtenerRo(user);
            
            if (rolUEditado == 1)
            {
                MessageBox.Show("No se pueden modificar usuarios de este tipo");
            }
            else if (rolUEditado == 2)
            {
                if (rolLogueado == 1)
                {
                    u.modificarUsuario(txtCorreo.Text, txtContra.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, Int32.Parse(txtTelefono.Text), user);
                    Response.Redirect("ModificarU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario puede modificar usuarios de este tipo");
                }
            }
            else if (rolUEditado == 3 || rolUEditado == 4 || rolUEditado == 5)
            {
                if (rolLogueado == 1 || rolLogueado == 2)
                {
                    u.modificarUsuario(txtCorreo.Text, txtContra.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, Int32.Parse(txtTelefono.Text), user);
                    Response.Redirect("ModificarU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario y Administrador(Gerente) pueden modificar usuarios de este tipo");
                }
            }
        }
    }
}