using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ServiceLayer.Services.SvnService;
using ServiceLayer.Services.TimerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;
using ZPSVN.View.IViews;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZPSVN.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
           InitializeComponent();
        }

        public FlowLayoutPanel LinePanel { 
            get 
            {
                return linePanel;
            }
            
            set 
            {
                linePanel = value;
            }
        }
        public FlowLayoutPanel ComputersPanel {
            get 
            {
                return computersPanel;
            }
            set 
            {
                computersPanel = value;
            }
        }
        public Label TimerLabel
        {
            get
            {
                return timerLabel;
            }
            set
            {
                timerLabel = value;
            }
        }
        public Label UserRoleShower
        {
            get
            {
                return userRoleShower;
            }
            set
            {
                userRoleShower = value;
            }
        }
        public ToolStripMenuItem ComputerTool 
        { 
            get 
            {
                return computerTool; 
            } 
            set 
            {
                computerTool = value; 
            } 
        }
        public ToolStripMenuItem LineTool 
        {
            get 
            {
                return lineTool;
            }
            set 
            {
                lineTool = value; 
            }
        }

        public System.Windows.Forms.TextBox SearchTextBox
        {
            get
            {
                return searchingTextBox;
            }
            set
            {
                searchingTextBox = value;
            }
        }

        public ToolStripMenuItem SaveAllTool { get { return saveAllInfoToolStripMenuItem; } set { saveAllInfoToolStripMenuItem = value; } }

        public Timer AutoRefresh
        {
            get
            {
                return autoRefresh;
            }
            set
            {
                autoRefresh = value;
            }
        }

        public event EventHandler<CustomEventArgs> LoadingProjects;
        public event KeyEventHandler ResetLines;
        public event FormClosedEventHandler CloseApp;
        public event EventHandler<CustomEventArgs> OnSearchProjects;
        public event EventHandler OnComputerToolClick;
        public event EventHandler OnLineToolClick;
        public event EventHandler SaveAllSvnFiles;
        public event EventHandler OnTimerToolClick;

        private void MainView_Load(object sender, System.EventArgs e)
        {
            AutoRefresh.Start();
        }

        private void MainView_ResetLines(object sender, KeyEventArgs e)
        {
            ResetLines.Invoke(sender, e);
        }

        private void AppClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            CloseApp.Invoke(sender, e);
        }

        private void autoRefresh_Tick(object sender, EventArgs e)
        {
            LoadingProjects?.Invoke(sender, new CustomEventArgs(e));

            AutoRefresh.Start();
        }

        private void SaveAll(object sender, EventArgs e)
        {
            SaveAllSvnFiles?.Invoke(sender, e);
        }

        private void Submit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = null;
                OnSearchProjects?.Invoke(sender,new CustomEventArgs(SearchTextBox.Text));
            }
        }

        private void lineTool_Click(object sender, EventArgs e)
        {
            OnLineToolClick?.Invoke(sender, e);
        }

        private void computerTool_Click(object sender, EventArgs e)
        {
            OnComputerToolClick?.Invoke(sender, e);
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnTimerToolClick?.Invoke(sender, e);
        }
    }
}
