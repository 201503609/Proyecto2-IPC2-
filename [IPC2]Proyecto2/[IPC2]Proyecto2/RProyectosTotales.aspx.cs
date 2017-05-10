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
    public partial class RProyectosTotales : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn = Conexion.conectar();
            cmd = new SqlCommand("SELECT * FROM Proyectos Where estado = '"+"activo"+"'", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind(); 
        }
    }
}