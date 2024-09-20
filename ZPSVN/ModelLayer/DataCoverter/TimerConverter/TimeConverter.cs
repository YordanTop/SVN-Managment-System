using DataBaseLayer.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.DataCoverter.TimerConverter
{
    public class TimeConverter
    {
        private static readonly string TimerFilePath = Path.Combine(@"..\..\..\ModelLayer\DataCoverter\TimerConverter", "timerSettings.json");
        public static int GetTime()
        {
            string timerFile = File.ReadAllText(TimerFilePath);
            Root timer = JsonConvert.DeserializeObject<Root>(timerFile);
                return timer.Timer.Limit;
        }

        public static void SetTime(int time)
        {
            Timer timer = new Timer()
            {
                Limit = time
            };

            Root root = new Root()
            {
                Timer = timer
            };
            var timerInfo = JsonConvert.SerializeObject(root);

            File.WriteAllText(TimerFilePath, timerInfo);
        }
    }
}
