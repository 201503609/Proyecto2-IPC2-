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
    public partial class CSituacion : System.Web.UI.Page
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
                        txtEstado.Text = iEst(item);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Caso c = new Caso();
            Usuario u = new Usuario();
            string caso = (DropDownList1.Text);
            int idCaso = c.obtenerIdCaso(caso);
            int estado, situacion;
            estado = est(txtEstado.Text);
            situacion = sit(txtNueva.Text);

            if (estado == 1 || estado == 4)
            {
                if (situacion == 9 || situacion == 10 || situacion == 11 || situacion == 12 || situacion == 13)
                {
                    c.cambiarSituacion(idCaso,situacion);
                    c.crearHistorial(idCaso, "", "", txtEstado.Text, txtNueva.Text, "", "", "", Session["usuario"].ToString());
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
                    c.cambiarSituacion(idCaso, situacion);
                    c.crearHistorial(idCaso, "", "", txtEstado.Text, txtNueva.Text, "", "", "", Session["usuario"].ToString());
                }
                else
                {//1 al 8
                    MessageBox.Show("La situacion no es adecuada para el estado");
                }
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
    }
}