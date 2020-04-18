using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;



namespace serpiente
{
    class Pantalla : Manzana
    {
        public Pantalla(int Ancho, int Altura):base(Ancho,Altura) 
        {

            this.Altura = Altura;
            this.Ancho = Ancho;
            FinDelJuego = false;
            dato = false;
        }

        //Función importante, Muestra y Analiza los movimientos.
        public void Esenario(int x, int y, string O, int[] Xcola, int[] Ycola)
        {
            Console.Clear();
            //Llama a la funcion para renovar los valores

            if (dato == false)
            {
                CoorManzanas = GetManzanas();
            }
            Console.Write("\t\t\t\t");
            for (int i = 0; i < Ancho + 2; i++)
            {
                SetColor(ConsoleColor.White);
                Console.Write("*");
            }
            Puntos(Punto);
            Console.WriteLine();


            for (int i = 0; i < Altura; i++)
            {
                Console.Write("\t\t\t\t");
                for (int j = 0; j <= Ancho; j++)
                {

                    if (j == 0)
                    {
                        SetColor(ConsoleColor.White);
                        Console.Write("*");
                    }

                    if (j == Ancho)
                    {
                        SetColor(ConsoleColor.White);
                        Console.Write("*");
                    }
                    
                    if (i == y && j == x)
                    {
                        SetColor(ConsoleColor.Green);
                        Console.Write(O);
                    }
                    //Aqui puede poner un valor random
                    else if (i == CoorManzanas[1] && j == CoorManzanas[0])
                    {
                        dato = true;
                        SetColor(ConsoleColor.Red);
                        Console.Write("M");
                    }
                    else
                    {
                        bool Imprimir = false;
                        for (int k = 0; k < Ncolas; k++)
                        {
                            if (Xcola[k] == j && Ycola[k] == i)
                            {
                                SetColor(ConsoleColor.DarkGreen);
                                Console.Write("o");
                                Imprimir = true;
                            }

                        }
                        if (!Imprimir)
                        {
                            Console.Write(" ");
                        }
                        
                    }


                    //Limites de pantalla.
                    if (y > Altura - 1 || y < 0 || x > Ancho - 1 || x < 0)
                    {
                        SetFinJuego(true);
                    }



                }
                
                Console.WriteLine();
            }
            Console.Write("\t\t\t\t");
            for (int i = 0; i < Ancho + 2; i++)
            {
                SetColor(ConsoleColor.White);
                Console.Write("*");
            }
            Thread.Sleep(30);

        }

        public void Setcontrol(int Pts, int Colas)
        {
            dato = false;
            Punto = Pts * 10;
            Ncolas = Colas;
        }

        public int[] GetTest()
        {
            return CoorManzanas;
        }

        public void PanFinDelJuego()
        {
            SetColor(ConsoleColor.Yellow);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //No modificar las letras :)
            Console.WriteLine("\t\t ________  __                        __            __                                                         ");
            Console.WriteLine("\t\t|        \\|  \\                      |  \\          |  \\                                                        ");
            Console.WriteLine("\t\t| $$$$$$$$ \\$$ _______          ____| $$  ______  | $$             __  __    __   ______    ______    ______  ");
            Console.WriteLine("\t\t| $$__    |  \\|       \\        /      $$ /      \\ | $$            |  \\|   \\ |  \\ /      \\  /      \\  /      \\ ");
            Console.WriteLine("\t\t| $$  \\   | $$| $$$$$$$\\      |  $$$$$$$|  $$$$$$\\| $$             \\$$| $$  | $$|  $$$$$$\\|  $$$$$$\\|  $$$$$$\\");
            Console.WriteLine("\t\t| $$$$$   | $$| $$  | $$      | $$  | $$| $$    $$| $$            |  \\| $$  | $$| $$    $$| $$  | $$| $$  | $$");
            Console.WriteLine("\t\t| $$      | $$| $$  | $$      | $$__| $$| $$$$$$$$| $$            | $$| $$__/ $$| $$$$$$$$| $$__| $$| $$__/ $$");
            Console.WriteLine("\t\t| $$      | $$| $$  | $$       \\$$    $$ \\$$     \\| $$            | $$ \\$$    $$ \\$$     \\ \\$$    $$ \\$$    $$");
            Console.WriteLine("\t\t \\$$       \\$$ \\$$   \\$$        \\$$$$$$$  \\$$$$$$$ \\$$       __   | $$  \\$$$$$$   \\$$$$$$$ _\\$$$$$$$  \\$$$$$$ ");
            Console.WriteLine("\t\t                                                            |  \\__/ $$                    |  \\__| $$          ");
            Console.WriteLine("\t\t                                                             \\$$    $$                     \\ $$   $$          ");
            Console.WriteLine("\t\t                                                              \\$$$$$$                       \\ $$$$$$       ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            SetColor(ConsoleColor.White);
        }

        public  void SetFinJuego(bool FindelJuego)
        {
            this.FinDelJuego = FindelJuego;
        }

        public bool GetFinJuego()
        {
            return FinDelJuego;
        }

        private void SetColor(ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
        }

        private bool FinDelJuego = false, dato = false;
        private int[] CoorManzanas = new int[2]; 
        private int Ancho;
        private int Altura;
        private int Ncolas =0, Punto =0;
    }
}
