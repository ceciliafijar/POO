namespace MayorDeEdad
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMayorDeEdad = new System.Windows.Forms.DateTimePicker();
            this.lblMayorDeEdad = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdusca su fecha de nacimiento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpMayorDeEdad
            // 
            this.dtpMayorDeEdad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMayorDeEdad.Location = new System.Drawing.Point(191, 40);
            this.dtpMayorDeEdad.Name = "dtpMayorDeEdad";
            this.dtpMayorDeEdad.Size = new System.Drawing.Size(200, 20);
            this.dtpMayorDeEdad.TabIndex = 1;
            this.dtpMayorDeEdad.ValueChanged += new System.EventHandler(this.dtpMayorDeEdad_ValueChanged);
            // 
            // lblMayorDeEdad
            // 
            this.lblMayorDeEdad.AutoSize = true;
            this.lblMayorDeEdad.Location = new System.Drawing.Point(70, 114);
            this.lblMayorDeEdad.Name = "lblMayorDeEdad";
            this.lblMayorDeEdad.Size = new System.Drawing.Size(0, 13);
            this.lblMayorDeEdad.TabIndex = 2;
            this.lblMayorDeEdad.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(243, 109);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 188);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMayorDeEdad);
            this.Controls.Add(this.dtpMayorDeEdad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de mayores de edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMayorDeEdad;
        private System.Windows.Forms.Label lblMayorDeEdad;
        private System.Windows.Forms.Button btnCalcular;
    }
}

