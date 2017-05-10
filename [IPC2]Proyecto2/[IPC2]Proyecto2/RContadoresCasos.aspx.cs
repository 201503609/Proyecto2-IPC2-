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
    public partial class RContadoresCasos : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();
        DataTable tblData2 = new DataTable();
        DataTable tblData3 = new DataTable();
        DataTable tblData4 = new DataTable();
        DataTable tblData5 = new DataTable();
        DataTable tblData6 = new DataTable();
        DataTable tblData7 = new DataTable();
        DataTable tblData8 = new DataTable();
        DataTable tblData9 = new DataTable();
        DataTable tblData10 = new DataTable();
        DataTable tblData11 = new DataTable();
        DataTable tblData12 = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //--------------------------------BUGS
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Bugs' "
                                + " From Caso "
                                + " Where categoria = 1", cn.getSqlConnection());     
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();
            //--------------------------------Mejoras
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Mejoras' "
                                + " From Caso "
                                + " Where categoria = 2", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData2);
            GridView2.DataSource = (tblData2);
            GridView2.DataBind();
            //--------------------------------INVESTIGACIONES
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Investigaciones' "
                                + " From Caso "
                                + " Where categoria = 3", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData3);
            GridView3.DataSource = (tblData3);
            GridView3.DataBind();
            //--------------------------------Actividades
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Actividades' "
                                + " From Caso "
                                + " Where categoria = 4", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData4);
            GridView4.DataSource = (tblData4);
            GridView4.DataBind();
            //--------------------------------Activos
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos Activos' "
                                + " From Caso "
                                + " Where estado = 1", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData5);
            GridView5.DataSource = (tblData5);
            GridView5.DataBind();
            //--------------------------------Reactivados
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos Reactivados' "
                                + " From Caso "
                                + " Where estado = 2", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData6);
            GridView6.DataSource = (tblData6);
            GridView6.DataBind();
            //--------------------------------Cerrados
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos Cerrados' "
                                + " From Caso "
                                + " Where estado = 3", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData7);
            GridView7.DataSource = (tblData7);
            GridView7.DataBind();
            //--------------------------------Reactivados
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos Resueltos' "
                                + " From Caso "
                                + " Where estado = 4", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData8);
            GridView8.DataSource = (tblData8);
            GridView8.DataBind();
            //--------------------------------Criticos
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos Criticos' "
                                + " From Caso "
                                + " Where prioridad = 1", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData9);
            GridView9.DataSource = (tblData9);
            GridView9.DataBind();
            //--------------------------------Deben Arreglarse
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos que Deben Arreglarse' "
                                + " From Caso "
                                + " Where prioridad = 2", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData10);
            GridView10.DataSource = (tblData10);
            GridView10.DataBind();
            //--------------------------------Arreglarse si hay tiempo
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos que Deben Arreglarse si hay tiempo' "
                                + " From Caso "
                                + " Where prioridad = 3", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData11);
            GridView11.DataSource = (tblData11);
            GridView11.DataBind();
            //--------------------------------Reactivados
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select COUNT(categoria) As 'Casos que no deben arreglarse' "
                                + " From Caso "
                                + " Where prioridad = 4", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData12);
            GridView12.DataSource = (tblData12);
            GridView12.DataBind();
        }
    }
}