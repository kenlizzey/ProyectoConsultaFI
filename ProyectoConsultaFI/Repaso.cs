using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class Repaso : Form
    {
       
        public Repaso()
        {
            
            InitializeComponent();
        }

        private void Repaso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.consultaFI.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       





    }
}
