using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class TimerInterface : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        int credits =0;
        int creditIncrementEvery = 3;

        public TimerInterface()
        {
            InitializeComponent();
        }
        private void TimerInterface_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 10; //msecs per second I believe...
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m ==60)
                {
                    m = 0;
                    h += 1;
                }
                textResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                if (m% creditIncrementEvery == 0 && s==0 && h==0)
                {
                    credits += 1;
                    textCreditCounter.Text = string.Format("{0}", credits.ToString().PadLeft(2,'0'));
                }
            }));
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void TextResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextCreditCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void TimerInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }
    }
}
