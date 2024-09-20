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

namespace ZPSVN.View.CrudView.LineCrudView
{
    public partial class AddLineForm : Form
    {
        private LineService _lineService;

        public AddLineForm()
        {
            InitializeComponent();
        }

        public AddLineForm(LineService lineService)
        {
            this.TopLevel = false;
            this._lineService = lineService;
            InitializeComponent();
            this.Show();
        }

        public TextBox LineName
        {
            get
            {
                return lineNameTextBox;
            }
            set
            {
                lineNameTextBox = value;
            }
        }

        private void AddLine(object sender, EventArgs e)
        {
            Line newLine = new Line()
            {
                Name = LineName.Text,
            };

            if (newLine == null )
            {
                MessageBox.Show("You must name the line!");
            }
            else
            {
                _lineService.AddLine(newLine);
                MessageBox.Show($"Line {newLine.Name} is added");
            }
            
        }
    }
}
