using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formacikl
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(this.textBox1.Text);
            double z;
            for (int i = -5; i <= 6; i++)
            {
                if (i != 0)
                {
                    z = n / i;
                    listBox1.Items.Add(n + " / " + i + " = " + z);
                }
                if (i==0)
                {
                    listBox1.Items.Add( "i = 0 ");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
