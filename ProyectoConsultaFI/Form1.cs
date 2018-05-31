using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            if (this.miPanelContenedor.Controls.Count > 0)
            {
                this.miPanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.miPanelContenedor.Controls.Add(fh);
            this.miPanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true; 
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Para poder mover la ventana a voluntad.
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




    }
}
