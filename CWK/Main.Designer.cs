namespace CWK
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            this.HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SetTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.SetTimeLabel = new System.Windows.Forms.Label();
            this.SecondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SetDateGroupBox = new System.Windows.Forms.GroupBox();
            this.AddTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.AddTimeComboBox = new System.Windows.Forms.ComboBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.TimeLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLeftGroupBox = new System.Windows.Forms.GroupBox();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.SetTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.HibernateButton = new System.Windows.Forms.Button();
            this.SleepButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumericUpDown)).BeginInit();
            this.SetTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNumericUpDown)).BeginInit();
            this.SetDateGroupBox.SuspendLayout();
            this.AddTimeGroupBox.SuspendLayout();
            this.TimeLeftGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(6, 19);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(200, 20);
            this.Calendar.TabIndex = 0;
            // 
            // HoursNumericUpDown
            // 
            this.HoursNumericUpDown.Location = new System.Drawing.Point(109, 19);
            this.HoursNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursNumericUpDown.Name = "HoursNumericUpDown";
            this.HoursNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.HoursNumericUpDown.TabIndex = 4;
            // 
            // MinutesNumericUpDown
            // 
            this.MinutesNumericUpDown.Location = new System.Drawing.Point(109, 45);
            this.MinutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesNumericUpDown.Name = "MinutesNumericUpDown";
            this.MinutesNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.MinutesNumericUpDown.TabIndex = 6;
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(154, 20);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 9;
            this.HoursLabel.Text = "Hours";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(154, 47);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(44, 13);
            this.MinutesLabel.TabIndex = 10;
            this.MinutesLabel.Text = "Minutes";
            // 
            // SetTimeGroupBox
            // 
            this.SetTimeGroupBox.Controls.Add(this.SetTimeLabel);
            this.SetTimeGroupBox.Controls.Add(this.SecondsNumericUpDown);
            this.SetTimeGroupBox.Controls.Add(this.SecondsLabel);
            this.SetTimeGroupBox.Controls.Add(this.HoursNumericUpDown);
            this.SetTimeGroupBox.Controls.Add(this.MinutesLabel);
            this.SetTimeGroupBox.Controls.Add(this.MinutesNumericUpDown);
            this.SetTimeGroupBox.Controls.Add(this.HoursLabel);
            this.SetTimeGroupBox.Location = new System.Drawing.Point(12, 73);
            this.SetTimeGroupBox.Name = "SetTimeGroupBox";
            this.SetTimeGroupBox.Size = new System.Drawing.Size(217, 97);
            this.SetTimeGroupBox.TabIndex = 12;
            this.SetTimeGroupBox.TabStop = false;
            this.SetTimeGroupBox.Text = "Set Time";
            // 
            // SetTimeLabel
            // 
            this.SetTimeLabel.AutoSize = true;
            this.SetTimeLabel.Location = new System.Drawing.Point(27, 45);
            this.SetTimeLabel.Name = "SetTimeLabel";
            this.SetTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.SetTimeLabel.TabIndex = 23;
            // 
            // SecondsNumericUpDown
            // 
            this.SecondsNumericUpDown.Location = new System.Drawing.Point(109, 71);
            this.SecondsNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsNumericUpDown.Name = "SecondsNumericUpDown";
            this.SecondsNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.SecondsNumericUpDown.TabIndex = 8;
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(154, 73);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(49, 13);
            this.SecondsLabel.TabIndex = 11;
            this.SecondsLabel.Text = "Seconds";
            // 
            // SetDateGroupBox
            // 
            this.SetDateGroupBox.Controls.Add(this.Calendar);
            this.SetDateGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SetDateGroupBox.Name = "SetDateGroupBox";
            this.SetDateGroupBox.Size = new System.Drawing.Size(217, 55);
            this.SetDateGroupBox.TabIndex = 13;
            this.SetDateGroupBox.TabStop = false;
            this.SetDateGroupBox.Text = "Set Date";
            // 
            // AddTimeGroupBox
            // 
            this.AddTimeGroupBox.Controls.Add(this.AddTimeComboBox);
            this.AddTimeGroupBox.Location = new System.Drawing.Point(12, 176);
            this.AddTimeGroupBox.Name = "AddTimeGroupBox";
            this.AddTimeGroupBox.Size = new System.Drawing.Size(217, 52);
            this.AddTimeGroupBox.TabIndex = 13;
            this.AddTimeGroupBox.TabStop = false;
            this.AddTimeGroupBox.Text = "Add Time";
            // 
            // AddTimeComboBox
            // 
            this.AddTimeComboBox.FormattingEnabled = true;
            this.AddTimeComboBox.Location = new System.Drawing.Point(19, 19);
            this.AddTimeComboBox.Name = "AddTimeComboBox";
            this.AddTimeComboBox.Size = new System.Drawing.Size(174, 21);
            this.AddTimeComboBox.TabIndex = 14;
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.Location = new System.Drawing.Point(12, 234);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(68, 48);
            this.ShutDownButton.TabIndex = 14;
            this.ShutDownButton.Text = "Shut Down";
            this.ShutDownButton.UseVisualStyleBackColor = true;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // TimeLeftTimer
            // 
            this.TimeLeftTimer.Interval = 1000;
            this.TimeLeftTimer.Tick += new System.EventHandler(this.TimeLeftTimer_Tick);
            // 
            // TimeLeftGroupBox
            // 
            this.TimeLeftGroupBox.Controls.Add(this.ProcessNameLabel);
            this.TimeLeftGroupBox.Controls.Add(this.TimeLeftLabel);
            this.TimeLeftGroupBox.Location = new System.Drawing.Point(12, 288);
            this.TimeLeftGroupBox.Name = "TimeLeftGroupBox";
            this.TimeLeftGroupBox.Size = new System.Drawing.Size(217, 74);
            this.TimeLeftGroupBox.TabIndex = 13;
            this.TimeLeftGroupBox.TabStop = false;
            this.TimeLeftGroupBox.Text = "Time Left";
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.AutoSize = true;
            this.ProcessNameLabel.Location = new System.Drawing.Point(97, 16);
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ProcessNameLabel.TabIndex = 23;
            this.ProcessNameLabel.SizeChanged += new System.EventHandler(this.ProcessNameLabel_SizeChanged);
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Location = new System.Drawing.Point(97, 47);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeLeftLabel.TabIndex = 22;
            this.TimeLeftLabel.SizeChanged += new System.EventHandler(this.TimeLeftLabel_SizeChanged);
            // 
            // SetTimeTimer
            // 
            this.SetTimeTimer.Enabled = true;
            this.SetTimeTimer.Interval = 1000;
            this.SetTimeTimer.Tick += new System.EventHandler(this.SetTimeTimer_Tick);
            // 
            // HibernateButton
            // 
            this.HibernateButton.Location = new System.Drawing.Point(86, 234);
            this.HibernateButton.Name = "HibernateButton";
            this.HibernateButton.Size = new System.Drawing.Size(68, 48);
            this.HibernateButton.TabIndex = 22;
            this.HibernateButton.Text = "Hibernate";
            this.HibernateButton.UseVisualStyleBackColor = true;
            this.HibernateButton.Click += new System.EventHandler(this.HibernateButton_Click);
            // 
            // SleepButton
            // 
            this.SleepButton.Location = new System.Drawing.Point(161, 234);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(68, 48);
            this.SleepButton.TabIndex = 23;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 368);
            this.Controls.Add(this.SleepButton);
            this.Controls.Add(this.HibernateButton);
            this.Controls.Add(this.TimeLeftGroupBox);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.AddTimeGroupBox);
            this.Controls.Add(this.SetDateGroupBox);
            this.Controls.Add(this.SetTimeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CWK";
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumericUpDown)).EndInit();
            this.SetTimeGroupBox.ResumeLayout(false);
            this.SetTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNumericUpDown)).EndInit();
            this.SetDateGroupBox.ResumeLayout(false);
            this.AddTimeGroupBox.ResumeLayout(false);
            this.TimeLeftGroupBox.ResumeLayout(false);
            this.TimeLeftGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Calendar;
        private System.Windows.Forms.NumericUpDown HoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinutesNumericUpDown;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.GroupBox SetTimeGroupBox;
        private System.Windows.Forms.GroupBox SetDateGroupBox;
        private System.Windows.Forms.GroupBox AddTimeGroupBox;
        private System.Windows.Forms.ComboBox AddTimeComboBox;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.NumericUpDown SecondsNumericUpDown;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Timer TimeLeftTimer;
        private System.Windows.Forms.GroupBox TimeLeftGroupBox;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Timer SetTimeTimer;
        private System.Windows.Forms.Label SetTimeLabel;
        private System.Windows.Forms.Button HibernateButton;
        private System.Windows.Forms.Button SleepButton;
        private System.Windows.Forms.Label ProcessNameLabel;
    }
}

