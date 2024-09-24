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
    public partial class TimerView : Form, ITimerView
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
        private const int MillisecondsToMinute = 60000;
        public int TextTimerToMinutes
        {
            get
            {
                return Convert.ToInt32(TimerTextBox.Text) * MillisecondsToMinute;
            }
        }
        public event EventHandler<TimerEventArgs> SetTimer;
        public event KeyPressEventHandler CheckKeyCharacter;

        private void setTimer_Click(object sender, EventArgs e)
        {

            SetTimer?.Invoke(this, new TimerEventArgs(TextTimerToMinutes));
            this.Close();
        }

        private void timerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKeyCharacter?.Invoke(this, e);
        }
    }
}
