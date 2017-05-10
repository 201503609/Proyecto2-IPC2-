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
    public partial class RCasosTotales : System.Web.UI.Page
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
            int idProy, idCate, idPrio, idEstado;
            Proyecto p = new Proyecto();
            idProy = p.ObtenerId(DropDownList1.Text);
            idCate = Int32.Parse(DropDownList2.Text);
            idEstado = Int32.Parse(DropDownList3.Text);
            idPrio = Int32.Parse(DropDownList4.Text);

            if(RadioButton1.Checked && RadioButton2.Checked && RadioButton3.Checked)
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso From Caso as C Where C.proyectoId = @id AND C.estado = @estado AND C.situacion = @situacion AND C.categoria = @categoria", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@estado", idEstado);
                cmd.Parameters.AddWithValue("@situacion", idPrio);
                cmd.Parameters.AddWithValue("@categoria", idCate);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else if (RadioButton1.Checked && RadioButton2.Checked)//Categoria y estado
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id AND C.categoria = @categoria AND C.estado = @estado", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@categoria", idCate);
                cmd.Parameters.AddWithValue("@estado", idEstado);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else if (RadioButton1.Checked && RadioButton3.Checked)//Categoria y situacion
            {
                
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id AND C.categoria = @categoria AND C.situacion = @situacion", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@categoria", idCate);
                cmd.Parameters.AddWithValue("@situacion", idPrio);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else if (RadioButton2.Checked && RadioButton3.Checked)//Estado y situacion
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id AND C.situacion = @situacion AND C.estado = @estado", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@situacion", idPrio);
                cmd.Parameters.AddWithValue("@estado", idEstado);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else if (RadioButton1.Checked)//Solo categoria
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id AND C.categoria = @categoria", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@categoria", idCate);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else if (RadioButton2.Checked)//Solo estado
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id AND C.estado = @estado", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@estado", idEstado);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else if (RadioButton3.Checked)//Solo situacion
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id AND C.situacion = @situacion", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                cmd.Parameters.AddWithValue("@situacion", idPrio);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
            else
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("Select C.titulo, C.fechaLimite, C.fechaEntrega , C.avance, C.descripcionCaso "
                    + " From Caso as C Where C.proyectoId = @id", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@id", idProy);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(tblData);
                GridView1.DataSource = (tblData);
                GridView1.DataBind();
            }
        }
    }
}