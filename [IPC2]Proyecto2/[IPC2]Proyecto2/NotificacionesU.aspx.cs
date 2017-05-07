using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class NotificacionesU : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            string correo = Session["usuario"].ToString();
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select * From Notificacion Where usuario=@usuario AND estado=@estado", cn.getSqlConnection());
            cmd.Parameters.AddWithValue("@usuario", correo);
            cmd.Parameters.AddWithValue("@estado", "enviado");
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}