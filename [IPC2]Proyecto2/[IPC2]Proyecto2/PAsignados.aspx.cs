using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class PAsignados : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null || Session["pass"] != null || Session["usuario"] != null)
            {
                Usuario u = new Usuario();
                int idU = u.ObtenerId(Session["usuario"].ToString());

                int rololo = Int32.Parse(Session["rol"].ToString());
                if (rololo == 3 || rololo == 4 || rololo == 5)
                {
                    cn = Conexion.conectar();
                    cmd = new SqlCommand("SELECT p.nombre, p.duracion, p.presupuesto,p.fecha_inicio, p.fecha_fin,p.estado From Proyectos As p Inner Join Equipo On idProyecto = proyectoId Inner Join Usuarios On idUsuario = usuarioId Where idUsuario = @usuario ", cn.getSqlConnection());
                    cmd.Parameters.AddWithValue("@usuario", idU);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(tblData);
                    GridView1.DataSource = (tblData);
                    GridView1.DataBind();
                }
                else
                {
                    cn = Conexion.conectar();
                    cmd = new SqlCommand("SELECT p.nombre, p.duracion, p.presupuesto,p.fecha_inicio, p.fecha_fin,p.estado From Proyectos As p Inner Join Equipo On idProyecto = proyectoId Inner Join Usuarios On idUsuario = gerente Where idUsuario = @usuario ", cn.getSqlConnection());
                    cmd.Parameters.AddWithValue("@usuario", idU);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(tblData);
                    GridView1.DataSource = (tblData);
                    GridView1.DataBind();
                }
            }
            else
            {
                MessageBox.Show("No tiene permisos validos para entrar");
                Response.Redirect("Inicio.aspx");
            }

            
            
        }
    }
}