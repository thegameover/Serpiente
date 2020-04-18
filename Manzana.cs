using System;
using System.Collections.Generic;
using System.Text;

namespace serpiente
{
    class Manzana
    {
        Random RManzanas = new Random();
        public Manzana(int FrutaX, int FrutaY)
        {
            this.FrutaX = FrutaX;
            this.FrutaY = FrutaY;
        }

        public void Puntos(int Puntuacion)
        {
            Console.Write("\t\t");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Puntos: " + Puntuacion);
        }
        public int[] GetManzanas()
        {
            int[] Coor = new int[2];

            Coor[0] = RManzanas.Next(FrutaX - 2);
            Coor[1] = RManzanas.Next(FrutaY - 2);

            return Coor;
        }

        private int FrutaX, FrutaY;
    }
}
