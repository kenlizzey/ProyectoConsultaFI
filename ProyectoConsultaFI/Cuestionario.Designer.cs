namespace ProyectoConsultaFI
{
    partial class Cuestionario
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
            this.components = new System.ComponentModel.Container();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.radboA = new System.Windows.Forms.RadioButton();
            this.radboC = new System.Windows.Forms.RadioButton();
            this.radboB = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TiempoCuestionario = new System.Windows.Forms.Timer(this.components);
            this.Minutos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Segundos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPregunta
            // 
            this.lbPregunta.Location = new System.Drawing.Point(41, 33);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(500, 31);
            this.lbPregunta.TabIndex = 0;
            this.lbPregunta.Text = "Pregunta";
            // 
            // radboA
            // 
            this.radboA.AutoSize = true;
            this.radboA.Location = new System.Drawing.Point(21, 155);
            this.radboA.Name = "radboA";
            this.radboA.Size = new System.Drawing.Size(37, 17);
            this.radboA.TabIndex = 1;
            this.radboA.TabStop = true;
            this.radboA.Text = "a) ";
            this.radboA.UseVisualStyleBackColor = true;
            // 
            // radboC
            // 
            this.radboC.AutoSize = true;
            this.radboC.Location = new System.Drawing.Point(415, 155);
            this.radboC.Name = "radboC";
            this.radboC.Size = new System.Drawing.Size(34, 17);
            this.radboC.TabIndex = 1;
            this.radboC.TabStop = true;
            this.radboC.Text = "c)";
            this.radboC.UseVisualStyleBackColor = true;
            // 
            // radboB
            // 
            this.radboB.AutoSize = true;
            this.radboB.Location = new System.Drawing.Point(232, 155);
            this.radboB.Name = "radboB";
            this.radboB.Size = new System.Drawing.Size(34, 17);
            this.radboB.TabIndex = 1;
            this.radboB.TabStop = true;
            this.radboB.Text = "b)";
            this.radboB.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(415, 269);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente Pregunta";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // TiempoCuestionario
            // 
            this.TiempoCuestionario.Interval = 50;
            this.TiempoCuestionario.Tick += new System.EventHandler(this.TiempoCuestionario_Tick);
            // 
            // Minutos
            // 
            this.Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutos.Location = new System.Drawing.Point(442, 223);
            this.Minutos.Name = "Minutos";
            this.Minutos.Size = new System.Drawing.Size(30, 23);
            this.Minutos.TabIndex = 4;
            this.Minutos.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // Segundos
            // 
            this.Segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Segundos.Location = new System.Drawing.Point(478, 223);
            this.Segundos.Name = "Segundos";
            this.Segundos.Size = new System.Drawing.Size(32, 24);
            this.Segundos.TabIndex = 5;
            this.Segundos.Text = "--";
            // 
            // Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 316);
            this.Controls.Add(this.Segundos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Minutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radboC);
            this.Controls.Add(this.radboA);
            this.Controls.Add(this.radboB);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lbPregunta);
            this.Name = "Cuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuestionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cuestionario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.RadioButton radboA;
        private System.Windows.Forms.RadioButton radboC;
        private System.Windows.Forms.RadioButton radboB;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TiempoCuestionario;
        private System.Windows.Forms.Label Minutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Segundos;
    }
}