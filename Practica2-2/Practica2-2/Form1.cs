﻿using Practica2_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        public Form1()
        {
            InitializeComponent();
            LlamarTablas();
        }
        

        private void lstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chlstCol.Items.Clear();
            tabla = lstTablas.SelectedItem.ToString();
            Campo.LlamarCampos(tabla, baseDatos);
            foreach (Campo camp in Campo.Campos)
            {
                chlstCol.Items.Add(camp.Nombre);
            }
            GenerarQuery(tabla, "tab");
        }

        private void GenerarQuery(string txt, string paso)
        {
            if (paso == "bd")
            {
                query = string.Empty;
                query += "SELECT " + txt;
                lblQuery.Text = query;
            }
            else if (paso == "tab")
            {
                GenerarQuery("*", "bd");
                query += " FROM " + txt;
                lblQuery.Text = query;
            }
            else if (paso == "camp")
            {
                string columnas = string.Empty;

                for (int i = 0; i < Campo.Campos.Count; i++)
                {
                    if (i == 0)
                    {
                        columnas = Campo.Campos[i].Nombre;
                    }
                    else
                    {
                        columnas += "," + Campo.Campos[i].Nombre;
                    }
                }
                query = string.Format("SELECT {0} FROM {1}", columnas, tabla);
                lblQuery.Text = query;
            }
            
        }
        private void LlamarTablas()
        {
            baseDatos = "db_POO";
            try
            {
                lstTablas.Items.Clear();
                chlstCol.Items.Clear();
                Tabla.LlamarTablas(baseDatos);
                for (int i = 0; i < Tabla.Tablas.Count; i++)
                {
                    lstTablas.Items.Add(Tabla.Tablas[i]);
                }
                GenerarQuery("*", "bd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa base de datos no existe");
            }
        }
    }
}
