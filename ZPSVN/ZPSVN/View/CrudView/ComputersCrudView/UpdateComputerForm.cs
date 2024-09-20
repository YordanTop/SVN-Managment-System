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

namespace ZPSVN.View.CrudView.ComputersCrudView
{
    public partial class UpdateComputerForm : Form
    {
        private PctolineService _pctolineService;
        private List<Line> _lineCollection;

        public UpdateComputerForm(PctolineService pctolineService, List<Line> lineCollection)
        {
            this.TopLevel = false;
            _lineCollection = lineCollection;
            _pctolineService = pctolineService;
            InitializeComponent();
            this.Show();
            LineComboBox.DataSource = _lineCollection;
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
        public ComboBox ComputerComboBox
        {
            get
            {
                return computerComboBox;
            }
            set
            {
                computerComboBox = value;
            }
        }

        public TextBox RenameComputer
        {
            get
            {
                return renameComputerTextBox;
            }
            set
            {
                renameComputerTextBox = value;
            }
        }

        private void UpdateComputer(object sender, EventArgs e)
        {
            Pctoline selectedPc = ComputerComboBox.SelectedItem as Pctoline;

            if (selectedPc == null || RenameComputer.Text == null)
            {
                MessageBox.Show("Select a computer form the lines and rename it!");
            }
            else
            {
                Pctoline newPc = new Pctoline()
                {
                    Id = selectedPc.Id,
                    Name = RenameComputer.Text,
                    LineId = selectedPc.LineId,
                    PcDirectory = selectedPc.PcDirectory,
                    Repository = selectedPc.Repository,
                };
                _pctolineService.UpdateComputer(selectedPc, newPc);
                MessageBox.Show($"Computer \"{newPc.Name}\" is updated.");
            }
        }

        private void lineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputerComboBox.ResetText();
            ComputerComboBox.DataSource = _pctolineService.GetGroup(LineComboBox.SelectedItem as Line);
            ComputerComboBox.DisplayMember = "Name";
            ComputerComboBox.ValueMember = "Id";
        }
    }
}
