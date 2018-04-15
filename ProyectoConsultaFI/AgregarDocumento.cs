using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
