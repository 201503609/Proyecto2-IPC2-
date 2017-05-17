using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public class Caso
    {
        public String usuario = "";
        public String contraseña = "";
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public static int curso, pre;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        //Ya funciona
        public void crearCaso(string nombre, string fechaLim, int creador, int proyecto, int avance, string descripcion, int editor, int estado, int situacion, int categoria, int prioridad, string fechaEntrega)
        {
            MessageBox.Show("Se creara el caso : " + nombre );
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Caso VALUES(@titulo,@fechaLimite,@creadoPor,@proyectoId,@avance,@descripcion,@editadoPor,@estado,@situacion,@categoria,@prioridad,@fechaEntrega)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@titulo", nombre);
                cmd.Parameters.AddWithValue("@fechaLimite", fechaLim);
                cmd.Parameters.AddWithValue("@creadoPor", creador);
                cmd.Parameters.AddWithValue("@proyectoId", proyecto);
                cmd.Parameters.AddWithValue("@avance", avance);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@editadoPor", editor);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@situacion", situacion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@prioridad", prioridad);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha creado el caso: " + nombre);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el caso: " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el caso: " + exe.ToString());
            }
        }
        //Ya funciona
        public void crearHistorial(int caso, string descripcion, string editor, string estado, string situacion, string categoria, string prioridad, string fechaEntrega, string cambioPor)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Historial VALUES(@caso,@descripcionCaso,@editadoPor, @estado,@situacion,@categoria,@prioridad,@fechaEntrega,@cambioPor)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.Parameters.AddWithValue("@descripcionCaso", descripcion);
                cmd.Parameters.AddWithValue("@editadoPor", editor);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@situacion", situacion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@prioridad", prioridad);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@cambioPor", cambioPor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego al historial del caso");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear historial de el caso: " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear historial de el caso: " + exe.ToString());
            }
        }
        //Ya funciona
        public void editarCaso(int caso, string descripcion, int editor, int estado, int situacion, int categoria, int prioridad, string fechaEntrega)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Caso SET descripcionCaso = @descripcionCaso, editadoPor = @editadoPor, estado = @estado," +
                    " situacion = @situacion, categoria = @categoria, prioridad = @prioridad, fechaEntrega = @fechaEntrega" +
                    " WHERE idCaso = @caso", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@descripcionCaso", descripcion);
                cmd.Parameters.AddWithValue("@editadoPor", editor);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@situacion", situacion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@prioridad", prioridad);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro modificar el caso: ");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro modificar el caso por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar el caso por: " + ex.ToString());
            }
        }
        //Ya funciona
        public void AsignarCaso(int caso, int usuario)
        {//UPDATE A CASO
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Caso SET editadoPor = @editadoPor WHERE idCaso = @caso", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@editadoPor", usuario);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro asignar el caso: ");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro asignar el caso por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro asignar el caso por: " + ex.ToString());
            }
        }
        //Ya funciona
        public void resolverCaso(int caso, int situacion)
        {//UPDATE A CASO EN EL ESTADO y LUEGO A LA SITUACION, INSERT A HISTORIAL
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Caso SET estado = @estado, situacion = @situacion WHERE idCaso = @caso", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@estado", 2);
                cmd.Parameters.AddWithValue("@situacion", situacion);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro resolver el caso");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro resolver el caso por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro resolver el caso por: " + ex.ToString());
            }
        }
        //Ya funciona
        public void cambiarSituacion(int caso, int situacion)
        {//UPDATE A CASO EN SITUACION, INSERT A HISTORIAL
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Caso SET situacion = @situacion WHERE idCaso = @caso", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@situacion", situacion);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro cambiar la situacion del caso");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro cambiar la situacion del caso: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro  cambiar la situacion del caso " + ex.ToString());
            }
        }
        //Ya funciona
        public void reactivarCaso(int caso, int situacion)
        {//UPDATE A CASO EN EL ESTADO y LUEGO A LA SITUACION, INSERT A HISTORIAL
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Caso SET estado = @estado, situacion = @situacion WHERE idCaso = @caso", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@estado", 4);
                cmd.Parameters.AddWithValue("@situacion", situacion);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro reactivar el caso");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro reactivar el caso por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro reactivar el caso por: " + ex.ToString());
            }
        }
 //------------------------A probarlo
        public void cerrarCaso(int caso)
        {//UPDATE A CASO EN EL ESTADO y LUEGO A LA SITUACION, INSERT A HISTORIAL
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Caso SET estado = @estado WHERE idCaso = @caso", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@estado", 3);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro cerrar el caso");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro cerrar el caso por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cerrar el caso por: " + ex.ToString());
            }
        }
        //Ya funciona
        public int obtenerIdCaso(string caso)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Caso WHERE titulo='" + caso + "'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["idCaso"]);
                    pre = Int32.Parse(id);
                }
                else
                {
                    return 0;
                }
                cn.finalizar();
                dr.Close();

                return pre;
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener el id por: " + sqe.ToString());
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener el id por: " + ex.ToString());
                return 0;
            }
            finally
            {
                cn.finalizar();
            }
        }
        //
        public void crearNotificacion(string usuario, string caso)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Notificacion VALUES(@usuario,@caso,@estado)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@caso", caso);
                cmd.Parameters.AddWithValue("@estado", "enviado");
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro notificar al usuario por  " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("No se logro notificar al usuario por " + exe.ToString());
            }
        }

        //Ya funciona
        public ArrayList datosCompletosdeCaso(string titulo)
        {
            try
            {
                ArrayList datos = new ArrayList();
                cn = Conexion.conectar();
                cmd = new SqlCommand("SELECT * FROM Caso WHERE titulo = @titulo", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@titulo", titulo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string nom, feLi, creado, poyecto, avance,desc, editor, estado,situacion,
                        categoria,prioridad,feEn;
                    nom = Convert.ToString(dr["titulo"]);
                    feLi = Convert.ToString(dr["fechaLimite"]);
                    creado = Convert.ToString(dr["creadoPor"]);
                    poyecto = Convert.ToString(dr["proyectoId"]);
                    avance = Convert.ToString(dr["avance"]);
                    desc = Convert.ToString(dr["descripcionCaso"]);
                    editor = Convert.ToString(dr["editadoPor"]);
                    estado = Convert.ToString(dr["estado"]);
                    situacion = Convert.ToString(dr["situacion"]);
                    categoria = Convert.ToString(dr["categoria"]);
                    prioridad = Convert.ToString(dr["prioridad"]);
                    feEn = Convert.ToString(dr["fechaEntrega"]);

                    //--------------------------------------------
                    datos.Add(nom);
                    datos.Add(feLi);
                    datos.Add(creado);
                    datos.Add(poyecto);
                    datos.Add(avance);
                    datos.Add(desc);
                    datos.Add(editor);
                    datos.Add(estado);
                    datos.Add(situacion);
                    datos.Add(categoria);
                    datos.Add(prioridad);
                    datos.Add(feEn);
                }
                return datos;
                cn.finalizar();
                dr.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener datos del proyecto por: " + sqe.ToString());
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener datos del proyecto por: " + ex.ToString());
                return null;
            }
            finally
            {
                cn.finalizar();
            }
        }
        //Ya funciona
        public ArrayList datosEditablesdelCaso(string titulo)
        {
            try
            {
                ArrayList datos = new ArrayList();
                cn = Conexion.conectar();
                cmd = new SqlCommand("SELECT * FROM Caso WHERE titulo = @titulo", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@titulo", titulo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string  desc, editor, estado, situacion,categoria, prioridad, feEn;
                    desc = Convert.ToString(dr["descripcionCaso"]);
                    editor = Convert.ToString(dr["editadoPor"]);
                    estado = Convert.ToString(dr["estado"]);
                    situacion = Convert.ToString(dr["situacion"]);
                    categoria = Convert.ToString(dr["categoria"]);
                    prioridad = Convert.ToString(dr["prioridad"]);
                    feEn = Convert.ToString(dr["fechaEntrega"]);

                    //--------------------------------------------
                    datos.Add(desc);
                    datos.Add(editor);
                    datos.Add(estado);
                    datos.Add(situacion);
                    datos.Add(categoria);
                    datos.Add(prioridad);
                    datos.Add(feEn);
                }
                return datos;
                cn.finalizar();
                dr.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener datos del caso por: " + sqe.ToString());
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener datos del caso por: " + ex.ToString());
                return null;
            }
            finally
            {
                cn.finalizar();
            }
        }

    }
}