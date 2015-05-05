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
            this.lstTablas = new System.Windows.Forms.ListBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chlstCol = new System.Windows.Forms.CheckedListBox();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTablas
            // 
            this.lstTablas.FormattingEnabled = true;
            this.lstTablas.Location = new System.Drawing.Point(12, 25);
            this.lstTablas.Name = "lstTablas";
            this.lstTablas.Size = new System.Drawing.Size(86, 108);
            this.lstTablas.TabIndex = 0;
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(12, 9);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(39, 13);
            this.lblTablas.TabIndex = 2;
            this.lblTablas.Text = "Tablas";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(101, 9);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(53, 13);
            this.lblCol.TabIndex = 3;
            this.lblCol.Text = "Columnas";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(227, 9);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(34, 13);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb);
            this.groupBox1.Controls.Add(this.lblCampo2);
            this.groupBox1.Controls.Add(this.lblCampo1);
            this.groupBox1.Location = new System.Drawing.Point(230, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chlstCol
            // 
            this.chlstCol.FormattingEnabled = true;
            this.chlstCol.Location = new System.Drawing.Point(104, 25);
            this.chlstCol.Name = "chlstCol";
            this.chlstCol.Size = new System.Drawing.Size(120, 109);
            this.chlstCol.TabIndex = 0;
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Location = new System.Drawing.Point(3, 16);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(46, 13);
            this.lblCampo1.TabIndex = 0;
            this.lblCampo1.Text = "[Campo]";
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(3, 65);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(46, 13);
            this.lblCampo2.TabIndex = 2;
            this.lblCampo2.Text = "[Campo]";
            // 
            // cmb
            // 
            this.cmb.DropDownHeight = 60;
            this.cmb.DropDownWidth = 20;
            this.cmb.IntegralHeight = false;
            this.cmb.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            "!="});
            this.cmb.Location = new System.Drawing.Point(55, 13);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(38, 21);
            this.cmb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.chlstCol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.lstTablas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTablas;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.CheckedListBox chlstCol;
    }
}

