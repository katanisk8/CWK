using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CWK
{
    public partial class Main : Form
    {
        private DateTime finalDate;
        private TimeSpan timeLeft;
        private int WhatToDo;

        public Main()
        {
            InitializeComponent();
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
            numericUpDown3.Value = DateTime.Now.Second;
            label5.Text = DateTime.Now.ToString(@"HH\:mm\:ss");
            AddIntervals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhatToDo = 0;
            DisableButtons();
            CalculateFinalDate();
            SetTime();
            RunTimer();
            label6.Text = "Shuting Down...";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WhatToDo = 1;
            DisableButtons();
            CalculateFinalDate();
            SetTime();
            RunTimer();
            label6.Text = "Hibernating...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WhatToDo = 2;
            DisableButtons();
            CalculateFinalDate();
            SetTime();
            RunTimer();
            label6.Text = "Snoozing...";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            SetTime();

            if ((int)timeLeft.TotalSeconds == 0)
            {
                FunctionsToRun();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString(@"HH\:mm\:ss");
        }

        private void label8_SizeChanged(object sender, EventArgs e)
        {
            label8.Left = (this.ClientSize.Width - label8.Size.Width) / 2;
        }

        private void label6_SizeChanged(object sender, EventArgs e)
        {
            label6.Left = (this.ClientSize.Width - label6.Size.Width) / 2;
        }

        private void AddIntervals()
        {
            var intervals = new Dictionary<string, int>();

            intervals.Add("No", 1);
            intervals.Add("10 Minutes", 600000);
            intervals.Add("30 Minutes", 1800000);
            intervals.Add("1 Hour", 3600000);
            intervals.Add("2 Hour", 7200000);
            intervals.Add("3 Hour", 10800000);

            comboBox1.DataSource = new BindingSource(intervals, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void SetTime()
        {
            timeLeft = finalDate - DateTime.Now;

            if (timeLeft.TotalHours > 24 && timeLeft.Days < 2)
            {
                label8.Text = String.Format("{0} day + {1}", timeLeft.Days, timeLeft.Duration().ToString(@"hh\:mm\:ss"));
            }
            else if (timeLeft.Days > 1)
            {
                label8.Text = String.Format("{0} days + {1}", timeLeft.Days, timeLeft.Duration().ToString(@"hh\:mm\:ss"));
            }
            else
            {
                label8.Text = timeLeft.Duration().ToString(@"hh\:mm\:ss");
            }
        }

        private void CalculateFinalDate()
        {
            finalDate = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                (int)numericUpDown1.Value,
                (int)numericUpDown2.Value,
                (int)numericUpDown3.Value);

            finalDate = finalDate.AddMilliseconds((int)comboBox1.SelectedValue);
        }

        private void DisableButtons()
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
        }

        private void RunTimer()
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                FunctionsToRun();
            }
        }

        private void FunctionsToRun()
        {
            timer1.Stop();
            timer2.Stop();

            switch (WhatToDo)
            {
                case 0:
                    var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                    break;
                case 1:
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    break;
                case 2:
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}