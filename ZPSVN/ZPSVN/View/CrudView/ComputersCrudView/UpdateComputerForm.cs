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
            Line selectedLine = LineComboBox.SelectedItem as Line;
            Pctoline selectedPc = ComputerComboBox.SelectedItem as Pctoline;

            if (selectedLine == null ||
                selectedPc == null ||
                RenameComputer.Text.Equals(String.Empty))
            {
                MessageBox.Show($"You must fill the fields!");
            }else
            if (_pctolineService.SearchForComputer(selectedLine, RenameComputer.Text))
            {
                MessageBox.Show($"This computer name is taken!");
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
