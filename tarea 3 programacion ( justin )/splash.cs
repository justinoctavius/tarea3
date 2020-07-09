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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int n = 0;
        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
      
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            progressBar1.Value = n;
            label2.Text = n.ToString();

            if (n == 100)
            {
                this.Hide();
                timer1.Stop();

                Formulario_Login login = new Formulario_Login();
                login.Show();
            }
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
