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
    public partial class Formulario_Login : Form
    {
        public Formulario_Login()
        {
            InitializeComponent();
        }

        private void Formulario_Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_conexion conexion = new cls_conexion();
            if (conexion.Validar(textBox1.Text, textBox2.Text) == true)
            {
                this.Hide();
                menu principal = new menu();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox1.Clear();
                textBox1.Focus();
            }

        }
    }
}
