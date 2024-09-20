using DataBaseLayer.Models;
using ServiceLayer.Services.CRUD_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ZPSVN.View.CrudView.LineCrudView
{
    public partial class RemoveLineForm : Form
    {
        private LineService _lineService;

        public RemoveLineForm()
        {
            InitializeComponent();
        }

        public RemoveLineForm(LineService lineService)
        {
            this.TopLevel = false;
            _lineService = lineService;
            InitializeComponent();
            this.Show();

            LineComboBox.DataSource = _lineService.GetAll().ToList();
            LineComboBox.DisplayMember = "Name";
            LineComboBox.ValueMember = "Id";
        }

        public ComboBox LineComboBox
        {
            get
            {
                return lineComboBox;
            }
            set
            {
                lineComboBox = value;
            }
        }

        private void RemoveLine(object sender, EventArgs e)
        {
            Line selectedLine = LineComboBox.SelectedItem as Line;

            if (selectedLine == null)
            {
                MessageBox.Show("Select a computer form the lines!");
            }
            else
            {
                _lineService.RemoveLine(selectedLine);
                MessageBox.Show($"Computer \"{selectedLine.Name}\" is removed.");
            }
        }
    }
}
