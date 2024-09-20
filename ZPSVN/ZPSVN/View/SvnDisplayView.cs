using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;
using ZPSVN.View.IViews;

namespace ZPSVN.View
{
    public partial class SvnDisplayView : Form,ISvnDisplayView
    {
        private AccessDirectoryArgs _directoryArgs;
        public SvnDisplayView(AccessDirectoryArgs directoryArgs)
        {
            InitializeComponent();
            _directoryArgs = directoryArgs;
        }

        public string Repository { 
            get 
            {
                return _directoryArgs.Repository; 
            }
            set 
            {
                _directoryArgs.Repository = value; 
            } 
        }
        public string Directory
        {
            get
            {
                return _directoryArgs.Directory;
            }
            set
            {
                _directoryArgs.Directory = value;
            }
        }

        public TextBox DisplayInfo
        {
            get
            {
                return textParserBox;
            }
            set
            {
                textParserBox = value;
            }
        }

        public event EventHandler DisplayComputerInfo;
        public event EventHandler Save;
        public event EventHandler CloseView;

        private void closeButton_Click(object sender, EventArgs e)
        {
            CloseView.Invoke(this, EventArgs.Empty);
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            Save.Invoke(this, e);
        }

        private void SvnDisplayView_Load(object sender, EventArgs e)
        {
            DisplayComputerInfo.Invoke(this, e);
        }
    }
}
