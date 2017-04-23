using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class RecordarContra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            string contraseña = "";
            contraseña = u.recordarContra(txtNom.Text,txtFecha.Text,Int32.Parse(txtTel.Text));
            if(contraseña == "")
                MessageBox.Show("No se logro recuperar la contraseña");
            else
                MessageBox.Show("La contraseña es " + contraseña);
        }
    }
}