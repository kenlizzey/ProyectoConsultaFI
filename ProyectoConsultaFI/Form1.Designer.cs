namespace ProyectoConsultaFI
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
            this.btnAgregarDocumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCuestionario = new System.Windows.Forms.Button();
            this.btnRepaso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarDocumento
            // 
            this.btnAgregarDocumento.Location = new System.Drawing.Point(143, 175);
            this.btnAgregarDocumento.Name = "btnAgregarDocumento";
            this.btnAgregarDocumento.Size = new System.Drawing.Size(101, 37);
            this.btnAgregarDocumento.TabIndex = 0;
            this.btnAgregarDocumento.Text = "Agregar Documento";
            this.btnAgregarDocumento.UseVisualStyleBackColor = true;
            this.btnAgregarDocumento.Click += new System.EventHandler(this.btnAgregarDocumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta FI";
            // 
            // btnCuestionario
            // 
            this.btnCuestionario.Location = new System.Drawing.Point(143, 133);
            this.btnCuestionario.Name = "btnCuestionario";
            this.btnCuestionario.Size = new System.Drawing.Size(101, 24);
            this.btnCuestionario.TabIndex = 0;
            this.btnCuestionario.Text = "Cuestionario";
            this.btnCuestionario.UseVisualStyleBackColor = true;
            this.btnCuestionario.Click += new System.EventHandler(this.btnCuestionario_Click);
            // 
            // btnRepaso
            // 
            this.btnRepaso.Location = new System.Drawing.Point(143, 85);
            this.btnRepaso.Name = "btnRepaso";
            this.btnRepaso.Size = new System.Drawing.Size(101, 23);
            this.btnRepaso.TabIndex = 0;
            this.btnRepaso.Text = "Repaso";
            this.btnRepaso.UseVisualStyleBackColor = true;
            this.btnRepaso.Click += new System.EventHandler(this.btnRepaso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCuestionario);
            this.Controls.Add(this.btnRepaso);
            this.Controls.Add(this.btnAgregarDocumento);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta FI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuestionario;
        private System.Windows.Forms.Button btnRepaso;
    }
}

