using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga
{
    public partial class Form1 : Form
    {
        Tablero tablero = new Tablero();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            tablero.plumaArriba();
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            tablero.plumaAbajo();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            tablero.Avanzar();
        }

        private void btnGirarIzquierda_Click(object sender, EventArgs e)
        {
            tablero.girarIzquierda();
        }

        private void btnGirarDerecha_Click(object sender, EventArgs e)
        {
            tablero.girarDerecha();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtTablero.Text = tablero.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
