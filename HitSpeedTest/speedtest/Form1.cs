using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace speedtest
{
    public partial class Form1 : Form
    {
        double life;
        double o_life;
        int count;
        long start;
        bool isend = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            isend = false;
        }
        void reset()
        {
            o_life = life = Convert.ToInt32(textBox1.Text);
            count = 0;
            timer1.Stop();
            timer1.Enabled = false;
            textBox1.Text = o_life.ToString();
            button1.Focus();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isend)
            {
                if (e.KeyData == Keys.Z || e.KeyData == Keys.X)
                {
                    if (timer1.Enabled == false)
                    {
                        start = DateTime.Now.Ticks;
                        timer1.Start();
                        textBox1.Enabled = false;
                    }
                    else

                        count++;
                }
            }
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = count.ToString();
            if (DateTime.Now.Ticks - start > life * 10000000)
            {
                textBox1.Text =((DateTime.Now.Ticks - start - life * 10000000)/10000000).ToString();
                timer1.Stop();
                textBox1.Enabled = true;
                isend = true;

                textBox1.Text = o_life.ToString();
                label2.Text ="你的手速为："+ ((count / life) * 60/4).ToString()+"bpm";
            }
        }
    }
}
