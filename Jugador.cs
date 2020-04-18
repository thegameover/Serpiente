using System;
using System.Collections.Generic;
using System.Text;

namespace serpiente
{
    class Jugador : Pantalla
    {

        public Jugador(int x, int y) : base(x, y)
        {
            this.x = x/2;
            this.y = y/2;
            Dir = eDirreciones.Parar;
            
        }

        public void Control()
        {
            //Controles de Movimiento.
            if(Console.KeyAvailable)
            {
                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'a':
                        Dir = eDirreciones.Izquierda;
                        break;
                    case 'd':
                        Dir = eDirreciones.Derecha;
                        break;
                    case 'w':
                        Dir = eDirreciones.Arriba;
                        break;
                    case 's':
                        Dir = eDirreciones.Abajo;
                        break;
                    //case 'x':
                    //    SetFinJuego(true);
                    //    break;
                }
            }
        }

        public void Dibujo()
        {
            Esenario(x, y, "O", ColaX, ColaY);
        }

        public void Logica()
        {
            int[] Fruta = GetTest();
            int PrevX = ColaX[0];
            int PrevY = ColaY[0];
            int Prev2X, Prev2Y;
            ColaX[0] = x;
            ColaY[0] = y;

            for (int i = 1; i < NumeroDeCola; i++)
            {
                Prev2X = ColaX[i];
                Prev2Y = ColaY[i];
                ColaX[i] = PrevX;
                ColaY[i] = PrevY;
                PrevX = Prev2X;
                PrevY = Prev2Y;
                
            }

            for(int i = 1; i <NumeroDeCola; i++)
            {
                if (ColaX[i] == x && ColaY[i] == y)
                {
                    SetFinJuego(true);
                }
            }

                

            switch (Dir)
                //Acción del movimiento.
            {
                case eDirreciones.Izquierda:
                    x--;
                    break;
                case eDirreciones.Derecha:
                    x++;
                    break;
                case eDirreciones.Abajo:
                    y++;
                    break;
                case eDirreciones.Arriba:
                    y--;
                    break;
            }

            //Si choca con la fruta cambia de funcion y incrementa puntos.
            if (y == Fruta[1] && x == Fruta[0])
            {
                NumeroDeCola++;
                Punt++;
                Setcontrol(Punt, NumeroDeCola);
            }
        }

        private int x, y;
        private int[] ColaX = new int[100];
        private int[] ColaY = new int[100];
        private int NumeroDeCola = 0, Punt =0;

        private enum eDirreciones { Parar = 0, Izquierda, Derecha, Arriba, Abajo }
        eDirreciones Dir;

    }
}
