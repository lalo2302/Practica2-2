using Practica2_2.Clases;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void lstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBd_Click(object sender, EventArgs e)
        {
            string baseDatos = txtBd.Text;
            try
            {
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
            string baseDatos = bd;
            Estructura objEst = new Estructura();
            objEst.Sentencia = string.Format("use {0} SELECT name FROM sys.tables", baseDatos);
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
            string tabla = lstTablas.SelectedItem.ToString();
            Estructura objEst = new Estructura();
            string baseDatos = "db_POO";
            objEst.Sentencia = string.Format("use {0} SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'", baseDatos, tabla);
            objEst.Parametros = new SqlParameter[] { };
            objEst.Valores = new List<object>() { };
            objEst.Tabla = "Columnas";

            Operaciones objOp = new Operaciones();
            objOp.Elemento = objEst;

            DataTable columnas = new DataTable();
            columnas = objOp.ObtenerDtt();

            for (int i = 0; i < columnas.Rows.Count; i++)
            {
                chlstCol.Items.Add(columnas.Rows[i]["COLUMN_NAME"]);
            }
        }
    }
}
