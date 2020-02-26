namespace CalculadoraDePromedios
{
    partial class Form1
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
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.lblPromedioGeneral = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAprob = new System.Windows.Forms.TextBox();
            this.txtReprob = new System.Windows.Forms.TextBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(186, 81);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.Text = "Capturar\r\n";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(186, 264);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(59, 40);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 2;
            this.lblCalificacion.Text = "Calificacion";
            this.lblCalificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(161, 37);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 3;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.txtCalificacion_TextChanged);
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(38, 119);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(61, 13);
            this.lblAprobados.TabIndex = 4;
            this.lblAprobados.Text = "Aprobados:";
            this.lblAprobados.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(38, 161);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(68, 13);
            this.lblReprobados.TabIndex = 5;
            this.lblReprobados.Text = "Reprobados:";
            this.lblReprobados.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPromedioGeneral
            // 
            this.lblPromedioGeneral.AutoSize = true;
            this.lblPromedioGeneral.Location = new System.Drawing.Point(38, 209);
            this.lblPromedioGeneral.Name = "lblPromedioGeneral";
            this.lblPromedioGeneral.Size = new System.Drawing.Size(122, 13);
            this.lblPromedioGeneral.TabIndex = 8;
            this.lblPromedioGeneral.Text = "PROMEDIO GENERAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // txtAprob
            // 
            this.txtAprob.Location = new System.Drawing.Point(114, 116);
            this.txtAprob.Name = "txtAprob";
            this.txtAprob.Size = new System.Drawing.Size(100, 20);
            this.txtAprob.TabIndex = 10;
            this.txtAprob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtReprob
            // 
            this.txtReprob.Location = new System.Drawing.Point(114, 161);
            this.txtReprob.Name = "txtReprob";
            this.txtReprob.Size = new System.Drawing.Size(100, 20);
            this.txtReprob.TabIndex = 11;
            this.txtReprob.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtProm
            // 
            this.txtProm.Location = new System.Drawing.Point(166, 206);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(100, 20);
            this.txtProm.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 299);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.txtReprob);
            this.Controls.Add(this.txtAprob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPromedioGeneral);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCapturar);
            this.Name = "Form1";
            this.Text = "Administrador de calificaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Label lblPromedioGeneral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAprob;
        private System.Windows.Forms.TextBox txtReprob;
        private System.Windows.Forms.TextBox txtProm;
    }
}

