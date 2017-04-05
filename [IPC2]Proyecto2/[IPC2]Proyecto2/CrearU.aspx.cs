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
                    u.crearUsuario(txtCorreo.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, Int32.Parse(txtTelefono.Text), Int32.Parse(txtRol.Text));
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
                    u.crearUsuario(txtCorreo.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtFecha.Text, txtDireccion.Text, Int32.Parse(txtTelefono.Text), Int32.Parse(txtRol.Text));
                    Response.Redirect("CrearU.aspx");
                }
                else
                {
                    MessageBox.Show("Unicamente el Super usuario y Administrador(Gerente) pueden crear usuarios de este tipo");
                }
            }
            
        }
    }
}