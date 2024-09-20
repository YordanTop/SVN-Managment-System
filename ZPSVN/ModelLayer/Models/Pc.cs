using System;
using System.Collections.Generic;

namespace DataBaseLayer.Models
{
    public partial class Pc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Repository { get; set; }
        public string PcDirectory { get; set; }
    }
}
