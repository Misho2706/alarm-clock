using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_clock
{
    static class Program
    {
        static public int hour = 0;
        static public int minute = 0;
        static public Timer timer1 = new Timer();
        static public DateTime alarmTime = new DateTime();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
