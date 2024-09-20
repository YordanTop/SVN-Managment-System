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
    public partial class UpdateLineForm : Form
    {
        private LineService _lineService;

        public UpdateLineForm(LineService lineService)
        {
            this.TopLevel = false;
            _lineService = lineService;
            InitializeComponent();
            this.Show();

            LineComboBox.DataSource = _lineService.GetAll();
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

        public TextBox RenameLine
        {
            get
            {
                return renameLineTextBox;
            }
            set
            {
                renameLineTextBox = value;
            }
        }

        private void UpdateLine(object sender, EventArgs e)
        {
            Line selectedLine = LineComboBox.SelectedItem as Line;

            if (selectedLine == null || RenameLine.Text == null)
            {
                MessageBox.Show("Select a line and rename it!");
            }
            else
            {
                Line newLine = new Line()
                {
                    Id = selectedLine.Id,
                    Name = RenameLine.Text,
                    AllStateStatus = selectedLine.AllStateStatus,
                    Pctoline = selectedLine.Pctoline,
                };
                _lineService.UpdateLine(selectedLine, newLine);
                MessageBox.Show($"Line \"{newLine.Name}\" is updated.");
            }
        }
    }
}
