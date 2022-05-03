using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class Form1 : Form
    {
        private Thread ThreadFirstJob;
        private Thread ThreadSecndJob;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnAddControls_Click(object sender, EventArgs e)
        {
            PnlControls.Controls.Clear();
            int Count = Convert.ToInt32(TxtCount.Text);
            AddTextBoxInRuntime(Count);
        }


        private void AddTextBoxInRuntime(int ACount)
        {
            for (int sayi = 0; sayi < ACount; sayi++)
            {
                TextBox txtNumberBox = new TextBox();
                txtNumberBox.Name = "txtNumberBox_" + sayi.ToString();
                txtNumberBox.Left = 5;
                txtNumberBox.Top = (txtNumberBox.Height + 5) * sayi;
                txtNumberBox.Text = txtNumberBox.Name;
                PnlControls.Controls.Add(txtNumberBox);
            }

        }

        private void BtnRandomNumbers_Click(object sender, EventArgs e)
        {
            foreach (Control cntrl in PnlControls.Controls)
            {
                if (cntrl is TextBox)
                {
                    //TextBox textBox = cntrl as TextBox;
                    ((TextBox)cntrl).Text = GenerateRandomNumber().ToString();
                }
            }
        }

        private int GenerateRandomNumber()
        {
            int result = 0;
            Random Rnd = new Random();
            result = Rnd.Next(9999, 9999999);
            Thread.Sleep(2);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ring();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Thread Thr = new Thread(new ThreadStart(ThrWithRing));
            Thr.Start();
            //ThrWithRing();
        }

        private void Ring()
        {
            int i = 0;
            int j = 0;
            while (i < 1000)
            {
                Console.Write("Test");
                j = i.ToString().Length;
                if (j == 3)
                {
                    if (i % 2 == 1)
                        break;
                }
                if (j == 2)
                {
                    if (i % 2 == 0)
                        break;
                }
                i++;
            }
        }

        private void ThrWithRing()
        {
            int i = 0;
            while (true)
            {
                if (TxtLogs.Lines.Length > 10000)
                    TxtLogs.Clear();

                TxtLogs.Text += System.Environment.NewLine + "*" + i.ToString();
                Thread.Sleep(2);

                if (i > 1000)
                    break;

                i++;

            }
        }

        private void AddLog(string ALogText)
        {
            TxtLogs.Text += System.Environment.NewLine + "*" + ALogText;
        }

        private void FirstJob()
        {
            progressBar1.Minimum = 0;
            for (int i = 0; i < 1000; i++)
            {
                progressBar1.Value = i;
                AddLog(i.ToString());
            }
        }
        private void SeconJob()
        {
            progressBar2.Minimum = 1001;
            for (int i = 1001; i < 2001; i++)
            {
                progressBar2.Value = i;
                AddLog(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ThreadFirstJob == null || ThreadFirstJob.ThreadState == ThreadState.Aborted)
                ThreadFirstJob = new Thread(new ThreadStart(FirstJob));

            if (ThreadSecndJob == null || ThreadSecndJob.ThreadState == ThreadState.Aborted)
                ThreadSecndJob = new Thread(new ThreadStart(SeconJob));

            if (ThreadFirstJob.ThreadState != ThreadState.Running)
                ThreadFirstJob.Start();

            if (ThreadSecndJob.ThreadState != ThreadState.Running)
                ThreadSecndJob.Start();

            //FirstJob();
            //SeconJob();

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (ThreadFirstJob != null)
            {
                if (ThreadFirstJob.ThreadState != ThreadState.Aborted)
                    ThreadFirstJob.Abort();
            }

            if (ThreadSecndJob != null)
            {
                if (ThreadSecndJob.ThreadState != ThreadState.Aborted)
                    ThreadSecndJob.Abort();
            }

            progressBar1.Value = 0;
            progressBar2.Value = 1001;
        }
    }
}
