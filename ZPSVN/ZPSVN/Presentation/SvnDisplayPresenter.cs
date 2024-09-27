using FolderExpression;
using ServiceLayer.Services.SvnService;
using System;
using ZPSVN.Presentation.EventArguments;
using ZPSVN.View;
using ZPSVN.View.IViews;

namespace ZPSVN.Presentation
{
    public class SvnDisplayPresenter
    {
        private SvnDisplayView _view;
        private SvnService _svnService;
        

        public SvnDisplayPresenter(ISvnDisplayView view, SvnService service) 
        {
            _view = view as SvnDisplayView;
            _svnService = service;

            
            _view.DisplayComputerInfo += (sender, args) => DisplayComputerInfo(this, new AccessDirectoryArgs(_view.Repository, _view.Directory));
            _view.Save += (sender, args) => SaveSvnInfo(this,new AccessDirectoryArgs(_view.Repository,_view.Directory));
            _view.CloseView += CloseForm;
            _view.ShowDialog();
        }

        private void DisplayComputerInfo(object sender, AccessDirectoryArgs e)
        {
            _view.DisplayInfo.Text = _svnService.PcDirectoryInfo(e.Repository, e.Directory);
        }

        private void SaveSvnInfo(object sender, AccessDirectoryArgs e)
        {
            var file = BrowseFolder.SaveFile();
            _svnService.ConvertSvnStatusToCsv(_svnService.PcDirectoryInfo(e.Repository, e.Directory),
                                                file,
                                                e.Directory); ;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            _view.Close();
        }

    }
}
