using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace alarm_clock
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        public void getAlarmDate(int hour, int minute)
        {
            Program.alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
        }
        SoundPlayer sound = new SoundPlayer(@"C:\Users\1\Downloads\alarm.wav");
        void callAlarm(DateTime alarmTime)
        {
            if (DateTime.Now.Minute == alarmTime.Minute && DateTime.Now.Hour == alarmTime.Hour)
            {
                sound.Play();
                Snooze form2 = new Snooze(this);
                form2.Show();
                Program.timer1.Stop();
            }
        }
        public void stopSound()
        {
            sound.Stop();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Program.hour = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            Program.minute = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            getAlarmDate(Program.hour, Program.minute);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Snooze form2 = new Snooze(this);
            form2.Close();
            Program.timer1.Interval = 1000;
            Program.timer1.Tick += Timer1_Tick;
            Program.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            callAlarm(Program.alarmTime);
        }
    }
}
