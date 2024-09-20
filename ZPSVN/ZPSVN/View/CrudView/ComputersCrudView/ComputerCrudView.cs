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

namespace ZPSVN.View.CrudView.ComputersCrudView
{
    public partial class ComputerCrudView : Form, ICrudView
    {
        public ComputerCrudView()
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

#pragma warning disable CS0067 // The event 'ComputerCrudView.OnUpdate' is never used
        public event EventHandler OnUpdate;
#pragma warning restore CS0067 // The event 'ComputerCrudView.OnUpdate' is never used
        public event EventHandler OnDelete;
        public event EventHandler OnInsert;

        private void Insert(object sender, EventArgs e)
        {
            OnInsert?.Invoke(sender, e);
        }

        private void Remove(object sender, EventArgs e)
        {
            OnDelete?.Invoke(sender, e);
        }

        private void Update(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(sender, e);
        }
    }
}
