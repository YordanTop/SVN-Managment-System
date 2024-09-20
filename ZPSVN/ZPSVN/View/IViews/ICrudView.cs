using DataBaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPSVN.View.IViews
{
    public interface ICrudView
    {
        List<Line> LineCollection { get; set; }
        Panel CrudDisplayPanel { get; set; }

        event EventHandler OnUpdate;
        event EventHandler OnDelete;
        event EventHandler OnInsert;
    }
}
