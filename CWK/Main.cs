using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            timer1.Enabled = true;
            timer1.Start();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLeft = finalDate - DateTime.Now;
            label8.Text = timeLeft.Duration().ToString();
        }
    }
}