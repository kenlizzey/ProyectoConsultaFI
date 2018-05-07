using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class AgregarDocumento : Form
    {
        public AgregarDocumento()
        {
            InitializeComponent();
        }

        private void AgregarDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.consultaFI.Show();
        }
    }
}
