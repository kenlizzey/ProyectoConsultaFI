using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoConsultaFI
{
    public partial class Cuestionario : Form
    {       
        //Se crea el cuestionario y se muestra la primer pregunta en pantalla.
        public Cuestionario()
        {
            ConstruirCuestionario();

            PreguntasDelCuestionaro MostrarPregunta = (PreguntasDelCuestionaro)Preguntas[Numeros[NumeroPregunta]];

            InitializeComponent();

            TiempoCuestionario.Start();

            Minutos.Text = "19";

            lbPregunta.Text = (++NumeroPregunta).ToString() + "-. " + MostrarPregunta.Pregunta;
            radboA.Text = "A) " + MostrarPregunta.R1;
            radboB.Text = "B) " + MostrarPregunta.R2;
            radboC.Text = "C) " + MostrarPregunta.R3;

            GraficaPuntosCorrectos.Hide();
        }

        //Cuando el usuario cierra el cuestionario. 
        private void Cuestionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            TiempoCuestionario.Stop();
            Program.consultaFI.Show();
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (NumeroPregunta < 10)
            {
                PreguntasDelCuestionaro MostrarPregunta = (PreguntasDelCuestionaro)Preguntas[Numeros[NumeroPregunta]];
                //Aumenta el puntaje obtenido por el usuario.
                if (radboA.Checked)
                {
                    if (MostrarPregunta.R1 == MostrarPregunta.rCorrecta)
                    {
                        puntaje++;
                        incorrecta[NumeroPregunta] = 0;
                    }
                    else
                    {
                        incorrecta[NumeroPregunta] = MostrarPregunta.Tema;
                        FilaRIncorrectas.Enqueue(NumeroPregunta);
                    }
                }
                else if (radboB.Checked)
                {
                    if (MostrarPregunta.R2 == MostrarPregunta.rCorrecta)
                    {
                        puntaje++;
                        incorrecta[NumeroPregunta] = 0;
                    }
                    else
                    {
                        incorrecta[NumeroPregunta] = MostrarPregunta.Tema;
                        FilaRIncorrectas.Enqueue(NumeroPregunta);
                    }
                }
                else if (radboC.Checked)
                {
                    if (MostrarPregunta.R1 == MostrarPregunta.rCorrecta)
                    {
                        puntaje++;
                        incorrecta[NumeroPregunta] = 0;
                    }
                    else
                    {
                        incorrecta[NumeroPregunta] = MostrarPregunta.Tema;
                        FilaRIncorrectas.Enqueue(NumeroPregunta);
                    }
                }

                //Verifica que por lo menos un RadioButton está seleccionado para cambiar de pregunta.
                if (radboA.Checked || radboB.Checked || radboC.Checked)
                {
                    lbPregunta.Text = (++NumeroPregunta).ToString() + "-. " + MostrarPregunta.Pregunta;
                    radboA.Text = "A) " + MostrarPregunta.R1;
                    radboB.Text = "B) " + MostrarPregunta.R2;
                    radboC.Text = "C) " + MostrarPregunta.R3;
                    
                }
                else
                {
                    MessageBox.Show("No puedes pasar a la siguiente pregunta hasta que hayas seleccionado una opción.");
                }

            }
            else
            {
                TiempoCuestionario.Stop();
                lbPregunta.Text = "Tuviste " + puntaje.ToString() + "respuestas correctas"; 
                radboA.Hide();
                radboB.Hide();
                radboC.Hide();
                Minutos.Hide();
                Segundos.Hide();
                label3.Hide();
                btnSiguiente.Hide();

                Graficando();

            }
        }

        //Aquí se implementa la cuenta regresiva de 19 minutos y 60 segundos. 
        int SegundosRestantes = 60;
        int MinutosRestantes = 19;
        private void TiempoCuestionario_Tick(object sender, EventArgs e)
        {
            if (MinutosRestantes >= 0 )
            {
                if (SegundosRestantes >= 0)
                {
                    SegundosRestantes = SegundosRestantes - 1;
                    if (SegundosRestantes < 10)
                    {
                        Segundos.Text = "0" + SegundosRestantes.ToString();
                    }
                    else
                    {
                        Segundos.Text = SegundosRestantes.ToString();
                    }
                }
                else
                {
                    SegundosRestantes = 60;
                    MinutosRestantes = MinutosRestantes - 1;
                    if (MinutosRestantes < 10)
                    {
                        Minutos.Text = "0" + MinutosRestantes.ToString();
                    }
                    else
                    {
                        Minutos.Text = MinutosRestantes.ToString();
                    }
                }
            }
            else
            {
                TiempoCuestionario.Stop();
                lbPregunta.Hide();
                radboA.Hide();
                radboB.Hide();
                radboC.Hide();
                Minutos.Hide();
                Segundos.Hide();
                label3.Hide();
                btnSiguiente.Hide();

                GraficaPuntosCorrectos.Hide();
            }
        }


        public int[] TemasIncorrectos(int[] TemasIncorrectos)
        {
            int tema1 = 0;
            int tema2 = 0;
            int tema3 = 0;
            int tema4 = 0;
            int[] Temas = new int[4];
            for (int i = 0; i < TemasIncorrectos.Length; i++)
            {
                if (TemasIncorrectos[i] == 1)
                {
                    tema1++;
                }
                else if (TemasIncorrectos[i] == 2)
                {
                    tema2++;
                }
                else if (TemasIncorrectos[i] == 3)
                {
                    tema3++;
                }
                else if (TemasIncorrectos[i] == 4)
                {
                    tema4++;
                }
            }

            Temas[0] = tema1; Temas[1] = tema2; Temas[2] = tema3; Temas[3] = tema4;
            return Temas; 
        }

        public void Graficando()
        {
            GraficaPuntosCorrectos.Show();
            string[] Temas = { "Tema 1", "Tema 2", "Tema 3", "Tema 4" };
            int[] MisErrores = TemasIncorrectos(incorrecta);
            GraficaPuntosCorrectos.Palette = ChartColorPalette.BrightPastel;
            GraficaPuntosCorrectos.Titles.Add("Temas en los que te has equivocado");

            for (int i = 0; i < Temas.Length; i++)
            {
                Series LosTemas = GraficaPuntosCorrectos.Series.Add(Temas[i]);
                LosTemas.Label = MisErrores[i].ToString();
                LosTemas.Points.Add(MisErrores[i]);
            }

        }

    }
}
