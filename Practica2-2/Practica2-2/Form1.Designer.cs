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
            this.lblQuery = new System.Windows.Forms.Label();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblContiene = new System.Windows.Forms.Label();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.txtIgual = new System.Windows.Forms.TextBox();
            this.txtDif = new System.Windows.Forms.TextBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblCampo3 = new System.Windows.Forms.Label();
            this.lblCampo4 = new System.Windows.Forms.Label();
            this.lblEmpieza = new System.Windows.Forms.Label();
            this.chMayor = new System.Windows.Forms.CheckBox();
            this.chMenor = new System.Windows.Forms.CheckBox();
            this.chIgual = new System.Windows.Forms.CheckBox();
            this.chDif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTablas
            // 
            this.lstTablas.FormattingEnabled = true;
            this.lstTablas.Location = new System.Drawing.Point(12, 23);
            this.lstTablas.Name = "lstTablas";
            this.lstTablas.Size = new System.Drawing.Size(86, 108);
            this.lstTablas.TabIndex = 0;
            this.lstTablas.SelectedIndexChanged += new System.EventHandler(this.lstTablas_SelectedIndexChanged);
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(12, 7);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(39, 13);
            this.lblTablas.TabIndex = 2;
            this.lblTablas.Text = "Tablas";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(101, 7);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(53, 13);
            this.lblCol.TabIndex = 3;
            this.lblCol.Text = "Columnas";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(12, 172);
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
            this.dgvRes.Location = new System.Drawing.Point(12, 188);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.ReadOnly = true;
            this.dgvRes.Size = new System.Drawing.Size(277, 102);
            this.dgvRes.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(219, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Location = new System.Drawing.Point(104, 28);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(46, 13);
            this.lblCampo1.TabIndex = 0;
            this.lblCampo1.Text = "[Campo]";
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(104, 57);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(46, 13);
            this.lblCampo2.TabIndex = 2;
            this.lblCampo2.Text = "[Campo]";
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(219, 25);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(49, 20);
            this.txtMayor.TabIndex = 4;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(189, 28);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(13, 13);
            this.lblMayor.TabIndex = 5;
            this.lblMayor.Text = ">";
            // 
            // lblContiene
            // 
            this.lblContiene.AutoSize = true;
            this.lblContiene.Location = new System.Drawing.Point(181, 57);
            this.lblContiene.Name = "lblContiene";
            this.lblContiene.Size = new System.Drawing.Size(30, 13);
            this.lblContiene.TabIndex = 6;
            this.lblContiene.Text = "%X%";
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(219, 54);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(49, 20);
            this.txtMenor.TabIndex = 7;
            // 
            // txtIgual
            // 
            this.txtIgual.Location = new System.Drawing.Point(219, 83);
            this.txtIgual.Name = "txtIgual";
            this.txtIgual.Size = new System.Drawing.Size(49, 20);
            this.txtIgual.TabIndex = 8;
            // 
            // txtDif
            // 
            this.txtDif.Location = new System.Drawing.Point(219, 114);
            this.txtDif.Name = "txtDif";
            this.txtDif.Size = new System.Drawing.Size(49, 20);
            this.txtDif.TabIndex = 9;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(189, 86);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 10;
            this.lblIgual.Text = "=";
            // 
            // lblCampo3
            // 
            this.lblCampo3.AutoSize = true;
            this.lblCampo3.Location = new System.Drawing.Point(104, 86);
            this.lblCampo3.Name = "lblCampo3";
            this.lblCampo3.Size = new System.Drawing.Size(46, 13);
            this.lblCampo3.TabIndex = 11;
            this.lblCampo3.Text = "[Campo]";
            // 
            // lblCampo4
            // 
            this.lblCampo4.AutoSize = true;
            this.lblCampo4.Location = new System.Drawing.Point(104, 114);
            this.lblCampo4.Name = "lblCampo4";
            this.lblCampo4.Size = new System.Drawing.Size(46, 13);
            this.lblCampo4.TabIndex = 12;
            this.lblCampo4.Text = "[Campo]";
            // 
            // lblEmpieza
            // 
            this.lblEmpieza.AutoSize = true;
            this.lblEmpieza.Location = new System.Drawing.Point(186, 117);
            this.lblEmpieza.Name = "lblEmpieza";
            this.lblEmpieza.Size = new System.Drawing.Size(22, 13);
            this.lblEmpieza.TabIndex = 13;
            this.lblEmpieza.Text = "X%";
            // 
            // chMayor
            // 
            this.chMayor.AutoSize = true;
            this.chMayor.Location = new System.Drawing.Point(274, 28);
            this.chMayor.Name = "chMayor";
            this.chMayor.Size = new System.Drawing.Size(15, 14);
            this.chMayor.TabIndex = 14;
            this.chMayor.UseVisualStyleBackColor = true;
            // 
            // chMenor
            // 
            this.chMenor.AutoSize = true;
            this.chMenor.Location = new System.Drawing.Point(274, 60);
            this.chMenor.Name = "chMenor";
            this.chMenor.Size = new System.Drawing.Size(15, 14);
            this.chMenor.TabIndex = 15;
            this.chMenor.UseVisualStyleBackColor = true;
            // 
            // chIgual
            // 
            this.chIgual.AutoSize = true;
            this.chIgual.Location = new System.Drawing.Point(274, 86);
            this.chIgual.Name = "chIgual";
            this.chIgual.Size = new System.Drawing.Size(15, 14);
            this.chIgual.TabIndex = 16;
            this.chIgual.UseVisualStyleBackColor = true;
            // 
            // chDif
            // 
            this.chDif.AutoSize = true;
            this.chDif.Location = new System.Drawing.Point(274, 117);
            this.chDif.Name = "chDif";
            this.chDif.Size = new System.Drawing.Size(15, 14);
            this.chDif.TabIndex = 17;
            this.chDif.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 302);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chDif);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.chIgual);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.chMenor);
            this.Controls.Add(this.chMayor);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblEmpieza);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.lblCampo4);
            this.Controls.Add(this.lstTablas);
            this.Controls.Add(this.lblCampo3);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblCampo2);
            this.Controls.Add(this.txtDif);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.txtIgual);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.lblContiene);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTablas;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblContiene;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.TextBox txtIgual;
        private System.Windows.Forms.TextBox txtDif;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblCampo3;
        private System.Windows.Forms.Label lblCampo4;
        private System.Windows.Forms.Label lblEmpieza;
        private System.Windows.Forms.CheckBox chMayor;
        private System.Windows.Forms.CheckBox chMenor;
        private System.Windows.Forms.CheckBox chIgual;
        private System.Windows.Forms.CheckBox chDif;
    }
}

