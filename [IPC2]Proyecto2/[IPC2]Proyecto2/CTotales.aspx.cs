using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class CTotales : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select idCaso, titulo,fechaLimite,c.creadoPor, p.nombre,avance,descripcionCaso,u.nombre,nombreCate, nombrePrioridad, nombreEstado,nombreSituacion,  fechaEntrega "+
                                    " FROM Caso as c INNER JOIN Proyectos as p ON idProyecto = proyectoId INNER JOIN Usuarios as u ON editadoPor = idUsuario INNER JOIN Categoria " +
                                    "ON c.categoria = idCategoria INNER JOIN Prioridad ON c.prioridad = idPrioridad INNER JOIN Estado On c.estado = idEstado "+
                                    "INNER JOIN Situacion ON c.situacion = idSituacion", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();

            string html = "<html>";
            html += ("<head>\n");
            html += ("<title> Reporte de Casos </title>\n");
            html += ("</head>\n");
            html += "<body>";
            html += ("<center>\n");
            html += ("<h1>CASOS DEL SISTEMA</h1>\n");
            html += ("</center>\n");
            html += "<table  border=2 style = \"margin: 0 auto\">\n";
            //add header row
            html += "<tr>";
                html += ("<th>id</th>\n");
                html += ("<th>Titulo</th>\n");
                html += ("<th>Fecha Limite</th>\n");
                html += ("<th>Creado por</th>\n");
                html += ("<th>id Proyecto</th>\n");
                html += ("<th>Avance</th>\n");
                html += ("<th>Descripcion</th>\n");
                html += ("<th>Editor</th>\n");
                html += ("<th>Estado</th>\n");
                html += ("<th>Situacion</th>\n");
                html += ("<th>Categoria</th>\n");
                html += ("<th>Prioridad</th>\n");
                html += ("<th>Fecha Entrega</th>\n");
            html += "</tr>";
            //add rows
            for (int i = 0; i < tblData.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < tblData.Columns.Count; j++)
                {
                    html += "<td>" + tblData.Rows[i][j].ToString() + "</td>";
                }
                html += "</tr>";
            }
            html += "</table>";
            html += "</body>";
            html += "</html>";

            crear_Archivo(html);


        }

        private void crear_Archivo(string tokens)
        {
            System.IO.StreamWriter archivo = new System.IO.StreamWriter("C:\\HTMLs\\CasosTotalesDelSistema.html");

            archivo.Write(tokens);
            archivo.Close();

        }

    }
}