using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer.DataCoverter.TimerConverter;

namespace ServiceLayer.Services.TimerService
{
    public class TimerService:IService
    {
        public int GetTime()
        {
            return TimeConverter.GetTime();
        }

        public void SetTime(int time)
        {
            TimeConverter.SetTime(time);
        }
    }
}
