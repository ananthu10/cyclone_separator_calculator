using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyclone_separator
{
    public partial class Form1 : Form
    {

        double a, b, c, d, ed;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }

        double num, deno,D,V,T;
        double pi = Math.PI;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox1.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox3.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox4.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox5.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);
            ed= Convert.ToDouble(textBox4.Text);
            num = (b * b * 384 * a * pi * (c - d));
            deno = 9 * ed;
            T = num / deno;
           D = Math.Ceiling(Math.Pow(T, (double)1 / 3));
            V =((8*a)* System.Math.Pow(D,2));
            //length_of_cone = exhaust_gas_flow_rate + cutdown_particle_size;

            textBox15.Text = D.ToString();
            textBox6.Text = (2 * D).ToString();
            textBox7.Text = (2 * D).ToString();
            textBox8.Text = (D/2).ToString();
            textBox9.Text = (D/4).ToString();
            textBox10.Text = (D / 2).ToString();
            textBox11.Text = (D / 4).ToString();
            textBox12.Text = (0.625* D).ToString();
            textBox13.Text = (4* D).ToString();

            textBox14.Text = V.ToString();




        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
