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
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single num1, num2, total;
            // se declaran las variables que utilizaremos

            //se le asigna el valor de la caja de texto
            num1 = Single.Parse(textBox1.Text);
            num2 = Single.Parse(textBox2.Text);

            //realizamos la suma

            //se almacena en la variable total
            total = num1 + num2;

            //y se muestra el resultado en la caja de texto 3
            //pero antes debemos convertirlo a un string
            textBox3.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Single num1, num2, total;
            // se declaran las variables que utilizaremos

            //se le asigna el valor de la caja de texto
            num1 = Single.Parse(textBox1.Text);
            num2 = Single.Parse(textBox2.Text);

            //realizamos la resta

            //se almacena en la variable total
            total = num1 - num2;

            //y se muestra el resultado en la caja de texto 3
            //pero antes debemos convertirlo a un string
            textBox3.Text = total.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Single num1, num2, total;
            // se declaran las variables que utilizaremos

            //se le asigna el valor de la caja de texto
            num1 = Single.Parse(textBox1.Text);
            num2 = Single.Parse(textBox2.Text);

            //realizamos la multiplicacion

            //se almacena en la variable total
            total = num1 * num2;

            //y se muestra el resultado en la caja de texto 3
            //pero antes debemos convertirlo a un string
            textBox3.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Single num1, num2, total;
            // se declaran las variables que utilizaremos

            //se le asigna el valor de la caja de texto
            num1 = Single.Parse(textBox1.Text);
            num2 = Single.Parse(textBox2.Text);

            //utilizamos la condicional if-else

            if (num2 == 0)
            {
                //mostramos el tercer label 
                label4.Visible = true;
            }
            else
            {
                // de lo contrario lo ocultamos
                label4.Visible = false;
            }

            //realizamos la divicion

            //se almacena en la variable total
            total = num1 / num2;

            //y se muestra el resultado en la caja de texto 3
            //pero antes debemos convertirlo a un string
            textBox3.Text = total.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //para limpiar debemos usar la funcion clear()
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // ponemos el foco en la primera caja de texto
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //para salir se utiliza la funcion close()

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
