﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace _IPC2_Proyecto2
{
    public partial class CResolver : System.Web.UI.Page
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
            ArrayList carga = new ArrayList();
            carga = c.datosEditablesdelCaso(DropDownList1.Text);
            int i = 0;
            Usuario u = new Usuario();
            foreach (string item in carga)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        txtEstadoV.Text = iEst(item);
                        break;
                    case 3:
                        txtSituacion.Text = iSit(item);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
                i++;
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

        protected void btnResolver_Click(object sender, EventArgs e)
        {
            Caso c = new Caso();
            Usuario u = new Usuario();
            string caso = (DropDownList1.Text);
            int idCaso = c.obtenerIdCaso(caso);
            int estado, situacion;
            estado = 2;
            situacion = sit(DropDownList2.Text);

            if (estado == 0 || situacion == 0)
            {
                MessageBox.Show("Revisar Valores");
            }
            else
            {
                if (estado == 2)
                {
                    if (situacion >= 1 || situacion <= 8)
                    {
                        c.resolverCaso(idCaso,situacion);
                        c.crearHistorial(idCaso, "", "", "Resuelto", DropDownList2.Text, "", "", "", Session["usuario"].ToString());
                    }
                    else
                    {//1 al 8
                        MessageBox.Show("La situacion no es adecuada para el estado");
                    }
                }
            }
        }

        private int sit(string text)
        {
            //RESUELTO
            if (text == "Listo para pruebas")
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
            else if (text == "Arregladoo")
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
            else if (text == "Resuelto")
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
            else if (cat == "Investigacion" || cat == "Investigación")
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

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}