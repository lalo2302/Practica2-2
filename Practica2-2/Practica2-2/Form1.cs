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
            LlamarTablas();
        }
        /// <summary>
        /// Se obtiene el nombre de las tablas de 'baseDatos'
        /// </summary>
        public void LlamarTablas()
        {
            Estructura objEst = new Estructura();
            string baseDatos = "db_POO";
            objEst.Sentencia = string.Format("use {0} SELECT name FROM sys.tables", baseDatos);
            objEst.Parametros = new SqlParameter[]{};
            objEst.Valores = new List<object>() {};
            objEst.Tabla = "Tablas";

            Operaciones objOp = new Operaciones();
            objOp.Elemento = objEst;

            DataTable tablas = new DataTable();
            tablas = objOp.ObtenerDtt();
        }
    }
}
