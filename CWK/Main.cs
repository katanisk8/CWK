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
        public int Hours;
        public int Minutes;
        public int Seconds;

        public Main()
        {
            InitializeComponent();
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
            numericUpDown3.Value = DateTime.Now.Second;
            AddIntervals();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Hours = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Minutes = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Seconds = (int)numericUpDown3.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime finalDate = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                Hours,
                Minutes,
                Seconds);


            finalDate = finalDate.AddMinutes((int)comboBox1.SelectedValue);

            label11.Text = finalDate.ToString();

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
    }
}
