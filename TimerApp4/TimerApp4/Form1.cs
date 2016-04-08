﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp4
{
    public partial class Form1 : Form
    {
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("Timer started");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    timer1.Stop();
        //    MessageBox.Show("Hello");
        //}
    }
}
