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
    public class Usuario
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
        public void crearUsuario(string correo,string contraseña,string nombre,string apellido, string fecha, string direccion, int telefono, int rol)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Usuarios Values (@correo,@contraseña,@nombre,@apellido,@fecha_nacimiento,@direccion,@telefono,@estado,@rol)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@correo",correo);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@estado", "activo");
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha creado el usuario: " + correo);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el curso: " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el curso: " + exe.ToString());
            }
        }
        //Ya funciona
        public int ObtenerRol(string usuario, string contraseña)
        {
            MessageBox.Show("Obtener rol de: " + usuario + " " + contraseña);
            try
            {
                Console.WriteLine(usuario);
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Usuarios WHERE correo='" + usuario + "' AND contraseña = '" + contraseña + "' AND estado = 'activo'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["rol"]);
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
        public void eliminarUsuario(string correo)
        {

            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Usuarios SET estado ='inactivo' WHERE correo = @correo", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el usuario  " + correo);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro eliminar el usuario por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro eliminar el usuario por: " + ex.ToString());
            }
            finally
            {
                cn.finalizar();
            }
        }
        //Ya funciona
        public void cambiarRol(string correo, int rol)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Usuarios SET rol =@rol WHERE correo = @correo", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se cambio el rol de: " + correo);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro cambiar el rol del usuario por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro cambiar el rol del usuario por: " + ex.ToString());
            }
            finally
            {
                cn.finalizar();
            }
        }
        //Ya funciona
        public void modificarUsuario(string correo, string contraseña, string nombre, string apellido, string fecha, string direccion, int telefono, string usuario)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Usuarios SET correo = @correo, contraseña = @contraseña, nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha_nacimiento, direccion = @direccion, telefono = @telefono WHERE correo = @usuario", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se logro modificar el usuario: " + correo);
            }
            catch(SqlException sqe)
            {
                MessageBox.Show("No se logro modificar el usuario por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar el usuario por: " + ex.ToString());
            }
        }
        //Ya funciona
        public ArrayList obtenerDatos(string correo)
        {
            try
            {
                ArrayList datos = new ArrayList();
                cn = Conexion.conectar();
                cmd = new SqlCommand("SELECT * FROM Usuarios WHERE correo = @correo", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@correo", correo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string co, con, nom, ape, fecha, direc,tel;
                    co = Convert.ToString(dr["correo"]);
                    con = Convert.ToString(dr["contraseña"]);
                    nom = Convert.ToString(dr["nombre"]);
                    ape = Convert.ToString(dr["apellido"]);
                    fecha = Convert.ToString(dr["fecha_nacimiento"]);
                    direc = Convert.ToString(dr["direccion"]);
                    tel = Convert.ToString(dr["telefono"]);
                    //--------------------------------------------
                    datos.Add(co);
                    datos.Add(con);
                    datos.Add(nom);
                    datos.Add(ape);
                    datos.Add(fecha);
                    datos.Add(direc);
                    datos.Add(tel);
                }
                return datos;
                cn.finalizar();
                dr.Close();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener datos del usuario por: " + sqe.ToString());
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener datos del usuario por: " + ex.ToString());
                return null;
            }
            finally
            {
                cn.finalizar();
            }
        }
        //Ya funciona
        public int ObtenerId(string usuario)
        {
            MessageBox.Show("Obtner el id de " + usuario);
            try
            { 
                int iid = 0;
                Console.WriteLine(usuario);
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Usuarios WHERE correo='" + usuario +"'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    string id;
                    id = Convert.ToString(dr["idUsuario"]);
                    iid = Int32.Parse(id);
                }
                else
                {
                    return 0;
                }
                cn.finalizar();
                dr.Close();
                MessageBox.Show("El id de " + usuario + " es " + iid.ToString());
                return iid;
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
        public string ObtenerCorreo(int id)
        {
            try
            {
                Console.WriteLine(usuario);
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Usuarios WHERE idUSuario='" + id + "'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string correo;
                    correo = Convert.ToString(dr["correo"]);
                    return correo;
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
                MessageBox.Show("no se logro obtener el id por: " + sqe.ToString());
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener el id por: " + ex.ToString());
                return "";
            }
            finally
            {
                cn.finalizar();
            }


        }
        //TYa funciona
        public int ObtenerRo(string usuario)
        {
            MessageBox.Show("Obtener rol de: " + usuario);
            try
            {
                Console.WriteLine(usuario);
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Usuarios WHERE correo='" + usuario + "' AND estado = 'activo'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string id;
                    id = Convert.ToString(dr["rol"]);
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
        public string recordarContra(string correo, string fecha, int tel)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Usuarios WHERE correo=@correo AND fecha_nacimiento=@fecha AND telefono = @telefono", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@telefono", tel);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string pass;
                    pass = Convert.ToString(dr["contraseña"]);
                    return pass;
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
                MessageBox.Show("no se logro obtener la contraseña por: " + sqe.ToString());
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener el id por: " + ex.ToString());
                return "";
            }
            finally
            {
                cn.finalizar();
            }
        }
        //a probar
        public void cambiarContra(string correo, string vieja,string nueva)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("UPDATE Usuarios SET contraseña =@contra WHERE correo = @correo AND contraseña = @contraseña", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@contra", nueva);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contraseña", vieja);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se cambio la contraseña de: " + correo);
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro cambiar la contraseña del usuario por: " + sqe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro cambiar la contraseña usuario por: " + ex.ToString());
            }
            finally
            {
                cn.finalizar();
            }
        }
    }
}