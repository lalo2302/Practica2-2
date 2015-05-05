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

        private void lstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {






        //    private void cmbTbl_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SqlDataReader dr = null;
        //    string cons_COLs = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tabla";

        //    try
        //    {
        //        string basedatos = cmbBD.SelectedItem.ToString();
        //        string tabla = cmbTbl.SelectedItem.ToString();
        //        string cadenaCon = "Data Source=.;Initial Catalog=" + basedatos + ";Integrated Security=True";
        //        SqlConnection con = new SqlConnection(cadenaCon);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(cons_COLs, con);
        //        cmd.Parameters.Add(new SqlParameter("tabla", tabla));
        //        dr = cmd.ExecuteReader();
        //        cmbCol.Items.Clear();
        //        while (dr.Read())
        //        {
        //            string temp = dr.GetString(0);
        //            cmbCol.Items.Add(dr.GetString(0));
        //        }
        //        dr.Dispose();
        //        con.Close();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        throw;
        //    }
        //}
        }
    }
}
