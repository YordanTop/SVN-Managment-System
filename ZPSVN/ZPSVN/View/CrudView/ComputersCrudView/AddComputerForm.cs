using DataBaseLayer.Models;
using FolderExpression;
using ServiceLayer.Services.CRUD_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPSVN.View.CrudView.ComputersCrudView
{
    public partial class AddComputerForm : Form
    {
        private List<Line> _lineCollection;
        private PctolineService _pctolineService;

        public AddComputerForm(PctolineService pctolineService, List<Line> lineCollection)
        {
            this.TopLevel = false;
            _lineCollection = lineCollection;
            _pctolineService = pctolineService;
            InitializeComponent();
            this.Show();

            PcAttachToComboBox.DataSource = _lineCollection;
            PcAttachToComboBox.DisplayMember = "Name";
            PcAttachToComboBox.ValueMember = "Id";
        }
        public ComboBox PcAttachToComboBox
        {
            get
            {
                return attachComputerComboBox;
            }
            set
            {
                attachComputerComboBox = value;
            }
        }
        public TextBox PcName { get { return computerNameTextBox; } set { computerNameTextBox = value; } }
        public TextBox PcRepository { get { return computerRepositoryTextBox;} set { computerRepositoryTextBox = value;} }
        public TextBox PcDirectory { get { return computerDirectoryTextBox; } set { computerDirectoryTextBox = value; } }

        private void AddComputer(object sender, EventArgs e)
        {

            Line selectedLine = PcAttachToComboBox.SelectedItem as Line;
            Pctoline newComputer = new Pctoline()
            {
                LineId = selectedLine.Id,
                Name = PcName.Text,
                Repository = PcRepository.Text,
                PcDirectory = this.PcDirectory.Text,
            };

            if(newComputer == null)
            {
                MessageBox.Show($"You must name the computer!");
            }
            else
            {
                _pctolineService.AddComputer(newComputer);
                MessageBox.Show($"Computer \"{newComputer.Name}\" is added.");
            }

        }

        private void SearchDirectory(object sender, EventArgs e)
        {
            PcDirectory.Text = BrowseFolder.GetFolder();

        }

        private void SearchRepository(object sender, EventArgs e)
        {
            PcRepository.Text = BrowseFolder.GetFile("svn.exe");
        }
    }
}
