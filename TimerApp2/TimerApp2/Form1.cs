using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp2
{
    public partial class Form1 : Form
    {
        private static FileStream fs = new FileStream(@"D:\temp\TimerTutorial\mcb.txt", FileMode.OpenOrCreate, FileAccess.Write);
        private static StreamWriter m_streamWriter = new StreamWriter(fs);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_streamWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            m_streamWriter.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Write to the file using StreamWriter class
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.Write(" File Write Operation Starts : ");
            m_streamWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            m_streamWriter.WriteLine(" ===================================== \n");
            m_streamWriter.Flush();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
