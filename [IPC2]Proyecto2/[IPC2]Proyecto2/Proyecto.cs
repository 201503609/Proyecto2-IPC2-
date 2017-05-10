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
    public class Proyecto
    {
        public String usuario = "";
        public String contraseña = "";
        Conexion cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public static int curso, pre;
        SqlDataAdapter sda = null;
        DataTable tblData = new DataTable();

        //Ya Funciona
        public void crearProyecto(string nombre, string fechaIn, string fechaFin, string presupuesto, string duracion, string project)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Proyectos VALUES(@nombre,@fecha_inicio,@fecha_fin,@presupuesto,@duracion,@estado,@PROJECTID)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@fecha_inicio", fechaIn);
                cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);
                cmd.Parameters.AddWithValue("@presupuesto", presupuesto);
                cmd.Parameters.AddWithValue("@duracion", duracion);
                cmd.Parameters.AddWithValue("@PROJECTID", project);
                cmd.Parameters.AddWithValue("@estado", "Activo");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha creado el proyecto: " + nombre);
            }
            catch(SqlException sqe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el proyecto: " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el proyecto: " + exe.ToString());
            }
        }
        //Ya Funciona
        public void modificarProyecto(string nombre, string fechaIn, string fechaFin, string presupuesto, string duracion, string name, string project)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Proyectos SET nombre = @nombre, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, presupuesto = @presupuesto, duracion = @duracion, PROJECTID = @project WHERE nombre = @name", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@fecha_inicio", fechaIn);
                cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);
                cmd.Parameters.AddWithValue("@presupuesto", presupuesto);
                cmd.Parameters.AddWithValue("@duracion", duracion);
                cmd.Parameters.AddWithValue("@project", project);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro modificar el proyecto: " + nombre);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro modificar el proyecto por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar el proyecto por: " + ex.ToString());
            }
        }
        //Ya Funciona
        public ArrayList obtenerDatos(string nombre)
        {
            try
            {
                ArrayList datos = new ArrayList();
                cn = Conexion.conectar();
                cmd = new SqlCommand("SELECT * FROM Proyectos WHERE nombre = @nombre", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string nom, feIn, feFi, presu, dura,pro;
                    nom = Convert.ToString(dr["nombre"]);
                    feIn = Convert.ToString(dr["fecha_inicio"]);
                    feFi = Convert.ToString(dr["fecha_fin"]);
                    presu = Convert.ToString(dr["presupuesto"]);
                    dura = Convert.ToString(dr["duracion"]);
                    pro = Convert.ToString(dr["PROJECTID"]);
                    //--------------------------------------------
                    datos.Add(nom);
                    datos.Add(feIn);
                    datos.Add(feFi);
                    datos.Add(presu);
                    datos.Add(dura);
                    datos.Add(pro);
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
        //Ya Funciona
        public void eliminarProyecto(string nombre)
        {

            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Proyectos SET estado ='inactivo' WHERE nombre = @nombre", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el proyecto  " + nombre);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro eliminar el proyecto por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro eliminar el proyecto por: " + ex.ToString());
            }
            finally
            {
                cn.finalizar();
            }
        }
        //Asignar Gerente
        public void asignarGerente(int proyecto, int usuario)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Equipo(proyectoId,gerente) VALUES(@proyectoId,@gerente)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@gerente", usuario);
                cmd.Parameters.AddWithValue("@proyectoId", proyecto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se asigno gerente al proyecto " + proyecto);
            }
            catch(SqlException sqe)
            {
                MessageBox.Show("no se logro asignar el gerente por: " + sqe.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se logro asignar el gerente por: " + ex.ToString());
            }
        }
        //Verificar Existencia Gerente
        public int existenciaGerente(int proyecto)
        {
            try
            {
                int equipo;
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Equipo WHERE proyectoId =@proyectoId", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@proyectoId", proyecto);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["idEquipo"]);
                    equipo = Int32.Parse(id);
                    return equipo;
                }
                else
                {
                    return 0;
                }
                cn.finalizar();
                dr.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener el id del equipo por: " + sqe.ToString());
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener el id del equipo por: " + ex.ToString());
                return 0;
            }
            finally
            {
                cn.finalizar();
            }
        }
        //Actualizar Gerente
        public void actulizarGerente(int equipo, int gerente)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Equipo SET gerente = @gerente WHERE idEquipo = @idEquipo", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@gerente", gerente);
                cmd.Parameters.AddWithValue("@idEquipo", equipo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro modificar el gerente: ");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("No se logro modificar el gerente por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar el gerente por: " + ex.ToString());
            }
        }
        //Ya Funciona
        public int ObtenerId(string nombre)
        {
            MessageBox.Show("Obtener id de: " + nombre);
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Proyectos WHERE nombre='" + nombre + "'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["idProyecto"]);
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
        //Creo que funciona
        public void asignarTrabajador(int proyecto, int usuario)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Equipo(proyectoId,usuarioId) VALUES(@proyectoId,@usuarioId)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@usuarioId", usuario);
                cmd.Parameters.AddWithValue("@proyectoId", proyecto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se asigno trabajador al proyecto " + proyecto);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro asignar el trabajador por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro asignar el trabajador por: " + ex.ToString());
            }
        }
        //Verificar Existencia Trabajador
        public int existenciaTrabajador(int proyecto, int usuario)
        {
            try
            {
                int equipo;
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Equipo WHERE proyectoId = @proyectoId AND usuarioId = @usuarioId", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@proyectoId", proyecto);
                cmd.Parameters.AddWithValue("@usuarioId", usuario);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["idEquipo"]);
                    equipo = Int32.Parse(id);
                    return equipo;
                }
                else
                {
                    return 0;
                }
                cn.finalizar();
                dr.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener el id del equipo por: " + sqe.ToString());
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener el id del equipo por: " + ex.ToString());
                return 0;
            }
            finally
            {
                cn.finalizar();
            }
        }

        //----------------Implementacion fase3
        //Ya Funciona
        public int ObtenerIdProject(string project)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Proyectos WHERE PROJECTID='" + project + "'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["idProyecto"]);
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
        //Ya funciona
        public string obtenerHoraFecha()
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("select GETDATE() as Fecha", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string fecha;
                    fecha = Convert.ToString(dr["Fecha"]);
                    return fecha;
                }
                else
                {
                    return "";
                }
                cn.finalizar();
                dr.Close();

                return "";
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener la fecha por: " + sqe.ToString());
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener la fecha por: " + ex.ToString());
                return "";
            }
            finally
            {
                cn.finalizar();
            }
        }

    }
}