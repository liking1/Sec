using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        DateTime date;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(label1_Click);
            timer.Start();
        }
        //private void tickTimer(object sender, EventArgs e)
        //{
        //    long tick = DateTime.Now.Ticks - date.Ticks;
        //    DateTime stopWatch = new DateTime();
        //    stopWatch = stopWatch.AddTicks(tick);
        //    label1.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        //}


        private void button2_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            Timer timer = new Timer();
            timer.Stop();
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            label1.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }
    }
}
