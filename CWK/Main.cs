using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CWK.Functions;

namespace CWK
{
    public partial class Main : Form
    {
        private DateTime FinalDate;
        private TimeSpan TimeLeft;

        public Main()
        {
            InitializeComponent();
            SetComponents();
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            DisableComponents();
            CalculateFinalDate();
            SetTime();
            RunTimer(WhatToDo.ShutDown);
            ProcessNameLabel.Text = "Shuting Down...";

        }

        private void HibernateButton_Click(object sender, EventArgs e)
        {
            DisableComponents();
            CalculateFinalDate();
            SetTime();
            RunTimer(WhatToDo.Hibernate);
            ProcessNameLabel.Text = "Hibernating...";
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            DisableComponents();
            CalculateFinalDate();
            SetTime();
            RunTimer(WhatToDo.Sleep);
            ProcessNameLabel.Text = "Snoozing...";
        }

        private void TimeLeftTimer_Tick(object sender, EventArgs e)
        {
            SetTime();
            
            if ((int)TimeLeft.TotalSeconds == 0)
            {
                FunctionsToRun((WhatToDo)TimeLeftTimer.Tag);
            }
        }

        private void SetTimeTimer_Tick(object sender, EventArgs e)
        {
            SetTimeLabel.Text = DateTime.Now.ToString(@"HH\:mm\:ss");
        }

        private void TimeLeftLabel_SizeChanged(object sender, EventArgs e)
        {
            TimeLeftLabel.Left = (this.ClientSize.Width - TimeLeftLabel.Size.Width) / 2;
        }

        private void ProcessNameLabel_SizeChanged(object sender, EventArgs e)
        {
            ProcessNameLabel.Left = (this.ClientSize.Width - ProcessNameLabel.Size.Width) / 2;
        }

        private void SetComponents()
        {
            HoursNumericUpDown.Value = DateTime.Now.Hour;
            MinutesNumericUpDown.Value = DateTime.Now.Minute;
            SecondsNumericUpDown.Value = DateTime.Now.Second;

            SetTimeLabel.Text = DateTime.Now.ToString(@"HH\:mm\:ss");

            Dictionary<string, int> addTime = new Dictionary<string, int>
            {
                {"No", 1},
                {"10 Minutes", 600000},
                {"30 Minutes", 1800000},
                {"1 Hour", 3600000},
                {"2 Hour", 7200000},
                {"3 Hour", 10800000}
            };

            AddTimeComboBox.DataSource = new BindingSource(addTime, null);
            AddTimeComboBox.DisplayMember = "Key";
            AddTimeComboBox.ValueMember = "Value";
        }

        private void SetTime()
        {
            TimeLeft = FinalDate - DateTime.Now;

            if (TimeLeft.TotalHours > 24 && TimeLeft.Days < 2)
            {
                TimeLeftLabel.Text = String.Format("{0} day + {1}", TimeLeft.Days, TimeLeft.Duration().ToString(@"hh\:mm\:ss"));
            }
            else if (TimeLeft.Days > 1)
            {
                TimeLeftLabel.Text = String.Format("{0} days + {1}", TimeLeft.Days, TimeLeft.Duration().ToString(@"hh\:mm\:ss"));
            }
            else
            {
                TimeLeftLabel.Text = TimeLeft.Duration().ToString(@"hh\:mm\:ss");
            }
        }

        private void CalculateFinalDate()
        {
            FinalDate = new DateTime(
                Calendar.Value.Year,
                Calendar.Value.Month,
                Calendar.Value.Day,
                (int)HoursNumericUpDown.Value,
                (int)MinutesNumericUpDown.Value,
                (int)SecondsNumericUpDown.Value);

            FinalDate = FinalDate.AddMilliseconds((int)AddTimeComboBox.SelectedValue);
        }

        private void DisableComponents()
        {
            Calendar.Enabled = false;
            HoursNumericUpDown.Enabled = MinutesNumericUpDown.Enabled = SecondsNumericUpDown.Enabled = false;
            AddTimeComboBox.Enabled = false;
            ShutDownButton.Enabled = HibernateButton.Enabled = SleepButton.Enabled = false;
        }

        private void RunTimer(WhatToDo WhatToDo)
        {
            if (TimeLeft.TotalSeconds > 0)
            {
                TimeLeftTimer.Enabled = true;
                TimeLeftTimer.Start();
                TimeLeftTimer.Tag = WhatToDo;
            }
            else
            {
                FunctionsToRun(WhatToDo);
            }
        }

        private void FunctionsToRun(WhatToDo WhatToDo)
        {
            TimeLeftTimer.Stop();
            SetTimeTimer.Stop();
            
            Functions.Function(WhatToDo);
        }
    }
}