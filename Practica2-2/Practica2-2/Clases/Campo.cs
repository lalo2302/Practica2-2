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

        #region METODOS
        public static List<string> LlamarLista()
        {
            List<string> nombres = new List<string>();
            foreach (Campo item in campos)
            {
                nombres.Add(item.nombre);
            }
            return nombres;
        }
        public void SeleccionarCampos(int pos)
        {
            campos.RemoveAt(pos);
        }

        public void AplicarFiltros()
        {

        }

        public void LlamarCampos()
        {
           
        }
        #endregion
    }
}
