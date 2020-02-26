namespace Temperaturas
{
    partial class lblGradosConvert
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
            this.lblGrados = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.cbmUnidades = new System.Windows.Forms.ComboBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblGradosCon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(41, 29);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(41, 13);
            this.lblGrados.TabIndex = 0;
            this.lblGrados.Text = "Grados";
            this.lblGrados.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(47, 89);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(52, 13);
            this.lblUnidades.TabIndex = 1;
            this.lblUnidades.Text = "Unidades";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(44, 45);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 2;
            // 
            // cbmUnidades
            // 
            this.cbmUnidades.FormattingEnabled = true;
            this.cbmUnidades.Items.AddRange(new object[] {
            "Centigrados",
            "Farenheit"});
            this.cbmUnidades.Location = new System.Drawing.Point(44, 105);
            this.cbmUnidades.Name = "cbmUnidades";
            this.cbmUnidades.Size = new System.Drawing.Size(121, 21);
            this.cbmUnidades.TabIndex = 3;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(194, 141);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblGradosCon
            // 
            this.lblGradosCon.AutoSize = true;
            this.lblGradosCon.Location = new System.Drawing.Point(41, 173);
            this.lblGradosCon.Name = "lblGradosCon";
            this.lblGradosCon.Size = new System.Drawing.Size(102, 13);
            this.lblGradosCon.TabIndex = 5;
            this.lblGradosCon.Text = "Grados convertidos:";
            this.lblGradosCon.Click += new System.EventHandler(this.lblGradosConver_Click);
            // 
            // lblGradosConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 251);
            this.Controls.Add(this.lblGradosCon);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.cbmUnidades);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblGrados);
            this.Name = "lblGradosConvert";
            this.Text = "Convertidor de temperaturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.ComboBox cbmUnidades;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblGradosCon;
    }
}

