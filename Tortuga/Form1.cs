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
        Tortuga tortuga = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            tortuga.plumaArriba();
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            tortuga.plumaAbajo();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            tortuga.Avanzar();
        }

        private void btnGirarIzquierda_Click(object sender, EventArgs e)
        {
            tortuga.girarIzquierda();
        }

        private void btnGirarDerecha_Click(object sender, EventArgs e)
        {
            tortuga.girarDerecha();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtTablero.Text = tortuga.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
