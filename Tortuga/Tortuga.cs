using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga
{
    class Tortuga
    {
        private int _posicionRenglon;
        private int _posicionColumna;
        private int _direccion;
        private int _pluma;

        public int PosicionRenglon
        {
            get { return _posicionRenglon; }
            set { _posicionRenglon = value; }
        }
        public int PosicionColumna
        {
            get { return _posicionColumna; }
            set { _posicionColumna = value; }
        }
        public int Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public int Pluma
        {
            get { return _pluma; }
            set { _pluma = value; }
        }

        public Tortuga()
        {
            _posicionColumna = 0;
            _posicionRenglon= 0;
            _direccion = 1;
            _pluma = 0;
        }
    }
}
