using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String datos;
            a =int.Parse( textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
            datos = "resultado :" + r.ToString();
            label3.Text = datos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            datos = "resultado :" + r.ToString();
            label3.Text = datos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            datos = "resultado :" + r.ToString();
            label3.Text = datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a / b;
            datos = "resultado :" + r.ToString();
            label3.Text = datos;
        }
    }
}
