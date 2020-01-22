using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            TimerView.Text = string.Format("{0:00}:{1:00}:{2:00}", d.Hour, d.Minute, d.Second);
        }
    }
}
