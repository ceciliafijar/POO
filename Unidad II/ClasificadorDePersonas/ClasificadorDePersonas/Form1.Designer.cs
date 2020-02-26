namespace ClasificadorDePersonas
{
    partial class Consierto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAsisten = new System.Windows.Forms.Label();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.cboCantidad = new System.Windows.Forms.ComboBox();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblAdultosMayores = new System.Windows.Forms.Label();
            this.lblRespuestaBebe = new System.Windows.Forms.Label();
            this.lblRespuestaNinos = new System.Windows.Forms.Label();
            this.lblRespuestaAdultos = new System.Windows.Forms.Label();
            this.lblRespuestaAdultosM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsisten
            // 
            this.lblAsisten.AutoSize = true;
            this.lblAsisten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsisten.Location = new System.Drawing.Point(53, 31);
            this.lblAsisten.Name = "lblAsisten";
            this.lblAsisten.Size = new System.Drawing.Size(70, 16);
            this.lblAsisten.TabIndex = 0;
            this.lblAsisten.Text = "Asistentes";
            // 
            // cboPersonas
            // 
            this.cboPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Items.AddRange(new object[] {
            "Bebes",
            "Niños",
            "Adultos",
            "Personas de la tercera edad"});
            this.cboPersonas.Location = new System.Drawing.Point(180, 31);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(121, 21);
            this.cboPersonas.TabIndex = 1;
            this.cboPersonas.SelectedIndexChanged += new System.EventHandler(this.cboPersonas_SelectedIndexChanged);
            // 
            // cboCantidad
            // 
            this.cboCantidad.FormattingEnabled = true;
            this.cboCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboCantidad.Location = new System.Drawing.Point(219, 68);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(82, 21);
            this.cboCantidad.TabIndex = 2;
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Location = new System.Drawing.Point(226, 239);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(75, 23);
            this.btnContabilizar.TabIndex = 3;
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(40, 239);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(53, 73);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bebes:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(103, 151);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(37, 13);
            this.lblNiños.TabIndex = 7;
            this.lblNiños.Text = "Niños:";
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(103, 174);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(45, 13);
            this.lblAdultos.TabIndex = 8;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblAdultosMayores
            // 
            this.lblAdultosMayores.AutoSize = true;
            this.lblAdultosMayores.Location = new System.Drawing.Point(103, 201);
            this.lblAdultosMayores.Name = "lblAdultosMayores";
            this.lblAdultosMayores.Size = new System.Drawing.Size(88, 13);
            this.lblAdultosMayores.TabIndex = 9;
            this.lblAdultosMayores.Text = "Adultos Mayores:";
            this.lblAdultosMayores.Click += new System.EventHandler(this.lblAdultosMayores_Click);
            // 
            // lblRespuestaBebe
            // 
            this.lblRespuestaBebe.AutoSize = true;
            this.lblRespuestaBebe.Location = new System.Drawing.Point(153, 125);
            this.lblRespuestaBebe.Name = "lblRespuestaBebe";
            this.lblRespuestaBebe.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaBebe.TabIndex = 10;
            this.lblRespuestaBebe.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRespuestaNinos
            // 
            this.lblRespuestaNinos.AutoSize = true;
            this.lblRespuestaNinos.Location = new System.Drawing.Point(153, 151);
            this.lblRespuestaNinos.Name = "lblRespuestaNinos";
            this.lblRespuestaNinos.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaNinos.TabIndex = 11;
            // 
            // lblRespuestaAdultos
            // 
            this.lblRespuestaAdultos.AutoSize = true;
            this.lblRespuestaAdultos.Location = new System.Drawing.Point(154, 174);
            this.lblRespuestaAdultos.Name = "lblRespuestaAdultos";
            this.lblRespuestaAdultos.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaAdultos.TabIndex = 12;
            // 
            // lblRespuestaAdultosM
            // 
            this.lblRespuestaAdultosM.AutoSize = true;
            this.lblRespuestaAdultosM.Location = new System.Drawing.Point(194, 201);
            this.lblRespuestaAdultosM.Name = "lblRespuestaAdultosM";
            this.lblRespuestaAdultosM.Size = new System.Drawing.Size(0, 13);
            this.lblRespuestaAdultosM.TabIndex = 13;
            this.lblRespuestaAdultosM.Click += new System.EventHandler(this.label5_Click);
            // 
            // Consierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 304);
            this.Controls.Add(this.lblRespuestaAdultosM);
            this.Controls.Add(this.lblRespuestaAdultos);
            this.Controls.Add(this.lblRespuestaNinos);
            this.Controls.Add(this.lblRespuestaBebe);
            this.Controls.Add(this.lblAdultosMayores);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.lblNiños);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.cboCantidad);
            this.Controls.Add(this.cboPersonas);
            this.Controls.Add(this.lblAsisten);
            this.Name = "Consierto";
            this.Text = "Clasificador de personas";
            this.Load += new System.EventHandler(this.Consierto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsisten;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.ComboBox cboCantidad;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblAdultosMayores;
        private System.Windows.Forms.Label lblRespuestaBebe;
        private System.Windows.Forms.Label lblRespuestaNinos;
        private System.Windows.Forms.Label lblRespuestaAdultos;
        private System.Windows.Forms.Label lblRespuestaAdultosM;
    }
}

