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
    public partial class Form6 : Form
    {
        public Form6()
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
            int a, b, sum=0;
            a=Convert.ToInt32(this.textBox1.Text);
            b=Convert.ToInt32(this.textBox2.Text);  
            for (int i=a;i<=b;i++)
            {
                sum=sum+(i*i);
                listBox1.Items.Add(i);
            }
            listBox1.Items.Add("Сумма: " + sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }
    }
}
