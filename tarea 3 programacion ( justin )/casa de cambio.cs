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
    public partial class casa_de_cambio : Form
    {
        public casa_de_cambio()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Double rd, us, total;

            us = 53.5;
            rd = double.Parse(textBox1.Text);

            total = rd / us;

            textBox2.Text = total.ToString();

            label2.Visible = true;
            textBox2.Visible = true;


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Double rd, eur, total;

            eur = 56.06;
            rd = double.Parse(textBox1.Text);

            total = rd / eur;

            textBox2.Text = total.ToString();

            label2.Visible = true;
            textBox2.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Double rd, us, total;

            us = 53.5;
            rd = double.Parse(textBox1.Text);

            total = rd * us;

            textBox2.Text = total.ToString();

            label2.Visible = true;
            textBox2.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Double rd, eur, total;

            eur = 56.06;
            rd = double.Parse(textBox1.Text);

            total = rd * eur;

            textBox2.Text = total.ToString();

            label2.Visible = true;
            textBox2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
