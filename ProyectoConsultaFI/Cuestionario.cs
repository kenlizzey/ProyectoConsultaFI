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
    public partial class Cuestionario : Form
    {
        public Cuestionario()
        {
            InitializeComponent();
        }

        private void Cuestionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.consultaFI.Show();
        }
    }
}
