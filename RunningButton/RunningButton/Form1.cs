using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButton
{
    public delegate void HelperToCAll(Button btn);
    public partial class Form1 : Form
    {
       /// кнопки от 1 до 4 , патоки
        private Thread t1; 
        private Thread t2;
        private Thread t3;
        private Thread t4;
        private HelperToCAll helper;
        private Random r; // random generate
        private Random randomStep;
        public Form1()
        {
            InitializeComponent();
            helper =new HelperToCAll(Moution);
            r = new Random();
            randomStep = new Random();
        }


        private void Moution(Button button)
        {
            button.Location = new Point(button.Location.X +r.Next(4),button.Location.Y);
        }

        void Btn1Moution()
        {
            while (true)
            {
                Thread.Sleep(randomStep.Next(50,100));
                Invoke(helper, button1);
            }
        }

        void Btn2Moution()
        {
            while (true)
            {
                Thread.Sleep(randomStep.Next(50, 100));
                Invoke(helper, button2);
            }
        }

        void Btn3Moution()
        {
            while (true)
            {
                Thread.Sleep(randomStep.Next(50, 100));
                Invoke(helper, button3);
            }
        }

        void Btn4Moution()
        {
            while (true)
            {
                Thread.Sleep(randomStep.Next(50, 100));
                Invoke(helper, button4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
           
                t1 = new Thread(Btn1Moution);
                t2 = new Thread(Btn2Moution);
                t3 = new Thread(Btn3Moution);
                t4 = new Thread(Btn4Moution);

                t1.IsBackground = t2.IsBackground = t3.IsBackground = t4.IsBackground = true;

                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                button5.Enabled = true;
                t2.Suspend();
                t1.Suspend();
                t3.Suspend();
                t4.Suspend();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6_Click(sender,e);
            button1.Location = new Point(12, button1.Location.Y);
            button2.Location = new Point(12, button2.Location.Y);
            button3.Location = new Point(12,button3.Location.Y);
            button4.Location = new Point(12,button4.Location.Y);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t1.Abort();
            t2.Abort();
            t3.Abort();
            t4.Abort();
        }
    }
}
