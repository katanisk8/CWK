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

            finalDate = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                (int)numericUpDown1.Value,
                (int)numericUpDown2.Value,
                (int)numericUpDown3.Value);

            finalDate = finalDate.AddMinutes((int)comboBox1.SelectedValue);
            SetTime();
            
            if (timeLeft.TotalSeconds > 0)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            SetTime();

            if (timeLeft.TotalMilliseconds <= 0)
            {
                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
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

        private void AddIntervals()

        {
            var intervals = new Dictionary<string, int>();

            intervals.Add("No", 0);
            intervals.Add("10 Minutes", 10);
            intervals.Add("30 Minutes", 30);
            intervals.Add("1 Hour", 60);
            intervals.Add("2 Hour", 120);
            intervals.Add("3 Hour", 180);

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
    }
}