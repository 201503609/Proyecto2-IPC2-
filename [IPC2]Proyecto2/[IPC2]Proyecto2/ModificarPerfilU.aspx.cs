using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class ModificarPerfilU : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        ArrayList carga = new ArrayList();

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
            string correo, contraseña, nombre, apellido, direccion, fecha, work;
            int telefono;
            correo = TextBox1.Text;
            contraseña = TextBox2.Text;
            nombre = TextBox3.Text;
            apellido = TextBox4.Text;
            fecha = TextBox5.Text;
            direccion = TextBox6.Text;
            work = TextBox8.Text;
            telefono = Int32.Parse(TextBox7.Text);
            u.modificarUsuario(correo, contraseña, nombre, apellido, fecha, direccion, telefono, Session["usuario"].ToString(),work);
            Response.Redirect("ModificarPerfilU.aspx");
        }

        private void cargaInfo()
        {
            Thread.Sleep(1000);
            carga = u.obtenerDatos(Session["usuario"].ToString());
            int i = 0;
            foreach (string item in carga)
            {
                switch (i)
                {
                    case 0:
                        TextBox1.Text = item;
                        break;
                    case 1:
                        TextBox2.Text = item;
                        break;
                    case 2:
                        TextBox3.Text = item;
                        break;
                    case 3:
                        TextBox4.Text = item;
                        break;
                    case 4:
                        TextBox5.Text = item;
                        break;
                    case 5:
                        TextBox6.Text = item;
                        break;
                    case 6:
                        TextBox7.Text = item;
                        break;
                    case 7:
                        TextBox8.Text = item;
                        break;
                }
                i++;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cargaInfo();
        }
    }
}