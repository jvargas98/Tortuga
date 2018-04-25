using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga
{
    class Tablero
    {
        private int[,] tablero = new int[20, 20];
        Tortuga tortuga;
        public Tablero()
        {
            Tortuga tortugaaux = new Tortuga();
            tortuga = tortugaaux;
        }
        public void Avanzar()
        {
            if (tortuga.Direccion == 1)
            {
                tortuga.PosicionColumna += 1;
                if (tortuga.Pluma == 1)
                {
                    tablero[tortuga.PosicionRenglon, tortuga.PosicionColumna] = 1;
                }
            }
            else if (tortuga.Direccion == 2)
            {
                tortuga.PosicionRenglon += 1;
                if (tortuga.Pluma == 1)
                {
                    tablero[tortuga.PosicionRenglon, tortuga.PosicionColumna] = 1;
                }
            }
            else if (tortuga.Direccion == 3)
            {
                tortuga.PosicionColumna -= 1;
                if (tortuga.Pluma == 1)
                {
                    tablero[tortuga.PosicionRenglon, tortuga.PosicionColumna] = 1;
                }
            }
            else
            {
                tortuga.PosicionRenglon -= 1;
                if (tortuga.Pluma == 1)
                {
                    tablero[tortuga.PosicionRenglon, tortuga.PosicionColumna] = 1;
                }
            }
        }

        public void girarDerecha()
        {
            tortuga.Direccion += 1;
        }

        public void girarIzquierda()
        {
            tortuga.Direccion -= 1;
        }

        public void plumaArriba()
        {
            tortuga.Pluma = 0;
        }

        public void plumaAbajo()
        {
            tortuga.Pluma = 1;
        }

        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    cadena += tablero[i, j] + " ";
                }
                cadena += Environment.NewLine;
            }
            return cadena;
        }
    }
}
