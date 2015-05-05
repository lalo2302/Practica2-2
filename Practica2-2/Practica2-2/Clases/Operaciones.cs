using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;
using BaseDatos.ConexionBD;
using System.Data;

namespace Practica2_2.Clases
{
    class Operaciones
    {
        private Estructura elemento;

        public Estructura Elemento
        {
            set { elemento = value; }
            get { return elemento; }
        }

        private Ejecucion objDatos;

        public Operaciones()
        {
            if (objDatos == null)
            {
                string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["CadenaSqlSrv"].ConnectionString;

                objDatos = new Ejecucion(cadena);
            }
        }

        public bool Ejecutar()
        {
            bool valido = false;
            int n = objDatos.EjecutaComando(elemento.Parametros, elemento.Valores, elemento.Sentencia, CommandType.Text);
            if (n > 0)
            {
                valido = true;
            }
            return valido;
        }

        public DataTable ObtenerCredenciales()
        {
            DataTable datos = new DataTable();
            datos = objDatos.SeleccionaDatosDesconectado(elemento.Parametros, elemento.Valores, elemento.Sentencia, CommandType.Text, "tbl_Credencial");
            return datos;
        }

        public int ConfirmarInicio()
        {
            int n = objDatos.EjecutaScalar(elemento.Parametros, elemento.Valores, elemento.Sentencia, CommandType.Text);

            return n;
        }
    }
}
