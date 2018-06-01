using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class SalirCuestionario : Form
    {
        Cuestionario formPadre;
        public SalirCuestionario(Cuestionario formPadre)
        {
            this.formPadre = formPadre;
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            formPadre.CerrarNoCerrar = 1;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            formPadre.CerrarNoCerrar = 0;
            this.Close();
        }
    }
}
