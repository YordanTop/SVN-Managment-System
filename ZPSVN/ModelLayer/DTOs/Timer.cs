using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.DTOs
{
    public class Timer
    {
        public int Limit { get; set; }
    }

    public class Root
    {
        public Timer Timer { get; set; }
    }
}
