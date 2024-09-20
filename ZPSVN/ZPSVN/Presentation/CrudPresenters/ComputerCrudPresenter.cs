using ServiceLayer.Services.CRUD_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPSVN.View.CrudView.ComputersCrudView;
using ZPSVN.View.IViews;

namespace ZPSVN.Presentation.CrudPresenters
{
    public class ComputerCrudPresenter
    {
        private ICrudView _computerView;
        private PctolineService _pctolineService;

        public ComputerCrudPresenter(ICrudView computerView, PctolineService pctolineService)
        {
            _computerView = computerView;
            _pctolineService = pctolineService;

            _computerView.OnUpdate += UpdateComputer; 
            _computerView.OnDelete += RemoveComputer;
            _computerView.OnInsert += AddComputer;
        }

        private void AddComputer(object sender, EventArgs e)
        {
            _computerView.CrudDisplayPanel.Controls.Clear();
            _computerView.CrudDisplayPanel.Controls.Add(new AddComputerForm(_pctolineService,_computerView.LineCollection));
        }

        private void RemoveComputer(object sender, EventArgs e)
        {
            _computerView.CrudDisplayPanel.Controls.Clear();
            _computerView.CrudDisplayPanel.Controls.Add(new RemoveComputerForm(_pctolineService, _computerView.LineCollection));
        }

        private void UpdateComputer(object sender, EventArgs e)
        {
            _computerView.CrudDisplayPanel.Controls.Clear();
            _computerView.CrudDisplayPanel.Controls.Add(new UpdateComputerForm(_pctolineService, _computerView.LineCollection));
        }

        
    }
}
