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

            Preguntas.Add(new PreguntasDelCuestionaro("¿Cuál es la raíz del siguiente polinomio? \n P(X)=X^3-3X^2+2", "2,3-sqrt(2)", "1,1+sqrt(3), 1-sqrt(3)", "-1+sqrt(3),1,-1", "-2,1+sqrt(2)", '1')); //Pregunta 1
            Preguntas.Add(new PreguntasDelCuestionaro(" Factoriza el siguiente polinomio aplicando las reglas notables: X^2-4 ", "x=1,x=2", "x=-1,X=-2", "x=1,x=2", "x=-1,X=2", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Descompón en factores este polinomio y encuentra sus raíces \n 6X^4-5x^3-23^2+20-4", "(x+2)(x-2)(2x-1)(3x-1) \n las raíces: -2,2,1/2,1/3", "(x+2)(x-3)(2x-1)(4x-1) \n las raíces: -2,3,1/2,1/4", "(x+2)(x-2)(2x+1)(3x+1) \n las raíces: -2,-2,1/2,-1/3", "RB", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro(" ¿Cuál es la raíz del siguiente polinomio? \n X^2-4x+4", "Raiz doble x=2", "x=-2", "Raíz doble =-1/2", "X=-1/2", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Encuentra la raíz del polinomio \n 2x^4+15x^3+31x^2+12x", "x(x+4)(x+3)(2x+1)", "2x(x-4)(x+3)(1/2x+1)", "x(x+4)(x+3)(2x-1)", "(x+4)(x+3)(2x-1)", '1'));
            Preguntas.Add(new PreguntasDelCuestionaro(" De las siguientes respuestas cúales ¿cuáles son las raíces del polinomio P(x)=x^2-5x-14?", "x=2,7", "x=3,6", "x=1,7", "2x=1,7", '2'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Por factores notables factoriza: \n P(X)=x^2+10x+25 ", "(X+5)^2", "(X-2)^2", "(X-8)^2", "(-X+2)^2", '2'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Encuentra los factores del polinomio:\n P(X)=3x^3-8x^2-20x+16 ", "(x+2)(x-4)(3x-2)", "(x+1)(3x-4)(x-2)", "(x+2)(x-4)(3x+2)", "(x+2)(x+4)(2x+2)", '2'));
            Preguntas.Add(new PreguntasDelCuestionaro(" A partir de la siguiente factorización, encuentre el polinomio \n (X-1)(X-2)(X-3) ", "X^4-9X^2+4X+12", "X^3-9X^2+4X+15", "X^4-11X^2-4X+12", "X^4-9X^2-8X+12", '2'));
            Preguntas.Add(new PreguntasDelCuestionaro(" ¿Cuál es la raíz del siguiente polinomio? \n 2x^3-3x^2-9x+10 ", "X=1,-2,10/4 ", "X=1/2,-1,1/4", "X=1,-2", "X=0,-2,10/4", '2')); //Pregunta 10
            Preguntas.Add(new PreguntasDelCuestionaro(" A partir de la siguiente factorización, encuentre el polinomio \n (X+1)(X-2)^2(X-3)", "X^3-2X^2-5X+6", "X^3-2X^2-5X-16", "2X^3-2X^2+5X+6", "X^3+2X^2-5X", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Descompón en factores este polinomio  \n  X^2+11X+24 ", "(X+3)(X+8)", "(X-3)(X+8)", "(X+3)(X-8)", "(X+3)(X+8)X", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Descompón en factores este polinomio  \n 3^3-8X^2-20X+16", "(X+2)(X-4)(3X-2)", "(X+2)(-X-4)(3X+2)", "X(X+2)(X-4)(3X-2)", "-X(X+2)(X+4)(3X-2)", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro(" ¿Cuál es el polinomio que tiene como raíces  \n x=1,x=2 ", "X^2+4 ", "-X^3-4 ", "2X^2+4 ", "1/2X^2-4 ", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Por factores notables factoriza: \n X^3-9^2+27X-27", "(X-3)^3", "(X-3)^2", "(-X-3)^3", "(X+3)^3", '3'));
            Preguntas.Add(new PreguntasDelCuestionaro(" Encuentra la raíz de x^2-2x+1 ", "Raíz doble=1", "Raíz doble=1y -1", "Raíz doble=1/2", "Raíz doble=-1/2", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro(" A partir de la siguiente factorización encuentra el polinomio \n (x-1)^2(x-3)", "x^4-9^2+4x+12", "2x^4-9^2+4x+12", "x^4+9^2+4x+113", "x^4-9^2-4x+12", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro(" ¿Cuál es el polinomio que tiene como raíces  \n x=1,1,3 ?", "x^4-9^2+4x+12", "x^4+4x+12", "x^4-9^2+4x-12", "-9^2+4x+12", '4'));
            Preguntas.Add(new PreguntasDelCuestionaro(" A partir de la siguiente factorización encuentra el polinomio  \n (x-2)(x-7)", "P(x)=x^2-5x-14", "P(x)=3x^2-5x-14", "P(x)=x^3-5x-14", "P(x)=x^2+5x+14", '4')); //Respuesta1
            Preguntas.Add(new PreguntasDelCuestionaro(" A partir de la siguiente factorización encuentra el polinomio \n (x+2)(x-4)(3x-2) ", "P(X)=3x^3-8x^2-20x+16 ", "P(X)=x^3-8x^2-20x-16 ", "P(X)=3x^3+10x^2-20x+16 ", "P(X)=x^3-8x^2+16 ", '4')); //Pregunta 20
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
