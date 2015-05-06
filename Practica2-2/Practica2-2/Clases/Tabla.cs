using System;
using System.Collections.Generic;
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
        public List<string> LlamarTablas(string bd)
        {
            return Tablas;
        }
        #endregion
    }
}
