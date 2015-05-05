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
        static string baseDatos;
        //Lista de las columnas con sus tipos
        static List<string> Cnombre = new List<string>();
        static List<string> Ctipo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBd_Click(object sender, EventArgs e)
        {
            baseDatos = txtBd.Text;
            try
            {
                lstTablas.Items.Clear();
                chlstCol.Items.Clear();
                LlamarTablas(baseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa base de datos no existe");
            }
        }

        /// <summary>
        /// Se obtiene el nombre de las tablas de 'baseDatos'
        /// </summary>
        public void LlamarTablas(string bd)
        {
            string bDatos = bd;
            Estructura objEst = new Estructura();
            objEst.Sentencia = string.Format("use {0} SELECT name FROM sys.tables", bDatos);
            objEst.Parametros = new SqlParameter[] { };
            objEst.Valores = new List<object>() { };
            objEst.Tabla = "Tablas";

            Operaciones objOp = new Operaciones();
            objOp.Elemento = objEst;

            DataTable tablas = new DataTable();
            tablas = objOp.ObtenerDtt();

            for (int i = 0; i < tablas.Rows.Count; i++)
            {
                lstTablas.Items.Add(tablas.Rows[i]["name"]);
            }
        }

        private void lstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chlstCol.Items.Clear();
            string tabla = lstTablas.SelectedItem.ToString();
            Estructura objEst = new Estructura();
            string bDatos = baseDatos;
            objEst.Sentencia = string.Format("use {0} SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'", bDatos, tabla);
            objEst.Parametros = new SqlParameter[] { };
            objEst.Valores = new List<object>() { };
            objEst.Tabla = "Columnas";

            Operaciones objOp = new Operaciones();
            objOp.Elemento = objEst;

            DataTable columnas = new DataTable();
            columnas = objOp.ObtenerDtt();
            for (int i = 0; i < columnas.Rows.Count; i++)
            {
                Cnombre.Add(columnas.Rows[i]["COLUMN_NAME"].ToString());
                Ctipo.Add(columnas.Rows[i]["DATA_TYPE"].ToString());
            }
            for (int i = 0; i < Cnombre.Count; i++)
            {
                chlstCol.Items.Add(Cnombre[i]);
            }
        }
    }
}
