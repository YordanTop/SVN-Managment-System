using ServiceLayer.Services.TimerService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;
using ZPSVN.View.IViews;

namespace ZPSVN.Presentation.TimerPresent
{
    public class TimerPresenter
    {
        private ITimerView _view;
        private Timer _autoRefresh;
        private Label _refreshLabel;

        public TimerPresenter(ITimerView view, Timer autoRefresh, Label timerLabel)
        {
            _view = view;
            _view.SetTimer += SetTimer;
            _autoRefresh = autoRefresh;
            _refreshLabel = timerLabel;
        }

        private void SetTimer(object sender, TimerEventArgs e)
        {
            TimerService timerService = new TimerService();

            timerService.SetTime(e.Time);

            _autoRefresh.Stop();
            _autoRefresh.Interval = timerService.GetTime();
            _autoRefresh.Start();

            _refreshLabel.Text = $"Project reloading timer: {Convert.ToInt32(TimeSpan.FromMilliseconds(_autoRefresh.Interval).TotalMinutes)} minutes";

        }
    }
}
