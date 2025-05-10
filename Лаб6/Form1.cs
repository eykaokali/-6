using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConeBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cone cone = new Cone();
            cone.H = Convert.ToDouble(textBox2.Text);
            cone.R = Convert.ToDouble(textBox1.Text);
            textBox5.Text = cone.GetVolume().ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pyramid pyramid = new Pyramid();
            pyramid.H = Convert.ToDouble(textBox4.Text);
            pyramid.A = Convert.ToDouble(textBox3.Text);
            textBox6.Text = pyramid.GetVolume().ToString();
        }
    }
}
