using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;

namespace ZPSVN.View.IViews
{
    public interface IMainView
    {
        Timer AutoRefresh { get; set; }
        FlowLayoutPanel LinePanel { get; set; }
        FlowLayoutPanel ComputersPanel { get; set; }
        Label TimerLabel { get; set; }
        Label UserRoleShower { get; set; }
        TextBox SearchTextBox { get; set; }
        ToolStripMenuItem ComputerTool { get; set; }
        ToolStripMenuItem LineTool { get; set; }
        ToolStripMenuItem SaveAllTool {  get; set; }

        event EventHandler<CustomEventArgs> LoadingProjects;
        event KeyEventHandler ResetLines;
        event FormClosedEventHandler CloseApp;
        event EventHandler<CustomEventArgs> OnSearchProjects;
        event EventHandler OnComputerToolClick;
        event EventHandler OnLineToolClick;
        event EventHandler SaveAllSvnFiles;
        event EventHandler OnTimerToolClick;
    }
}
