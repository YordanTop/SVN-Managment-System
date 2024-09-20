using System;
using System.Collections.Generic;

namespace DataBaseLayer.Models
{
    public partial class Line
    {
        public Line()
        {
            Pctoline = new HashSet<Pctoline>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool AllStateStatus { get; set; }

        public virtual ICollection<Pctoline> Pctoline { get; set; }
    }
}
