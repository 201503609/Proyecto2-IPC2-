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
    public partial class CTotales : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            btnReporte.Visible = true;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            cn = Conexion.conectar();
            cmd = new SqlCommand("SELECT * FROM Caso", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();
            btnReporte.Visible = true;

            string html = "<html>";
            html += "</body>";
            html += "<table>";
            //add header row
            html += "<tr>";
            for (int i = 0; i < tblData.Columns.Count; i++)
                html += "<td>" + tblData.Columns[i].ColumnName + "</td>";
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
            html += "</body>";
            html += "</table>";
            html += "</html>";

            crear_Archivo(html);


        }

        protected void btnReporte_Click(object sender, EventArgs e)
        {
            string hola = ConvertDataTableToHTML(tblData);

            crear_Archivo(hola);
        }

        public static string ConvertDataTableToHTML(DataTable dt)
        {
            string html = "<html>";
            html += "</body>";
            html += "<table>";
            //add header row
            html += "<tr>";
            for (int i = 0; i < dt.Columns.Count; i++)
                html += "<td>" + dt.Columns[i].ColumnName + "</td>";
            html += "</tr>";
            //add rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
                }
                html += "</tr>";
            }
            html += "</body>";
            html += "</table>";
            html += "</html>";
            return html;
        }
        private void crear_Archivo(string tokens)
        {
            System.IO.StreamWriter archivo = new System.IO.StreamWriter("C:\\HTMLs\\IPC2.html");

            archivo.Write(tokens);
            archivo.Close();

        }

    }
}