using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRepaso_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new Repaso());
        }

        private void btnCuestionario_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new Cuestionario());
        }

        private void btnAgregarDocumento_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AgregarDocumento());
        }

        //Función para mostrar los formularios en el panel
        private void AbrirFormHijo(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }



    }
}
