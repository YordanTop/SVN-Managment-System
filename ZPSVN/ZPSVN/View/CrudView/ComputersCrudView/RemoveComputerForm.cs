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

namespace ZPSVN.View.CrudView.ComputersCrudView
{
    public partial class RemoveComputerForm : Form
    {
        private List<Line> _lineCollection;
        private PctolineService _pctolineService;

        public RemoveComputerForm(PctolineService pctolineService, List<Line> lineCollection)
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

        private void lineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputerComboBox.ResetText();
            ComputerComboBox.DataSource = _pctolineService.GetGroup(LineComboBox.SelectedItem as Line);
            ComputerComboBox.DisplayMember = "Name";
            ComputerComboBox.ValueMember = "Id";
        }

        private void RemoveComputer_Click(object sender, EventArgs e)
        {
            Pctoline selectedPc = ComputerComboBox.SelectedItem as Pctoline;

            if (selectedPc == null)
            {
                MessageBox.Show("Select a computer form the lines!");
            }
            else
            {
                _pctolineService.RemoveComputer(selectedPc);
                MessageBox.Show($"Computer \"{selectedPc.Name}\" is removed.");
            }
        }
    }
}
