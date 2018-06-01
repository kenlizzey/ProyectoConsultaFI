using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace ProyectoConsultaFI
{
    public partial class Repaso : Form
    {
		string rutaCarpeta = Application.StartupPath + @"\Repaso"; //Ruta donde van a estar los archivos


		public Repaso()
        {
            InitializeComponent();
			CrearCarpeta();
		}







		private void CrearCarpeta()
		{
			if (Directory.Exists(rutaCarpeta))
			{
				//VERIFICA QUE EXISTA LA CARPETA
			}
			else
			{
				Directory.CreateDirectory(rutaCarpeta);
			}

		}
		private void Repaso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.consultaFI.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		

		private void linkLabel1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Process proceso = new Process(); //Se va a encargar de abrir el archivo de inmediato
			proceso.StartInfo.FileName = rutaCarpeta + @"\definición.pdf";
			proceso.Start();
		}

		private void linkLabel2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Process proceso = new Process(); //Se va a encargar de abrir el archivo de inmediato
			proceso.StartInfo.FileName = rutaCarpeta + @"\divisivilidad.pdf";
			proceso.Start();

		}

		private void linkLabel3_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Process proceso = new Process(); //Se va a encargar de abrir el archivo de inmediato
			proceso.StartInfo.FileName = rutaCarpeta + @"\raícesde.pdf";
			proceso.Start();
		}

		private void linkLabel4_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Process proceso = new Process(); //Se va a encargar de abrir el archivo de inmediato
			proceso.StartInfo.FileName = rutaCarpeta + @"\DESCARTES.pdf";
			proceso.Start();
		}
	}
}
