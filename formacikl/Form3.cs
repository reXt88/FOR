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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(textBox1.Text);
            int sum = 0;
            if (n !=0)
            {
                for (int i = 1; i <= n;i++)
                {
                    listBox1.Items.Add(sum+" + " + i + " = " + (sum+i));
                    sum = sum = i;
                }
            }
            if (n == 0)
            {
                MessageBox.Show("n не может быть 0");
            }
            if (n < 0)
            {
                MessageBox.Show("n не может быть отрицательным");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
