namespace Practica2_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstTablas = new System.Windows.Forms.ListBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.gboxInt = new System.Windows.Forms.GroupBox();
            this.btnApFiltroI = new System.Windows.Forms.Button();
            this.btnNingunoI = new System.Windows.Forms.Button();
            this.chDif = new System.Windows.Forms.CheckBox();
            this.chIgual = new System.Windows.Forms.CheckBox();
            this.chMenor = new System.Windows.Forms.CheckBox();
            this.chMayor = new System.Windows.Forms.CheckBox();
            this.lblDif = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.txtDif = new System.Windows.Forms.TextBox();
            this.txtIgual = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.chlstCol = new System.Windows.Forms.CheckedListBox();
            this.gboxString = new System.Windows.Forms.GroupBox();
            this.btnApFiltroS = new System.Windows.Forms.Button();
            this.btnNingunoS = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.lblIgualS = new System.Windows.Forms.Label();
            this.lblCamp4 = new System.Windows.Forms.Label();
            this.lblCamp3 = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.txtCamp4 = new System.Windows.Forms.TextBox();
            this.txtCamp3 = new System.Windows.Forms.TextBox();
            this.txtCamp2 = new System.Windows.Forms.TextBox();
            this.lblTer = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.txtCamp1 = new System.Windows.Forms.TextBox();
            this.lblCamp2 = new System.Windows.Forms.Label();
            this.lblCamp1 = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBd = new System.Windows.Forms.Label();
            this.txtBd = new System.Windows.Forms.TextBox();
            this.btnBd = new System.Windows.Forms.Button();
            this.btnCol = new System.Windows.Forms.Button();
            this.gboxInt.SuspendLayout();
            this.gboxString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTablas
            // 
            this.lstTablas.FormattingEnabled = true;
            this.lstTablas.Location = new System.Drawing.Point(12, 66);
            this.lstTablas.Name = "lstTablas";
            this.lstTablas.Size = new System.Drawing.Size(86, 108);
            this.lstTablas.TabIndex = 0;
            this.lstTablas.SelectedIndexChanged += new System.EventHandler(this.lstTablas_SelectedIndexChanged);
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(12, 50);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(39, 13);
            this.lblTablas.TabIndex = 2;
            this.lblTablas.Text = "Tablas";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(101, 50);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(53, 13);
            this.lblCol.TabIndex = 3;
            this.lblCol.Text = "Columnas";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(227, 50);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(34, 13);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtros";
            // 
            // gboxInt
            // 
            this.gboxInt.Controls.Add(this.btnApFiltroI);
            this.gboxInt.Controls.Add(this.btnNingunoI);
            this.gboxInt.Controls.Add(this.chDif);
            this.gboxInt.Controls.Add(this.chIgual);
            this.gboxInt.Controls.Add(this.chMenor);
            this.gboxInt.Controls.Add(this.chMayor);
            this.gboxInt.Controls.Add(this.lblDif);
            this.gboxInt.Controls.Add(this.label2);
            this.gboxInt.Controls.Add(this.label1);
            this.gboxInt.Controls.Add(this.lblIgual);
            this.gboxInt.Controls.Add(this.txtDif);
            this.gboxInt.Controls.Add(this.txtIgual);
            this.gboxInt.Controls.Add(this.txtMenor);
            this.gboxInt.Controls.Add(this.lblMenor);
            this.gboxInt.Controls.Add(this.lblMayor);
            this.gboxInt.Controls.Add(this.txtMayor);
            this.gboxInt.Controls.Add(this.lblCampo2);
            this.gboxInt.Controls.Add(this.lblCampo1);
            this.gboxInt.Location = new System.Drawing.Point(230, 50);
            this.gboxInt.Name = "gboxInt";
            this.gboxInt.Size = new System.Drawing.Size(174, 164);
            this.gboxInt.TabIndex = 5;
            this.gboxInt.TabStop = false;
            this.gboxInt.Text = "Número";
            // 
            // btnApFiltroI
            // 
            this.btnApFiltroI.Location = new System.Drawing.Point(123, 10);
            this.btnApFiltroI.Name = "btnApFiltroI";
            this.btnApFiltroI.Size = new System.Drawing.Size(49, 23);
            this.btnApFiltroI.TabIndex = 26;
            this.btnApFiltroI.Text = "Aplicar";
            this.btnApFiltroI.UseVisualStyleBackColor = true;
            // 
            // btnNingunoI
            // 
            this.btnNingunoI.Location = new System.Drawing.Point(77, 135);
            this.btnNingunoI.Name = "btnNingunoI";
            this.btnNingunoI.Size = new System.Drawing.Size(63, 23);
            this.btnNingunoI.TabIndex = 26;
            this.btnNingunoI.Text = "Ninguno";
            this.btnNingunoI.UseVisualStyleBackColor = true;
            // 
            // chDif
            // 
            this.chDif.AutoSize = true;
            this.chDif.Location = new System.Drawing.Point(111, 115);
            this.chDif.Name = "chDif";
            this.chDif.Size = new System.Drawing.Size(15, 14);
            this.chDif.TabIndex = 17;
            this.chDif.UseVisualStyleBackColor = true;
            // 
            // chIgual
            // 
            this.chIgual.AutoSize = true;
            this.chIgual.Location = new System.Drawing.Point(111, 89);
            this.chIgual.Name = "chIgual";
            this.chIgual.Size = new System.Drawing.Size(15, 14);
            this.chIgual.TabIndex = 16;
            this.chIgual.UseVisualStyleBackColor = true;
            // 
            // chMenor
            // 
            this.chMenor.AutoSize = true;
            this.chMenor.Location = new System.Drawing.Point(111, 62);
            this.chMenor.Name = "chMenor";
            this.chMenor.Size = new System.Drawing.Size(15, 14);
            this.chMenor.TabIndex = 15;
            this.chMenor.UseVisualStyleBackColor = true;
            // 
            // chMayor
            // 
            this.chMayor.AutoSize = true;
            this.chMayor.Location = new System.Drawing.Point(111, 36);
            this.chMayor.Name = "chMayor";
            this.chMayor.Size = new System.Drawing.Size(15, 14);
            this.chMayor.TabIndex = 14;
            this.chMayor.UseVisualStyleBackColor = true;
            // 
            // lblDif
            // 
            this.lblDif.AutoSize = true;
            this.lblDif.Location = new System.Drawing.Point(55, 114);
            this.lblDif.Name = "lblDif";
            this.lblDif.Size = new System.Drawing.Size(16, 13);
            this.lblDif.TabIndex = 13;
            this.lblDif.Text = "!=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "[Campo]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "[Campo]";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(58, 88);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 10;
            this.lblIgual.Text = "=";
            // 
            // txtDif
            // 
            this.txtDif.Location = new System.Drawing.Point(77, 111);
            this.txtDif.Name = "txtDif";
            this.txtDif.Size = new System.Drawing.Size(28, 20);
            this.txtDif.TabIndex = 9;
            // 
            // txtIgual
            // 
            this.txtIgual.Location = new System.Drawing.Point(77, 85);
            this.txtIgual.Name = "txtIgual";
            this.txtIgual.Size = new System.Drawing.Size(28, 20);
            this.txtIgual.TabIndex = 8;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(77, 59);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(28, 20);
            this.txtMenor.TabIndex = 7;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(58, 62);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(13, 13);
            this.lblMenor.TabIndex = 6;
            this.lblMenor.Text = "<";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(58, 36);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(13, 13);
            this.lblMayor.TabIndex = 5;
            this.lblMayor.Text = ">";
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(77, 33);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(28, 20);
            this.txtMayor.TabIndex = 4;
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(6, 62);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(46, 13);
            this.lblCampo2.TabIndex = 2;
            this.lblCampo2.Text = "[Campo]";
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Location = new System.Drawing.Point(6, 36);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(46, 13);
            this.lblCampo1.TabIndex = 0;
            this.lblCampo1.Text = "[Campo]";
            // 
            // chlstCol
            // 
            this.chlstCol.FormattingEnabled = true;
            this.chlstCol.Location = new System.Drawing.Point(104, 66);
            this.chlstCol.Name = "chlstCol";
            this.chlstCol.Size = new System.Drawing.Size(120, 109);
            this.chlstCol.TabIndex = 0;
            // 
            // gboxString
            // 
            this.gboxString.Controls.Add(this.btnApFiltroS);
            this.gboxString.Controls.Add(this.btnNingunoS);
            this.gboxString.Controls.Add(this.checkBox1);
            this.gboxString.Controls.Add(this.checkBox2);
            this.gboxString.Controls.Add(this.checkBox3);
            this.gboxString.Controls.Add(this.checkBox4);
            this.gboxString.Controls.Add(this.lblIgualS);
            this.gboxString.Controls.Add(this.lblCamp4);
            this.gboxString.Controls.Add(this.lblCamp3);
            this.gboxString.Controls.Add(this.lblCont);
            this.gboxString.Controls.Add(this.txtCamp4);
            this.gboxString.Controls.Add(this.txtCamp3);
            this.gboxString.Controls.Add(this.txtCamp2);
            this.gboxString.Controls.Add(this.lblTer);
            this.gboxString.Controls.Add(this.lblEmp);
            this.gboxString.Controls.Add(this.txtCamp1);
            this.gboxString.Controls.Add(this.lblCamp2);
            this.gboxString.Controls.Add(this.lblCamp1);
            this.gboxString.Location = new System.Drawing.Point(230, 50);
            this.gboxString.Name = "gboxString";
            this.gboxString.Size = new System.Drawing.Size(174, 166);
            this.gboxString.TabIndex = 18;
            this.gboxString.TabStop = false;
            this.gboxString.Text = "Texto";
            // 
            // btnApFiltroS
            // 
            this.btnApFiltroS.Location = new System.Drawing.Point(118, 8);
            this.btnApFiltroS.Name = "btnApFiltroS";
            this.btnApFiltroS.Size = new System.Drawing.Size(49, 23);
            this.btnApFiltroS.TabIndex = 24;
            this.btnApFiltroS.Text = "Aplicar";
            this.btnApFiltroS.UseVisualStyleBackColor = true;
            // 
            // btnNingunoS
            // 
            this.btnNingunoS.Location = new System.Drawing.Point(95, 137);
            this.btnNingunoS.Name = "btnNingunoS";
            this.btnNingunoS.Size = new System.Drawing.Size(73, 23);
            this.btnNingunoS.TabIndex = 25;
            this.btnNingunoS.Text = "Ninguno";
            this.btnNingunoS.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(153, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(153, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(153, 64);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(153, 38);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // lblIgualS
            // 
            this.lblIgualS.AutoSize = true;
            this.lblIgualS.Location = new System.Drawing.Point(66, 117);
            this.lblIgualS.Name = "lblIgualS";
            this.lblIgualS.Size = new System.Drawing.Size(13, 13);
            this.lblIgualS.TabIndex = 13;
            this.lblIgualS.Text = "=";
            // 
            // lblCamp4
            // 
            this.lblCamp4.AutoSize = true;
            this.lblCamp4.Location = new System.Drawing.Point(7, 116);
            this.lblCamp4.Name = "lblCamp4";
            this.lblCamp4.Size = new System.Drawing.Size(46, 13);
            this.lblCamp4.TabIndex = 12;
            this.lblCamp4.Text = "[Campo]";
            // 
            // lblCamp3
            // 
            this.lblCamp3.AutoSize = true;
            this.lblCamp3.Location = new System.Drawing.Point(7, 90);
            this.lblCamp3.Name = "lblCamp3";
            this.lblCamp3.Size = new System.Drawing.Size(46, 13);
            this.lblCamp3.TabIndex = 11;
            this.lblCamp3.Text = "[Campo]";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(59, 90);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(28, 13);
            this.lblCont.TabIndex = 10;
            this.lblCont.Text = "%x%";
            // 
            // txtCamp4
            // 
            this.txtCamp4.Location = new System.Drawing.Point(95, 113);
            this.txtCamp4.Name = "txtCamp4";
            this.txtCamp4.Size = new System.Drawing.Size(52, 20);
            this.txtCamp4.TabIndex = 9;
            // 
            // txtCamp3
            // 
            this.txtCamp3.Location = new System.Drawing.Point(95, 87);
            this.txtCamp3.Name = "txtCamp3";
            this.txtCamp3.Size = new System.Drawing.Size(52, 20);
            this.txtCamp3.TabIndex = 8;
            // 
            // txtCamp2
            // 
            this.txtCamp2.Location = new System.Drawing.Point(95, 61);
            this.txtCamp2.Name = "txtCamp2";
            this.txtCamp2.Size = new System.Drawing.Size(52, 20);
            this.txtCamp2.TabIndex = 7;
            // 
            // lblTer
            // 
            this.lblTer.AutoSize = true;
            this.lblTer.Location = new System.Drawing.Point(62, 64);
            this.lblTer.Name = "lblTer";
            this.lblTer.Size = new System.Drawing.Size(20, 13);
            this.lblTer.TabIndex = 6;
            this.lblTer.Text = "%x";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(64, 38);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(20, 13);
            this.lblEmp.TabIndex = 5;
            this.lblEmp.Text = "x%";
            // 
            // txtCamp1
            // 
            this.txtCamp1.Location = new System.Drawing.Point(95, 35);
            this.txtCamp1.Name = "txtCamp1";
            this.txtCamp1.Size = new System.Drawing.Size(52, 20);
            this.txtCamp1.TabIndex = 4;
            // 
            // lblCamp2
            // 
            this.lblCamp2.AutoSize = true;
            this.lblCamp2.Location = new System.Drawing.Point(7, 64);
            this.lblCamp2.Name = "lblCamp2";
            this.lblCamp2.Size = new System.Drawing.Size(46, 13);
            this.lblCamp2.TabIndex = 2;
            this.lblCamp2.Text = "[Campo]";
            // 
            // lblCamp1
            // 
            this.lblCamp1.AutoSize = true;
            this.lblCamp1.Location = new System.Drawing.Point(7, 38);
            this.lblCamp1.Name = "lblCamp1";
            this.lblCamp1.Size = new System.Drawing.Size(46, 13);
            this.lblCamp1.TabIndex = 0;
            this.lblCamp1.Text = "[Campo]";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(12, 227);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(35, 13);
            this.lblQuery.TabIndex = 19;
            this.lblQuery.Text = "Query";
            // 
            // dgvRes
            // 
            this.dgvRes.AllowUserToAddRows = false;
            this.dgvRes.AllowUserToDeleteRows = false;
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Location = new System.Drawing.Point(12, 255);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.ReadOnly = true;
            this.dgvRes.Size = new System.Drawing.Size(392, 102);
            this.dgvRes.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(352, 222);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.Location = new System.Drawing.Point(12, 9);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(129, 13);
            this.lblBd.TabIndex = 22;
            this.lblBd.Text = "Nombre de base de datos";
            // 
            // txtBd
            // 
            this.txtBd.Location = new System.Drawing.Point(147, 6);
            this.txtBd.Name = "txtBd";
            this.txtBd.Size = new System.Drawing.Size(77, 20);
            this.txtBd.TabIndex = 18;
            // 
            // btnBd
            // 
            this.btnBd.Location = new System.Drawing.Point(236, 4);
            this.btnBd.Name = "btnBd";
            this.btnBd.Size = new System.Drawing.Size(96, 23);
            this.btnBd.TabIndex = 23;
            this.btnBd.Text = "Inspeccionar";
            this.btnBd.UseVisualStyleBackColor = true;
            this.btnBd.Click += new System.EventHandler(this.btnBd_Click);
            // 
            // btnCol
            // 
            this.btnCol.Location = new System.Drawing.Point(104, 181);
            this.btnCol.Name = "btnCol";
            this.btnCol.Size = new System.Drawing.Size(120, 27);
            this.btnCol.TabIndex = 24;
            this.btnCol.Text = "Aplicar Columnas";
            this.btnCol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 369);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.btnBd);
            this.Controls.Add(this.txtBd);
            this.Controls.Add(this.lblBd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.gboxString);
            this.Controls.Add(this.chlstCol);
            this.Controls.Add(this.gboxInt);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.lstTablas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda";
            this.gboxInt.ResumeLayout(false);
            this.gboxInt.PerformLayout();
            this.gboxString.ResumeLayout(false);
            this.gboxString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTablas;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gboxInt;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.CheckedListBox chlstCol;
        private System.Windows.Forms.CheckBox chDif;
        private System.Windows.Forms.CheckBox chIgual;
        private System.Windows.Forms.CheckBox chMenor;
        private System.Windows.Forms.CheckBox chMayor;
        private System.Windows.Forms.Label lblDif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.TextBox txtDif;
        private System.Windows.Forms.TextBox txtIgual;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.GroupBox gboxString;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lblIgualS;
        private System.Windows.Forms.Label lblCamp4;
        private System.Windows.Forms.Label lblCamp3;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.TextBox txtCamp4;
        private System.Windows.Forms.TextBox txtCamp3;
        private System.Windows.Forms.TextBox txtCamp2;
        private System.Windows.Forms.Label lblTer;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.TextBox txtCamp1;
        private System.Windows.Forms.Label lblCamp2;
        private System.Windows.Forms.Label lblCamp1;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.TextBox txtBd;
        private System.Windows.Forms.Button btnBd;
        private System.Windows.Forms.Button btnApFiltroS;
        private System.Windows.Forms.Button btnNingunoI;
        private System.Windows.Forms.Button btnNingunoS;
        private System.Windows.Forms.Button btnApFiltroI;
        private System.Windows.Forms.Button btnCol;
    }
}

