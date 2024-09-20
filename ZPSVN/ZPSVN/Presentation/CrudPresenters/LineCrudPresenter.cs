using ServiceLayer.Services.CRUD_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPSVN.View.CrudView.LineCrudView;
using ZPSVN.View.IViews;

namespace ZPSVN.Presentation.CrudPresenters
{
    public class LineCrudPresenter
    {
        private ICrudView _lineView;
        private LineService _lineService;

        public LineCrudPresenter(ICrudView lineView, LineService lineService)
        {
            _lineView = lineView;
            _lineService = lineService;

            _lineView.OnUpdate += UpdateLine;
            _lineView.OnDelete += RemoveLine;
            _lineView.OnInsert += AddLine;
        }

        private void AddLine(object sender, EventArgs e)
        {
            _lineView.CrudDisplayPanel.Controls.Clear();
            _lineView.CrudDisplayPanel.Controls.Add(new AddLineForm(_lineService));
            
        }

        private void RemoveLine(object sender, EventArgs e)
        {
            _lineView.CrudDisplayPanel.Controls.Clear();
            _lineView.CrudDisplayPanel.Controls.Add(new RemoveLineForm(_lineService));
        }

        private void UpdateLine(object sender, EventArgs e)
        {
            _lineView.CrudDisplayPanel.Controls.Clear();
            _lineView.CrudDisplayPanel.Controls.Add(new UpdateLineForm(_lineService));
        }
    }
}
