using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class CrearU : System.Web.UI.Page
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
            int rol = Int32.Parse(Session["Rol"].ToString());

            if (txtRol.Text == "1")
            {
                MessageBox.Show("No se pueden crear usuarios de este tipo");
            }
            else if (txtRol.Text == "2")
            {
                if (rol == 1)
                {
                    u.crearUsuario(txtCorreo.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, Int32.Parse(txtTelefono.Text), Int32.Parse(txtRol.Text),txtWorkerId.Text);
                    Response.Redirect("CrearU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario puede crear usuarios de este tipo");
                }
            }
            else if (txtRol.Text == "3" || txtRol.Text == "4" || txtRol.Text == "5")
            {
                if (rol == 1 || rol == 2)
                {
                    u.crearUsuario(txtCorreo.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, Int32.Parse(txtTelefono.Text), Int32.Parse(txtRol.Text),txtWorkerId.Text);
                    Response.Redirect("CrearU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario y Administrador(Gerente) pueden crear usuarios de este tipo");
                }
            }
            
        }

        public int cambioRol(string text)
        {
            if (text == "Super usuario")
            {
                return 1;
            }
            else if (text == "Administrador")
            {
                return 2;
            }
            else if (text == "Arquitecto")
            {
                return 3;
            }
            else if (text == "Developer")
            {
                return 4;
            }
            else if (text == "Tester")
            {
                return 5;
            }
            else
            {
                return 0;
            }

        }
    }
}