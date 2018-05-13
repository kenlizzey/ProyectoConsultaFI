using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class Cuestionario : Form
    {
        ArrayList Preguntas;
        public int NumeroPregunta = 0;
        //Se crea una variable aleatoria para elegir el índice de la colección de Preguntas (va de 0 a 20).
        Random PreAle = new Random();
        byte puntaje = 0;
        //Se crea una lista de 20 elementos [índices de 0 a 19]
        List<int> Numeros = new List<int>() { 20, 1, 19, 2, 18, 3, 17, 4, 16, 5, 15, 6, 14, 7, 13, 8, 12, 9, 11, 10 };

        public void ConstruirCuestionario()
        {
            /*Se asigna un número aleatorio del 0 al 19 a la variable entera "Ale". 
                Esta variable fungirá como un índice para eliminar de la lista de 20 elementos el valor aleatorio devuelto.
                  Finalmente la lista quedará com 10 elementos. 
             */
            int c = 19;
            //El for irá de 0 a 9 -> Eliminará 10 elementos de la lista compuesta por 20 elementos.
            for (int i = 0; i < 10; i++)
            {
                int Ale = PreAle.Next(0, c);
                Numeros.RemoveAt(Ale);
                c = c - 1; 
            }
            
            //Se Crea la colección de 20 preguntas con respuestas. 
            Preguntas = new ArrayList();

            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta1", "RA", "RB", "RCCC", "RB", '1')); //Pregunta 1
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta2", "RA2", "RB", "RCCC", "RB", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta3", "RA3", "RB", "RCCC", "RB", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta4", "RA4", "RB", "RCCC", "RB", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta5", "RA5", "RB", "RCCC", "RB", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta6", "RA6", "RB", "RCCC", "RB",'2'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta7", "RA7", "RB", "RCCC", "RB",'2'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta8", "RA8", "RB", "RCCC", "RB",'2'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta9", "RA9", "RB", "RCCC", "RB",'2'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta10", "RA10", "RB", "RCCC", "RB",'2')); //Pregunta 10
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta11", "RA11", "RB", "RCCC", "RB", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta12", "RA12", "RB", "RCCC", "RB",'3'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta13", "RA13", "RB", "RCCC", "RB",'3'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta14", "RA14", "RB", "RCCC", "RB", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta15", "RA15", "RB", "RCCC", "RB", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta16", "RA16", "RB", "RCCC", "RB", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta17", "RA17", "RB", "RCCC", "RB", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta18", "RA18", "RB", "RCCC", "RB", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta19", "RA19", "RB", "RCCC", "RB", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro("Pregunta20", "RA20", "RB", "RCCC", "RB", '4')); //Pregunta 20
        }

        public Cuestionario()
        {
            ConstruirCuestionario();

            //PreguntasDelCuestionaro Pregunta = (PreguntasDelCuestionaro)Preguntas[Aleatorio[NumeroPregunta]];
            PreguntasDelCuestionaro Pregunta = (PreguntasDelCuestionaro)Preguntas[Numeros[NumeroPregunta]];
            InitializeComponent();
            TiempoCuestionario.Start();
            Minutos.Text = "19";

            lbPregunta.Text = (++NumeroPregunta).ToString() + "-. " + Pregunta.Pregunta;
            radboA.Text = "A) " + Pregunta.R1;
            radboB.Text = "B) " + Pregunta.R2;
            radboC.Text = "C) " + Pregunta.R3;
        }

        private void Cuestionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            TiempoCuestionario.Stop();
            Program.consultaFI.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (NumeroPregunta < 10)
            {
                //PreguntasDelCuestionaro Pregunta = (PreguntasDelCuestionaro)Preguntas[Aleatorio[NumeroPregunta]];
                PreguntasDelCuestionaro Pregunta = (PreguntasDelCuestionaro)Preguntas[Numeros[NumeroPregunta]];
                //Aumenta el puntaje obtenido por el usuario.
                if (radboA.Checked)
                {
                    if (Pregunta.R1 == Pregunta.rCorrecta)
                    {
                        puntaje++;
                    }
                }
                else if (radboB.Checked)
                {
                    if (Pregunta.R2 == Pregunta.rCorrecta)
                    {
                        puntaje++;
                    }
                }
                else if (radboC.Checked)
                {
                    if (Pregunta.R1 == Pregunta.rCorrecta)
                    {
                        puntaje++;
                    }
                }

                //Verifica que por lo menos un RadioButton está seleccionado para cambiar de pregunta.
                if (radboA.Checked || radboB.Checked || radboC.Checked)
                {
                    lbPregunta.Text = (++NumeroPregunta).ToString() + "-. " + Pregunta.Pregunta;
                    radboA.Text = "A) " + Pregunta.R1;
                    radboB.Text = "B) " + Pregunta.R2;
                    radboC.Text = "C) " + Pregunta.R3;
                    
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
            }
        }


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
            }
        }
    }
}
