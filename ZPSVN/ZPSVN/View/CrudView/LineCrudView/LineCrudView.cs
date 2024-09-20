using DataBaseLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.View.IViews;

namespace ZPSVN.View.CrudView.LineCrudView
{
    public partial class LineCrudView : Form, ICrudView
    {
        public LineCrudView()
        {
            InitializeComponent();
            this.Show();
        }

        public Panel CrudDisplayPanel
        {
            get
            {
                return crudDisplayPanel;
            }
            set
            {
                crudDisplayPanel = value;
            }
        }

        public List<Line> LineCollection { get; set; }

        public event EventHandler OnUpdate;
        public event EventHandler OnDelete;
        public event EventHandler OnInsert;

        private void AddLine(object sender, EventArgs e)
        {
            OnInsert?.Invoke(this, e);
        }

        private void RemoveLine(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, e);
        }

        private void UpdatePermissions(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, e);
        }
    }
}
