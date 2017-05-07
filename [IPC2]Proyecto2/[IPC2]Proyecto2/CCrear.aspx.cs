using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class CCrear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null || Session["pass"] != null || Session["usuario"] != null)
            {

            }
            else
            {
                MessageBox.Show("No tiene permisos validos para entrar");
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Caso c = new Caso();
            Proyecto p = new Proyecto();
            Usuario u = new Usuario();
            int categoria, prioridad, estado, situacion,proyecto,creador,editor;
            categoria = cate(txtCategoria.Text);
            prioridad = priori(txtPrioridad.Text); 
            estado = est(txtEstado.Text);
            situacion = sit(txtSituacion.Text);
            proyecto = p.ObtenerId(DropDownList1.Text);
            editor = u.ObtenerId(DropDownList2.Text);
            creador = u.ObtenerId(Session["usuario"].ToString());

            int proye = p.existenciaTrabajador(proyecto, editor);
            if (proye != 0)
            {
                if (categoria == 0 || prioridad == 0 || estado == 0 || situacion == 0)
                {
                    MessageBox.Show("Revisar Valores");
                }
                else
                {
                    if (estado == 1 || estado == 4)
                    {
                        if (situacion == 9 || situacion == 10 || situacion == 11 || situacion == 12 || situacion == 13)
                        {
                            if (editor != 0)
                            {
                                c.crearCaso(txtTitulo.Text, txtFechaLim.Text, creador, proyecto, Int32.Parse(txtAvance.Text), txtDesc.Text, editor, estado, situacion, categoria, prioridad, txtFechaEnt.Text);
                                int idCaso = c.obtenerIdCaso(txtTitulo.Text);
                                c.crearHistorial(idCaso, txtDesc.Text, DropDownList2.Text, txtEstado.Text, txtSituacion.Text, txtCategoria.Text, txtPrioridad.Text, txtFechaEnt.Text, Session["usuario"].ToString());
                                c.crearNotificacion(DropDownList2.Text, "Se te ha asignado al caso " + txtTitulo.Text);
                            }
                            else
                            {
                                MessageBox.Show("El usuario debe estar asignado al proyecto");
                            }

                        }
                        else
                        {//9 al 13
                            MessageBox.Show("La situacion no es adecuada para el estado");
                        }
                    }
                    else if (estado == 2)
                    {
                        if (situacion >= 1 || situacion <= 8)
                        {
                            if (editor != 0)
                            {
                                c.crearCaso(txtTitulo.Text, txtFechaLim.Text, creador, proyecto, Int32.Parse(txtAvance.Text), txtDesc.Text, editor, estado, situacion, categoria, prioridad, txtFechaEnt.Text);
                                int idCaso = c.obtenerIdCaso(txtTitulo.Text);
                                c.crearHistorial(idCaso, txtDesc.Text, DropDownList2.Text, txtEstado.Text, txtSituacion.Text, txtCategoria.Text, txtPrioridad.Text, txtFechaEnt.Text, Session["usuario"].ToString());
                                c.crearNotificacion(DropDownList2.Text, "Se te ha asignado al caso " + txtTitulo.Text);
                            }
                            else
                            {
                                MessageBox.Show("El usuario debe estar asignado al proyecto");
                            }
                        }
                        else
                        {//1 al 8
                            MessageBox.Show("La situacion no es adecuada para el estado");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("El trabajador debe estar asignado al proyecto");
            }

           
        }

        private int sit(string text)
        {
            //RESUELTO
            if (text == "Listo para Pruebas")
            {
                return 1;
            }
            else if (text == "Implementado")
            {
                return 2;
            }
            else if (text == "Duplicado")
            {
                return 3;
            }
            else if (text == "Por diseño")
            {
                return 4;
            }
            else if (text == "Arreglado")
            {
                return 5;
            }
            else if (text == "No reproducible")
            {
                return 6;
            }
            else if (text == "Post puesto")
            {
                return 7;
            }
            else if (text == "No se arreglara" || text == "No se arreglará")
            {
                return 8;
            }
            //ACTIVO O REACTIVADO
            else if (text == "Necesita estimacion de tiempo")
            {
                return 9;
            }
            else if (text == "Estimacion de tiempo aprovada")
            {
                return 10;
            }
            else if (text == "En desarrollo")
            {
                return 11;
            }
            else if (text == "Arreglado")
            {
                return 12;
            }
            else if (text == "Necesita informacion")
            {
                return 13;
            }
            //NADA
            else
            {
                MessageBox.Show("Estado no valido o no existente");
                return 0;
            }
        }

        private int est(string text)
        {
            if (text == "Activo")
            {
                return 1;
            }
            else if (text  == "Resuelto")
            {
                return 2;
            }
            else if (text == "Cerrado")
            {
                return 3;
            }
            else if (text == "Reactivado")
            {
                return 4;
            }
            else
            {
                MessageBox.Show("Estado no valido o no existente");
                return 0;
            }
        }

        private int cate(string cat)
        {
            if (cat == "Bug")
            {
                return 1;
            }
            else if (cat == "Mejora")
            {
                return 2;
            }
            else if (cat =="Investigacion" || cat == "Investigación")
            {
                return 3;
            }
            else if (cat == "Actividad")
            {
                return 4;
            }
            else
            {
                MessageBox.Show("Categoria no valida o no existente");
                return 0;
            }
        }

        private int priori(string pri)
        {
            if (pri == "Critica" || pri == "Crítica")
            {
                return 1;
            }
            else if (pri == "Debe arreglarse")
            {
                return 2;
            }
            else if (pri == "Arreglar si hay tiempo")
            {
                return 3;
            }
            else if (pri == "No arreglar")
            {
                return 4;
            }
            else
            {
                MessageBox.Show("Prioridad no valida o no existente");
                return 0;
            }
        }

    }
}