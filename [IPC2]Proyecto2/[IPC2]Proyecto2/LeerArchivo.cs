using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public class LeerArchivo
    {
        public string[] words = new string[6];
        public string pro, work, nom, feIn, feFin, pres;
        public static ArrayList Nombree = new ArrayList();
        public static ArrayList Razoon = new ArrayList();
        public static ArrayList ar = new ArrayList();
        Proyecto p = new Proyecto();
        Usuario u = new Usuario();
        Conexion cn = null;
        SqlCommand cmd = null;
        int counter = 0, cantidadPro = 0, proCarg = 0, proNCarg = 0, idU, idP;
        int pp = 0, uu = 0, gg = 0;

        public void carga(string path, string pa)
        {
            try
            {
                string line;
                string projectID, workerID, nombre, fechaIn, fechaFin, presupuesto;
                char[] delimitador = { ';', ',' };
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    words = line.Split(delimitador);

                    pro = words[0].ToString();
                    work = words[1].ToString();
                    nom = words[2].ToString();
                    feIn = words[3].ToString();
                    feFin = words[4].ToString();
                    pres = words[5].ToString();
                    cantidadPro++;
                    //--limpiando de los espacios al inicio
                    if (pro.StartsWith(" "))
                    {
                        projectID = pro.Substring(1);
                    }
                    else
                    {
                        projectID = pro;
                    }
                    if (work.StartsWith(" "))
                    {
                        workerID = work.Substring(1);
                    }
                    else
                    {
                        workerID = work;
                    }
                    if (nom.StartsWith(" "))
                    {
                        nombre = nom.Substring(1);
                    }
                    else
                    {
                        nombre = nom;
                    }
                    if (feIn.StartsWith(" "))
                    {
                        fechaIn = feIn.Substring(1);
                    }
                    else
                    {
                        fechaIn = feIn;
                    }
                    if (feFin.StartsWith(" "))
                    {
                        fechaFin = feFin.Substring(1);
                    }
                    else
                    {
                        fechaFin = feFin;
                    }
                    if (pres.StartsWith(" "))
                    {
                        presupuesto = pres.Substring(1);
                    }
                    else
                    {
                        presupuesto = pres;
                    }
                    ar.Add(projectID);
                    ar.Add(workerID);
                    ar.Add(nombre);
                    ar.Add(fechaIn);
                    ar.Add(fechaFin);
                    ar.Add(presupuesto);
                    //-----------------------------------------------------------------Validaciones
                    //Validar ProjectID
                    if (projectID.Length > 0 && projectID.Length < 21)
                    {
                        //Validar WorkerID
                        if (workerID.Length > 0 && workerID.Length < 21)
                        {
                            //Nombre no necesita  validacion
                            //validar fecha inicio
                            if (fechaIn.Length !=10 || (fechaIn.Substring(2,3) != "/") || (fechaIn.Substring(5,6) != "/") || 
                                (Int32.Parse(fechaIn.Substring(0,2)) > 31) || (Int32.Parse(fechaIn.Substring(3,5)) > 12) ||
                                (Int32.Parse(fechaIn.Substring(6,10)) < 2012))
                            {
                                //validar fecha fin
                                if (fechaFin.Length != 10 || (fechaFin.Substring(2, 3) != "/") || (fechaFin.Substring(5, 6) != "/") ||
                                    (Int32.Parse(fechaFin.Substring(0, 2)) > 31) || (Int32.Parse(fechaFin.Substring(3, 5)) > 12) ||
                                    (Int32.Parse(fechaFin.Substring(6, 10)) < 2012) || (Int32.Parse(fechaIn.Substring(6, 10)) > Int32.Parse(fechaFin.Substring(6, 10))))
                                {
                                    //validar presupuesto
                                    if (IsNumeric(presupuesto) && (Double.Parse(presupuesto) > 0))
                                    {
                                        DialogResult result = MessageBox.Show("¿Desea cargar la siguiente informacion? "
                                            + "projectID: " + projectID + " workerID: " + workerID + " nombre: " + nombre +
                                            " fecha Inicio: " + fechaIn + " Fecha Fin: " + fechaFin + " Presupuesto: " + presupuesto, "Cargar", MessageBoxButtons.YesNo);
                                        if (result == DialogResult.Yes)
                                        {
                                            cargarArchivo(projectID, workerID, nombre, fechaIn, fechaFin, presupuesto);
                                        }
                                        else
                                        {
                                            Nombree.Add(nombre);
                                            Razoon.Add("El usuario eligio no cargar el projecto");
                                            proNCarg++;
                                        }

                                    }
                                    else
                                    {
                                        Nombree.Add(nombre);
                                        Razoon.Add("Existe problema con el presupuesto");
                                        proNCarg++;
                                    }
                                }
                                else
                                {
                                    Nombree.Add(nombre);
                                    Razoon.Add("La fecha de fin no cumple con el formato valido, revisarla");
                                    proNCarg++;
                                }
                            }
                            else
                            {
                                Nombree.Add(nombre);
                                Razoon.Add("La fecha de inicio no cumple con el formato valido");
                                proNCarg++;
                            }
                        }
                        else
                        {
                            Nombree.Add(nombre);
                            Razoon.Add("La longitud del WorkerId es la incorrecta");
                            proNCarg++;
                        }
                    }
                    else
                    {
                        Nombree.Add(nombre);
                        Razoon.Add("La longitud del ProjectID es la incorrecta");
                        proNCarg++;
                    }
                    counter++;
                }
                file.Close();
                string fe = p.obtenerHoraFecha();
                string pa1 = "C:\\ArchivosBack\\" + pa;
                crearBitacora(fe, cantidadPro, proCarg, proNCarg, pa1);
                int id = obtenerIdBita(fe);
                string n, d;
                for (int i = 0; i < Nombree.Count; i++)
                {
                    n = Nombree[i].ToString();
                    d = Razoon[i].ToString();
                    crearDetalle(n, d, id);
                }
            }
            catch (SqlException sq)
            {
                MessageBox.Show("No se logro realizar la carga por: " + sq.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message);
            }
        }

        private void cargarArchivo(string projectID, string workerID, string nombre, string fechaIn, string fechaFin, string presupuesto)
        {
            pp = p.ObtenerIdProject(projectID);
            uu = u.ObtenerIdWorker(workerID);
            if (pp == 0)
            {
                //-----------------insertar proyecto
                p.crearProyecto(nombre, fechaIn, fechaFin, presupuesto, "", projectID);
                proCarg++;
                if (uu != 0)
                {
                    gg = p.existenciaGerente(pp);
                    if (gg == 0)
                    {
                        //-----------------insertar gerente
                        idU = u.ObtenerIdWorker(workerID);
                        idP = p.ObtenerIdProject(projectID);
                        p.asignarGerente(idP, idU);
                        Nombree.Add(nombre);
                        Razoon.Add("El proyecto se cargo exitosamente");
                    }
                    else
                    {
                        Nombree.Add(nombre);
                        Razoon.Add("El proyecto se cargo pero no se agrego el gerente");
                        MessageBox.Show("El proyecto ya posee gerente");
                    }
                }
                else
                {
                    Nombree.Add(nombre);
                    Razoon.Add("El proyecto se cargo pero no se agrego el gerente");
                    MessageBox.Show("No existe el gerente");
                }
            }
            else
            {
                Nombree.Add(nombre);
                Razoon.Add("El proyecto ya existia");
                MessageBox.Show("Ya existe el proyecto");
                proNCarg++;
            }
        }

        private void crearBitacora(string fe, int cantidadPro, int proCarg, int proNCarg, string path)
        {
            //MessageBox.Show("Fecha: " + fe + "cantidad de proyectos: " + cantidadPro.ToString());
            //MessageBox.Show("Proyectos Cargados : " + proCarg.ToString() + " Proyectos no cargados: " + proNCarg.ToString() + " direccion: " + path );
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO Bitacora Values (@fechaHora,@cantidadProyectos,@proyectosCargados,@ProyectosNCargados,@ubicacion)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@fechaHora", fe);
                cmd.Parameters.AddWithValue("@cantidadProyectos", cantidadPro);
                cmd.Parameters.AddWithValue("@proyectosCargados", proCarg);
                cmd.Parameters.AddWithValue("@proyectosNCargados", proNCarg);
                cmd.Parameters.AddWithValue("@ubicacion", path);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha creado la bitacora ");
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear la bitacora: " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear el curso: " + exe.ToString());
            }
        }

        private void crearDetalle(string nombre, string razon, int id)
        {
            try
            {
                cn = Conexion.conectar();
                cmd = new SqlCommand("INSERT INTO detalleBitacora Values (@nombreP,@razon,@bitacora)", cn.getSqlConnection());
                cmd.Parameters.AddWithValue("@nombreP", nombre);
                cmd.Parameters.AddWithValue("@razon", razon);
                cmd.Parameters.AddWithValue("@bitacora", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear la Dbitacora: " + sqe.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio el siguiente problema al crear la Dbitacora: " + exe.ToString());
            }
        }

        private int obtenerIdBita(string fe)
        {
            try
            {
                int iid = 0;
                cn = Conexion.conectar();
                cmd = new SqlCommand("select * from Bitacora WHERE fechaHora='" + fe + "'", cn.getSqlConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    string id;
                    id = Convert.ToString(dr["idBitacora"]);
                    iid = Int32.Parse(id);
                }
                else
                {
                    return 0;
                }
                cn.finalizar();
                dr.Close();
                return iid;
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("no se logro obtener el idBitacora por: " + sqe.ToString());
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro obtener el idBitacora por: " + ex.ToString());
                return 0;
            }
            finally
            {
                cn.finalizar();
            }
        }

        public bool IsNumeric(object Expression)

        {

            bool isNum;

            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;

        }

        public void crear_Archivo(string nombre)
        {
            System.IO.StreamWriter archivo = new System.IO.StreamWriter("C:\\ArchivosBack\\" + nombre);

            int i = 0;
            int div;
            foreach (string item in ar)
            {
                i++;
                div = i % 6;
                if (div == 0)
                {
                    archivo.Write(item + "\r\n");
                }
                else
                {
                    archivo.Write(item + ",");
                }
            }
            archivo.Close();

        }




    }
}