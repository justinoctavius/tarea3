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
    public partial class nomina_semanal : Form
    {
        public nomina_semanal()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //declarar las variables
            int hn, he,he_total, total,lu,ma,mi,ju,vi,sa,dom;

            //luego se almacena los valores de los textbox
            lu = int.Parse(textBox1.Text);
            ma = int.Parse(textBox2.Text);
            mi = int.Parse(textBox3.Text);
            ju = int.Parse(textBox4.Text);
            vi = int.Parse(textBox5.Text);
            sa = int.Parse(textBox6.Text);
            dom = int.Parse(textBox7.Text);

            //se suman todos los valores
            hn = lu + ma + mi + ju + vi + sa + dom;

            //y se comparan si el total de la suma es mayor a cuarenta
            if ( hn > 40 )
            {

                //se  saca el total de las horas extras
                he_total = hn - 40;

                //se calcula el sueldo a pagar por las horas Extras
                he = he_total * 300;

                //y se calcula el suedo total a pagar
                total = (hn * 220) + he;


                //se imprimen estos valores en los cuadros de textos
                textBox8.Text = he_total.ToString();

                textBox10.Text = total.ToString();
            }
            else
            {
                //por el contrario se reduce las horas extras a 0
                he = 0;

                //se calcula el total a pagar
                total = hn * 220;

                //se imprime en los textbox
                textBox8.Text = he.ToString();

                textBox10.Text = total.ToString();

            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //para limpiar se utiliza el clear()

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
