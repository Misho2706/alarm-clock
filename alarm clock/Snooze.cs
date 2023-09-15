using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace alarm_clock
{
    public partial class Snooze : Form
    {
        private Main form;


        public Snooze()
        {

        }

        public Snooze(Main form1)
        {

            form = form1;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            form.stopSound();
            int snooze = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            if (Program.minute + snooze > 59)
            {
                form.getAlarmDate(Program.minute + 1, (Program.minute + snooze) - 60);
            }
            else
            {
                form.getAlarmDate(Program.hour, Program.minute + snooze);
            }
            form.Form1_Load(sender, e);

            Snooze form2 = new Snooze();
            form2.Close();
        }
    }
}
