using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class PCargaMasiva : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            //btnBitacora.Visible = false;
            //DropDownList1.Visible = false;
            //DropDownList2.Visible = false;
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            string path = Convert.ToString(FileUpload1.PostedFile.FileName);
            string pa = FileUpload1.FileName;
            //MessageBox.Show("N " + pa);
            LeerArchivo l = new LeerArchivo();
            l.carga(path,pa);
            l.crear_Archivo(pa);
            btnBitacora.Visible = true;
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
        }

        protected void btnBitacora_Click(object sender, EventArgs e)
        {
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select idBitacora, fechaHora, cantidadProyectos, proyectosCargados, proyectosNCargados  From Bitacora WHERE fechaHora BETWEEN @fecha1 AND @fecha2", cn.getSqlConnection());
            cmd.Parameters.AddWithValue("@fecha1", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@fecha2", DropDownList2.Text);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();
                    
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn = Conexion.conectar();
            cmd = new SqlCommand("Select nombreP, razon  From detalleBitacora WHERE bitacora =@bitacora", cn.getSqlConnection());
            cmd.Parameters.AddWithValue("@bitacora", DropDownList3.Text);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView2.DataSource = (tblData);
            GridView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Process.Start(DropDownList4.Text);
        }
    }
}