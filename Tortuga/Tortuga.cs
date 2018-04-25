using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga
{
    class Tortuga
    {
        private int[,] tablero = new int[20, 20];
        private int _posicionRenglon;
        private int _posicionColumna;
        private int _direccion;
        private int _pluma;

        public Tortuga()
        {
            _posicionColumna = 0;
            _posicionRenglon= 0;
            _direccion = 1;
            _pluma = 0;
        }

        public void Avanzar()
        {
            if (_direccion == 1)
            {
                _posicionColumna += 1;
                if (_posicionColumna > 19)
                    _posicionColumna = 0;
                if (_pluma == 1)
                {
                    tablero[_posicionRenglon, _posicionColumna] = 1;
                }
            }
            else if (_direccion == 2)
            {
                _posicionRenglon += 1;
                if (_posicionRenglon > 19)
                    _posicionRenglon = 0;
                if (_pluma == 1)
                {
                    tablero[_posicionRenglon, _posicionColumna] = 1;
                }
            }
            else if (_direccion == 3)
            {
                _posicionColumna -= 1;
                if (_posicionColumna < 0)
                    _posicionColumna = 19;
                if (_pluma == 1)
                {
                    tablero[_posicionRenglon, _posicionColumna] = 1;
                }
            }
            else
            {
                _posicionRenglon -= 1;
                if (_posicionRenglon < 0)
                    _posicionRenglon = 19;
                if (_pluma == 1)
                {
                    tablero[_posicionRenglon, _posicionColumna] = 1;
                }
            }
        }

        public void girarDerecha()
        {
            _direccion += 1;
            if (_direccion > 3)
                _direccion = 0;
        }

        public void girarIzquierda()
        {
            _direccion -= 1;
            if (_direccion < 0)
                _direccion = 3;
        }

        public void plumaArriba()
        {
            _pluma = 0;
        }

        public void plumaAbajo()
        {
            _pluma = 1;
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
