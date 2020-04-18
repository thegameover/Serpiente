using System;
using System.Threading;

/*
 * Esto solo fue como una practica para mejorar mi programación en c# y POO.
 * Se acepta Opiniones para poder mejorar, este año empeze estudiar poo.
 * "Programador": Omar alderete Molina.
 *
 * */


namespace serpiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 60);
            Jugador Pna = new Jugador(25, 30);

                while (!Pna.GetFinJuego())
                {

                    Pna.Logica();
                    Pna.Dibujo();
                    Pna.Control();

                }

                Pna.PanFinDelJuego();
                Thread.Sleep(1000);
        }

        
        
    }
}
