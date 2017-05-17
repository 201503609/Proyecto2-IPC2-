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
    public partial class RCasosAsignados : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();
        DataTable tblData2 = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Reactivos o Activados
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select U.nombre, COUNT(C.estado) AS 'Casos Asignados' " +
                    " From Usuarios as U " +
                    " Inner Join Caso as C " +
                    " ON U.idUsuario = C.editadoPor " + 
                    " Where(C.estado = '1' OR C.estado = '2') " +
                    " Group by U.nombre", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();

            //Cerrados
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select H.editadoPor as 'Usuario' , COUNT(H.cambioPor) as 'Casos Cerrados' " +
                                    " from Historial as H "+
                                    " Where H.estado = 'Cerrado' " +
                                    " Group by editadoPor", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData2);
            GridView2.DataSource = (tblData2);
            GridView2.DataBind();
        }
    }
}