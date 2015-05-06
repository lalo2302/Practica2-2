using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Practica2_2.Clases
{
    public class Campo
    {
        private static List<Campo> campos = new List<Campo>();

        public static List<Campo> Campos
        {
            get { return Campo.campos; }
            set { Campo.campos = value; }
        }

        #region ATRIBUTOS
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private List<string> filtros = new List<string>();

        public List<string> Filtros
        {
            get { return filtros; }
            set { filtros = value; }
        }
        #endregion

        #region CONSTRUCTORES
        public Campo()
        {

        }
        public Campo(string nom, string tip)
        {
            nombre = nom;
            tipo = tip;
        }
        #endregion

        #region METODOS
        public void SeleccionarCampos(int pos)
        {
            campos.RemoveAt(pos);
        }

        public void AplicarFiltros()
        {

        }

        public void LlamarCampos(string tab, string bd)
        {
            campos.Clear();
            Estructura objEst = new Estructura();
            objEst.Sentencia = string.Format("use {0} SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'", bd, tab);
            objEst.Parametros = new SqlParameter[] { };
            objEst.Valores = new List<object>() { };
            objEst.Tabla = "Columnas";

            Operaciones objOp = new Operaciones();
            objOp.Elemento = objEst;

            DataTable columnas = new DataTable();
            columnas = objOp.ObtenerDtt();
            for (int i = 0; i < columnas.Rows.Count; i++)
            {
                Campo ca = new Campo(columnas.Rows[i]["COLUMN_NAME"].ToString(), columnas.Rows[i]["DATA_TYPE"].ToString());
                campos.Add(ca);
            }
        }
        #endregion
    }
}
