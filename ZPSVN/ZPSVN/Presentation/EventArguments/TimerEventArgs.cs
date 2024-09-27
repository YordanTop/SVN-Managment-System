using System;

namespace ZPSVN.Presentation.EventArguments
{
    public class TimerEventArgs:EventArgs
    {
        private int _time;
        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public TimerEventArgs(int time)
        {
            _time = time;
        }
    }
}
