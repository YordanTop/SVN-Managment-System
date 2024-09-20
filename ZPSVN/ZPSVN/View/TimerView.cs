using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;
using ZPSVN.View.IViews;

namespace ZPSVN.View
{
    public partial class TimerView : Form,ITimerView
    {
        public TimerView()
        {
            InitializeComponent();
            this.Show();
        }

        public TextBox TimerTextBox
        {
            get
            {
                return timerTextBox;
            }
            set
            {
                timerTextBox = value;
            }
        }

        public event EventHandler<TimerEventArgs> SetTimer;

        private void setTimer_Click(object sender, EventArgs e)
        {
            if (timerTextBox.Text.Equals(String.Empty))
            {
                timerTextBox.Text = $"{TimeSpan.TicksPerSecond}";
            }else if (Convert.ToInt32(timerTextBox.Text) < 0 ||
                Convert.ToInt32(timerTextBox.Text) == int.MaxValue)
            {
                timerTextBox.Text = $"{TimeSpan.TicksPerSecond}";
            }

            SetTimer?.Invoke(this, new TimerEventArgs(Convert.ToInt32(timerTextBox.Text)));
            this.Close();
        }
    }
}
