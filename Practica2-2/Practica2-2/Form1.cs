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
        Campo Campo = new Campo();
        Tabla Tabla = new Tabla();
        static string baseDatos;
        static string tabla;
        static string query = "";
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

        private void btnCol_Click(object sender, EventArgs e)
        {
            Campo.Campos.Clear();
            Campo.LlamarCampos(tabla, baseDatos);
            int count = chlstCol.Items.Count;

            for (int i = 0; i < count; i++)
                if (!(chlstCol.GetItemChecked(i)))
                    for (int j = 0; j < Campo.Campos.Count; j++)
                        if (chlstCol.Items[i].ToString() == Campo.Campos[j].Nombre)
                        {
                            Campo.Campos.RemoveAt(j);
                        }
            for (int i = 0; i < Campo.Campos.Count; i++)
            {
                GenerarQuery(Campo.Campos[i].Nombre, "camp");
            }

            string nom = Campo.Campos[0].Nombre;
            if (Campo.Campos[0].Tipo == "nvarchar")
            {
                lblCamp1.Text = nom;
                lblCamp2.Text = nom;
                lblCamp3.Text = nom;
                lblCamp4.Text = nom;
            }

            else
            {
                lblCampo1.Text = nom;
                lblCampo2.Text = nom;
                lblCampo3.Text = nom;
                lblCampo4.Text = nom;
            }
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
                if (query.Contains('*'))
                    query = query.Replace("*", "," + txt);
                else
                    query = query.Insert(query.IndexOf(","), "," + txt);
                lblQuery.Text = query.Remove(query.IndexOf(','), 1);
            }
            
        }
    }
}
