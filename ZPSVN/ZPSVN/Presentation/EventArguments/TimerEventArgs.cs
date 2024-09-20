using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
