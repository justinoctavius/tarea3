using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_3_programacion___justin__
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculadora calculadora = new calculadora();
            calculadora.Show();
        }

        private void nominaSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nomina_semanal nsemanal = new nomina_semanal();
            nsemanal.Show();
        }

        private void casaDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            casa_de_cambio caCambio = new casa_de_cambio();
            caCambio.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
