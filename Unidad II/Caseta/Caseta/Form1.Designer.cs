namespace Caseta
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
            this.cbmTipoCarro = new System.Windows.Forms.ComboBox();
            this.lblCantidadCobrar = new System.Windows.Forms.Label();
            this.txtCantidadCobrar = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de carros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbmTipoCarro
            // 
            this.cbmTipoCarro.FormattingEnabled = true;
            this.cbmTipoCarro.Items.AddRange(new object[] {
            "Motocicleta",
            "Automivil",
            "Autobus",
            "Trailer"});
            this.cbmTipoCarro.Location = new System.Drawing.Point(120, 30);
            this.cbmTipoCarro.Name = "cbmTipoCarro";
            this.cbmTipoCarro.Size = new System.Drawing.Size(121, 21);
            this.cbmTipoCarro.TabIndex = 1;
            // 
            // lblCantidadCobrar
            // 
            this.lblCantidadCobrar.AutoSize = true;
            this.lblCantidadCobrar.Location = new System.Drawing.Point(49, 126);
            this.lblCantidadCobrar.Name = "lblCantidadCobrar";
            this.lblCantidadCobrar.Size = new System.Drawing.Size(98, 13);
            this.lblCantidadCobrar.TabIndex = 2;
            this.lblCantidadCobrar.Text = "Cantidad a Cobrar: ";
            // 
            // txtCantidadCobrar
            // 
            this.txtCantidadCobrar.Location = new System.Drawing.Point(153, 123);
            this.txtCantidadCobrar.Name = "txtCantidadCobrar";
            this.txtCantidadCobrar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadCobrar.TabIndex = 3;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(269, 28);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 197);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtCantidadCobrar);
            this.Controls.Add(this.lblCantidadCobrar);
            this.Controls.Add(this.cbmTipoCarro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Caseta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmTipoCarro;
        private System.Windows.Forms.Label lblCantidadCobrar;
        private System.Windows.Forms.TextBox txtCantidadCobrar;
        private System.Windows.Forms.Button btnEvaluar;
    }
}

