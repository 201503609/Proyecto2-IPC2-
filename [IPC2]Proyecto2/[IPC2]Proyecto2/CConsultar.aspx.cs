using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto2
{
    public partial class CConsultar : System.Web.UI.Page
    {
        Conexion cn = null;
        SqlCommand cmd= null;
        SqlDataAdapter sda= null;
        DataTable tblData = new DataTable();
        DataTable tblData1 = new DataTable();
        DataTable tblData2 = new DataTable();
        DataTable tblData3 = new DataTable();
        DataTable tblData4 = new DataTable();
        DataTable tblData5 = new DataTable();
        DataTable tblData6 = new DataTable();
        DataTable tblData7 = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Proyecto p = new Proyecto();
            //int proId = p.ObtenerId(DropDownList1.Text);
            Caso c = new _IPC2_Proyecto2.Caso();
            ArrayList carga = new ArrayList();
            carga = c.datosCompletosdeCaso(DropDownList1.Text);

            cn = Conexion.conectar();
            cmd = new SqlCommand("SELECT * FROM Caso Where titulo ='"+ DropDownList1.Text+"'", cn.getSqlConnection());
            sda = new SqlDataAdapter(cmd);
            sda.Fill(tblData);
            GridView1.DataSource = (tblData);
            GridView1.DataBind();
            cn.finalizar();
            int i =0 ;
            foreach (string item in carga)
            {
                switch (i)
                {
                    case 2:
                        //Creador
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Usuarios Where idUsuario ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData1);
                        GridView2.DataSource = (tblData1);
                        GridView2.DataBind();
                        break;
                    case 3:
                        //Datos Proyecto
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Proyectos Where idProyecto ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData2);
                        GridView3.DataSource = (tblData2);
                        GridView3.DataBind();
                        break;
                    case 6:
                        //Datos del editor
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Usuarios Where idUsuario ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData3);
                        GridView4.DataSource = (tblData3);
                        GridView4.DataBind();
                        break;
                    case 7:
                        //estado
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Estado Where idEstado ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData4);
                        GridView7.DataSource = (tblData4);
                        GridView7.DataBind();
                        break;
                    case 8:
                        //situacion
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Situacion Where idSituacion ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData5);
                        GridView8.DataSource = (tblData5);
                        GridView8.DataBind();
                        break;
                    case 9:
                        //Categoria
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Categoria Where idCategoria ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData6);
                        GridView5.DataSource = (tblData6);
                        GridView5.DataBind();
                        break;
                    case 10:
                        //Prioridad
                        cn = Conexion.conectar();
                        cmd = new SqlCommand("SELECT * FROM Prioridad Where idPrioridad ='" + item + "'", cn.getSqlConnection());
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(tblData7);
                        GridView6.DataSource = (tblData7);
                        GridView6.DataBind();
                        break;
                }
                i++;
            }
            //Creador
            //Proyecto
            //Ultimo Editor
            //Estado
            //Situacion
            //Categoria
            //Prioridad

        }

        private string iPri(string item)
        {
            if (item == "1")
            {
                return "Critica";
            }
            else if (item == "2")
            {
                return "Debe arreglarse";
            }
            else if (item == "3")
            {
                return "Arreglar si hay tiempo";
            }
            else if (item == "4")
            {
                return "No arreglar";
            }
            else
            {
                return item;
            }
        }

        private string iCat(string item)
        {
            if (item == "1")
            {
                return "Bug";
            }
            else if (item == "2")
            {
                return "Mejora";
            }
            else if (item == "3")
            {
                return "Investigacion";
            }
            else if (item == "4")
            {
                return "Actividad";
            }
            else
            {
                return item;
            }
        }

        private string iSit(string item)
        {
            if (item == "1")
            {
                return "Listo para prueba";
            }
            else if (item == "2")
            {
                return "Implementado";
            }
            else if (item == "3")
            {
                return "Duplicado";
            }
            else if (item == "4")
            {
                return "Por diseño";
            }
            else if (item == "5")
            {
                return "Arreglado";
            }
            if (item == "6")
            {
                return "No reproducible";
            }
            else if (item == "7")
            {
                return "Post puesto";
            }
            else if (item == "8")
            {
                return "No se arreglara";
            }
            else if (item == "9")
            {
                return "Necesita estimacion de tiempo";
            }
            else if (item == "10")
            {
                return "Estimacion de tiempo aprobada";
            }
            else if (item == "11")
            {
                return "En desarrollo";
            }
            else if (item == "12")
            {
                return "Arreglado";
            }
            else
            {
                return "Necesita informacion";
            }
        }

        private string iEst(string item)
        {
            if (item == "1")
            {
                return "Activo";
            }
            else if (item == "2")
            {
                return "Resuelto";
            }
            else if (item == "3")
            {
                return "Cerrado";
            }
            else if (item == "4")
            {
                return "Reactivado";
            }
            else
            {
                return item;
            }
        }

    }
}