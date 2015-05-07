﻿using Practica2_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_2
{
    public partial class Form1 : Form
    {
        Campo Campo = new Campo();
        Tabla Tabla = new Tabla();
        static string baseDatos;
        static string tabla;
        static string query = "";
        static string queryParam = "";
        static int filtroCount = 0;
        static string columnas;
        static string filtros;
        static string filtrosParam;
        static List<string> param = new List<string>();
        public Form1()
        {
            InitializeComponent();
            LlamarTablas();
        }
        

        private void lstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTablas.SelectedIndex != -1)
            {
                tabla = lstTablas.SelectedItem.ToString();
                Campo.LlamarCampos(tabla, baseDatos);

                lblCampo1.Text = Campo.Campos[0].Nombre;
                lblCampo2.Text = Campo.Campos[1].Nombre;
                lblCampo3.Text = Campo.Campos[2].Nombre;
                lblCampo4.Text = Campo.Campos[3].Nombre;

                GenerarQuery(tabla);
            }
        }

        private void GenerarQuery(string txt)
        {
            if (lblCampo1.Text != "[Campo]")
            {
                columnas = String.Empty;
                filtros = String.Empty;
                int count = 0;
                
                    if (check1.Checked)
                    {
                        columnas = lblCampo1.Text;
                        if (txt1.Text != String.Empty)
                        {
                            filtros = "WHERE " + lblCampo1.Text + " > " + txt1.Text;
                            filtrosParam = "WHERE " + lblCampo1.Text + " > @id ";
                            param.Add("id");

                        }
                        count++;
                    }
                    if (check2.Checked)
                    {
                        if (count == 0)
                        {
                            if (txt2.Text != String.Empty)
                            {
                                filtros = "WHERE " + lblCampo2.Text + " LIKE '%" + txt2.Text + "%'";
                                filtrosParam = "WHERE " + lblCampo2.Text + " LIKE '%@nombre%'";
                                param.Add("nombre");
                            }

                            columnas = lblCampo2.Text;
                        }
                        else
                        {
                            if (txt2.Text != String.Empty) {
                                filtros += " AND " + lblCampo2.Text + " LIKE '%" + txt2.Text + "%'";
                                filtrosParam += " AND " + lblCampo2.Text + " LIKE '%@nombre%'";
                                param.Add("nombre");
                                }

                            columnas += ", " + lblCampo2.Text;
                        }
                        count++;
                    }
                    if (check3.Checked)
                    {
                        if (count == 0)
                        {
                            if (txt3.Text != String.Empty)
                            {
                                filtros = "WHERE " + lblCampo3.Text + " = " + txt3.Text;
                                filtrosParam = "WHERE " + lblCampo3.Text + " = @marca";
                                param.Add("marca");
                            }

                            columnas = lblCampo3.Text;
                        }
                        else
                        {
                            if (txt3.Text != String.Empty)
                            {
                                filtros += " AND " + lblCampo3.Text + " = " + txt3.Text;
                                filtrosParam += " AND " + lblCampo3.Text + " = @marca";
                                param.Add("marca");
                            }

                            columnas += ", " + lblCampo3.Text;
                        }
                        count++;
                    }
                    if (check4.Checked)
                    {
                        if (count == 0)
                        {
                            if (txt4.Text != String.Empty)
                            {
                                filtros = "WHERE " + lblCampo4.Text + " LIKE '%" + txt4.Text + "'";
                                filtrosParam = "WHERE " + lblCampo4.Text + " LIKE '%@color'";
                                param.Add("color");
                            }

                            columnas = lblCampo4.Text;
                        }
                        else
                        {
                            if (txt4.Text != String.Empty)
                            {
                                filtros += " AND " + lblCampo4.Text + " LIKE '%" + txt4.Text + "'";
                                filtrosParam += " AND " + lblCampo4.Text + " LIKE '%@color'";
                                param.Add("color");
                            }

                            columnas += ", " + lblCampo4.Text;
                        }
                        count++;
                    }
                    if (!(filtroCount != 0 && filtroCount != 4))
                        columnas = "*";

                query = string.Format("SELECT {0} FROM {1} {2}", columnas, tabla, filtros);
                queryParam = string.Format("SELECT {0} FROM {1} {2}", columnas, tabla, filtros);
                lblQuery.Text = query;
            }

            
        }
        private void LlamarTablas()
        {
            baseDatos = "db_Practica22";
            try
            {
                lstTablas.Items.Clear();
                Tabla.LlamarTablas(baseDatos);
                for (int i = 0; i < Tabla.Tablas.Count; i++)
                {
                    lstTablas.Items.Add(Tabla.Tablas[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa base de datos no existe");
            }
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked)
                filtroCount++;
            else
                filtroCount--;

            GenerarQuery(tabla);
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (check2.Checked)
                filtroCount++;
            else
                filtroCount--;

            GenerarQuery(tabla);
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if (check3.Checked)
                filtroCount++;
            else
                filtroCount--;

            GenerarQuery(tabla);
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked)
                filtroCount++;
            else
                filtroCount--;

            GenerarQuery(tabla);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            
        }

        private Estructura FormarEstructura()
        {
            Estructura objEst = new Estructura();
            objEst.Sentencia = queryParam;
            objEst.Parametros = new SqlParameter[filtroCount];

            for (int i = 0; i < filtroCount; i++)
            {
                if (param[i].Contains("id"))
                {
                    objEst.Parametros[i] = new SqlParameter(param[i], SqlDbType.Int);
                }
                else
                {
                    objEst.Parametros[i] = new SqlParameter(param[i], SqlDbType.NVarChar, 50);
                }
            }
            

            return objEst;
        }
    }
}
