using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBaseLayer.Models
{
    public partial class Pctoline
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public string Name { get; set; }
        public string Repository { get; set; }
        public string PcDirectory { get; set; }

        [Required]
        public virtual Line Line { get; set; }
    }
}
