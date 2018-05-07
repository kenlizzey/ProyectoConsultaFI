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
            Repaso nuevoRepaso = new Repaso();
            nuevoRepaso.Show();
            Program.consultaFI.Hide();
        }

        private void btnCuestionario_Click(object sender, EventArgs e)
        {
            Cuestionario nuevoCuestionario = new Cuestionario();
            MessageBox.Show("Instrucciones");
            nuevoCuestionario.Show();
            Program.consultaFI.Hide();
        }

        private void btnAgregarDocumento_Click(object sender, EventArgs e)
        {
            AgregarDocumento nuevoAgregarDocumento = new AgregarDocumento();
            nuevoAgregarDocumento.Show();
            Program.consultaFI.Hide();
        }
    }
}
