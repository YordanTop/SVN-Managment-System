using DataBaseLayer.Models;
using FolderExpression;
using ServiceLayer.Services.CRUD_Services;
using ServiceLayer.Services.SvnService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZPSVN.Displaying_Components;
using ZPSVN.Presentation.CrudPresenters;
using ZPSVN.Presentation.TimerPresent;
using ZPSVN.Presentation.EventArguments;
using ZPSVN.View;
using ZPSVN.View.CrudView.ComputersCrudView;
using ZPSVN.View.CrudView.LineCrudView;
using ZPSVN.View.IViews;
using ServiceLayer.Services.TimerService;
namespace ZPSVN.Presentation
{
    public class MainPresenter
    {
        private IMainView _view;
        private SvnService _svnService; 
        private LineService _lineService;
        private PctolineService _pctolineService;

        public string SessionName { get; set; }


        public MainPresenter(IMainView view,
                                    SvnService svnService,
                                    LineService lineService,
                                    PctolineService pctolineService) 
        {
            _view = view;
            _svnService = svnService;
            _lineService = lineService;
            _pctolineService = pctolineService;

            _view.LoadingProjects += LoadProjects;

            _view.ResetLines += ResetProject;
            _view.CloseApp += AppClosed;
            _view.OnSearchProjects += SearchProjects;

            _view.OnComputerToolClick += ComputerToolClick;
            _view.OnLineToolClick += LineToolClick;
            _view.SaveAllSvnFiles += SaveAllSvnFiles;
            _view.OnTimerToolClick += TimerToolClick;
        }

        private void TimerToolClick(object sender, EventArgs e)
        {
            TimerView timerView = new TimerView();
            new TimerPresenter(timerView, _view.AutoRefresh, _view.TimerLabel);

        }

        private void SaveAllSvnFiles(object sender, EventArgs e)
        {
            var saveAllFile = BrowseFolder.SaveFile();
            Dictionary<Pctoline, string> computerValuePairs = new Dictionary<Pctoline, string>();

            foreach (var line in _lineService.GetAll())
            {
                if(line.AllStateStatus == false)
                {
                    foreach (var computer in _pctolineService.GetGroup(line))
                    {
                        computerValuePairs.Add(computer, _svnService.PcDirectoryInfo(computer.Repository, computer.PcDirectory));
                    }

                }
            }
            _svnService.ConvertSvnStatusToCsv(computerValuePairs,saveAllFile);
        }

        private void LineToolClick(object sender, EventArgs e)
        {
            ICrudView lineView = new LineCrudView();
            new LineCrudPresenter(lineView, _lineService);
        }

        private void ComputerToolClick(object sender, EventArgs e)
        {
            ICrudView computerView = new ComputerCrudView();
            new ComputerCrudPresenter(computerView, _pctolineService);
            computerView.LineCollection = _lineService.GetAll().ToList();
        }

        private void SearchProjects(object sender, CustomEventArgs e)
        {
            string userInput = e.CustomObject as string;

            CustomEventArgs searchResult = new CustomEventArgs(_lineService.SearchResult(userInput));
            LoadProjects(sender, searchResult);

        }

        public void ShowSession()
        {
            MainView showView = _view as MainView;
            showView.Show();
        }

        private void ResetProject(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                TimerService timerService = new TimerService();
                _view.AutoRefresh.Interval = timerService.GetTime();
                
                _view.LinePanel.Controls.Clear();
                CustomEventArgs lines = new CustomEventArgs(_lineService.GetAll());
                LoadProjects(sender,lines);
            }
        }
        private async void LoadProjects(object sender, CustomEventArgs e)
        {
            TimerService timerService = new TimerService();
            _view.AutoRefresh.Interval = timerService.GetTime();

            _view.TimerLabel.Text = $"Project reloading timer: {Convert.ToInt32(TimeSpan.FromMilliseconds(_view.AutoRefresh.Interval).TotalMinutes)} minutes";

            IEnumerable<Line> lines = e.CustomObject.Equals(EventArgs.Empty) ? 
                                                                 _lineService.GetAll():
                                                                 (IEnumerable<Line>)e.CustomObject;


            List <ComponentsPanel> panels = new List<ComponentsPanel>();
            ComponentsPanel panel;
            _view.LinePanel.Controls.Clear(); 
            foreach (Line line in lines)
            {
                panel = new ComponentsPanel();

                panel.ComponentPanel.Click += (s, args) => LoadComputers(line, e);

                panel.AddTitle(line.Name);

                if (_pctolineService.CheckStatus(_pctolineService.GetGroup(line)))
                {
                    panel.ComponentStatus = true;
                }
                else
                {
                    panel.ComponentStatus = false;
                }

                _lineService.ChangeStatus(line.Id, panel.ComponentStatus);

                panel.DisplayStatus();

                panels.Add(panel);
            }
            panels.ForEach(p => p.AttachTo(_view.LinePanel));
            
        }

        private void LoadComputers(object sender, EventArgs e)
        {
            _view.ComputersPanel.Controls.Clear();

            List<ComponentsPanel> panels = new List<ComponentsPanel>();

            foreach (Pctoline computer in _pctolineService.GetGroup(sender as Line))
            {
                ComponentsPanel panel = new ComponentsPanel();
                panel.AddTitle(computer.Name);
                                
                if (_pctolineService.CheckStatusById(computer.Id) == false)
                {
                    panel.ComponentStatus = false;
                    panel.DisplayStatus();
                    panel.ComponentPanel.Click += (s, args) => InfoDisplay(sender, new AccessDirectoryArgs(computer.Repository, computer.PcDirectory));
                }
                else
                {
                    panel.ComponentStatus = true;
                    panel.DisplayStatus();
                }

                panels.Add(panel);
            }
            
            panels.ForEach(x => {
                x.AttachTo(_view.ComputersPanel);
            });
        }

        private void InfoDisplay(object sender, AccessDirectoryArgs directoryArgs)
        {
            ISvnDisplayView svnView = new SvnDisplayView(directoryArgs);
            new SvnDisplayPresenter(svnView,_svnService);
        }

        private void AppClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
