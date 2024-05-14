using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrack.WinForm.Design.Forms
{
    public partial class TimeTracker : Form
    {
        System.Windows.Forms.Timer _timer = new() { Interval=1000};
        public TimeTracker()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            Application.Exit();
        }

        private void TimeTracker_Load(object sender, EventArgs e)
        {
            _timer.Tick += onTimerTick;
            _timer.Start();
        }

        private void onTimerTick(object? sender, EventArgs e)
        {
            Clocklabel.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }
    }
}
