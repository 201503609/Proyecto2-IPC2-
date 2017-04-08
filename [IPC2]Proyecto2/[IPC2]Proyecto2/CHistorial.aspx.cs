using System;
using System.Collections;
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
    public partial class CHistorial : System.Web.UI.Page
    {
        ArrayList desc, editor, estado, situacion = new ArrayList();
        ArrayList cateo, priori, feEn, cambPor = new ArrayList();
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
            historialL();
            
        }

        public void historialL()
        {
            Caso c = new Caso();
            int idCaso = c.obtenerIdCaso(DropDownList1.Text);
            cn = Conexion.conectar();
            cmd = new SqlCommand("SELECT * FROM Historial WHERE caso = @caso", cn.getSqlConnection());
            cmd.Parameters.AddWithValue("@caso", idCaso);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();
        }


    }
}