using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        Thread th1;
        Random rdm;
        private void button1_Click(object sender, EventArgs e)
        {

            th = new Thread(thread);
            th.Start();
        }

        public void thread()
        {
            for (int i=0; i<200; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Red");
        }


        public void threadb()
        {
            for (int i = 0; i < 200; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Black");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            th1 = new Thread(threadb);
            th1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }
    }
}
