using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;

namespace ZPSVN.View.IViews
{
    public interface ISvnDisplayView
    {
        string Repository { get; set; }
        string Directory { get; set; }
        TextBox DisplayInfo { get; set; }

        event EventHandler DisplayComputerInfo;
        event EventHandler Save;
        event EventHandler CloseView;
    }
}
