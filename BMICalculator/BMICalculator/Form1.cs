using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        double wt;
        double ht;
        double cBMI;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Height.Clear();
            Weight.Clear();
            CalcBMI.Clear();
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcBMI.BackColor = Color.AliceBlue;

            ht = Double.Parse(Height.Text);
            wt = Double.Parse(Weight.Text);
            cBMI = wt / ((ht * ht) * 703);
            CalcBMI.Text = String.Format ("{0:f}", 3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
