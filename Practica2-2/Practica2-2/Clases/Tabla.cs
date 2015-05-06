using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_2.Clases
{
    public class Tabla
    {
        #region ATRIBUTOS
        private List<string> tablas = new List<string>();

        public List<string> Tablas
        {
            get { return tablas; }
            set { tablas = value; }
        }
        #endregion

        #region METODOS
        public void LlamarTablas(string bd)
        {
            string bDatos = bd;
            Estructura objEst = new Estructura();
            objEst.Sentencia = string.Format("use {0} SELECT name FROM sys.tables", bDatos);
            objEst.Parametros = new SqlParameter[] { 
            };
            objEst.Valores = new List<object>() { };
            objEst.Tabla = "Tablas";

            Operaciones objOp = new Operaciones();
            objOp.Elemento = objEst;

            DataTable tab = new DataTable();
            tab = objOp.ObtenerDtt();

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                tablas.Add(tab.Rows[i]["name"].ToString());
            }
        }
        #endregion
    }
}
