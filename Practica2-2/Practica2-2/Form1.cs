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
        Campo Campo = new Campo();
        Tabla Tabla = new Tabla();
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
                Tabla.LlamarTablas(baseDatos);
                for (int i = 0; i < Tabla.Tablas.Count; i++)
                {
                    lstTablas.Items.Add(Tabla.Tablas[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa base de datos no existe");
            }
        }
        

        private void lstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chlstCol.Items.Clear();
            Cnombre.Clear();
            Ctipo.Clear();
            string tabla = lstTablas.SelectedItem.ToString();
            Campo.LlamarCampos(tabla, baseDatos);
            foreach (Campo camp in Campo.Campos)
            {
                chlstCol.Items.Add(camp.Nombre);
            }
        }

        private void btnCol_Click(object sender, EventArgs e)
        {
            int count = chlstCol.Items.Count;

            for (int i = 0; i < count; i++)
                if (!(chlstCol.GetItemChecked(i)))
                    for (int j = 0; j < Cnombre.Count; j++)
                        if (chlstCol.Items[i].ToString() == Cnombre[j])
                        {
                            Campo.SeleccionarCampos(j);
                        }
        }
    }
}
