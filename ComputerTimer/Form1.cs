using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SleepBtn_Click(object sender, EventArgs e)
        {
            int hours = 0;
            int minutes = 0;

            if (!string.IsNullOrEmpty(HourTxt.Text))
            {
                hours = convertToInt(HourTxt.Text);
            }

            if (!string.IsNullOrEmpty(MinTxt.Text))
            {
                minutes = convertToInt(MinTxt.Text);
            }

            TimeSpan span = new TimeSpan(hours, minutes, 0);

            int seconds = (int)span.TotalSeconds;

            if (seconds <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Second = 0 this will shutdown computer now? \nAre you sure your want to shutdown now?", "Shutdown now", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("shutdown", "/s /t " + seconds);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                Process.Start("shutdown", "/s /t " + seconds);
            }


        }

        private int convertToInt(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value, "^[0-9]*$"))
            {
                return Int32.Parse(value);
            }

            MessageBox.Show("Please only enter integers!");
            return 0;
        }


        private void AbortBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
        }
    }
}
