using DataBaseLayer.DataBaseContext;
using ServiceLayer.Repositories;
using ServiceLayer.Repositories.IRepos;
using ServiceLayer.Services;
using ServiceLayer.Services.CRUD_Services;
using ServiceLayer.Services.LoginService;
using ServiceLayer.Services.SvnService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation;
using ZPSVN.View;
using ZPSVN.View.IViews;

namespace ZPSVN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            

            //Wairing the database
            string dataBaseConnectingString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            SvnStatusInfoContext context = new SvnStatusInfoContext(dataBaseConnectingString);

            //Implementing the MVP concept
            ILoginView loginView = new LoginView();
            IMainView view = new MainView();

            LoginService loginService = new LoginService(new UserRepository(context));
            LineService lineService = new LineService(new LineRepository(context));
            PctolineService pctolineService = new PctolineService(new PctolineRepository(context));
            SvnService svnService = new SvnService(lineService,pctolineService);



            new LoginPresenter(loginView,loginService);
            loginView.MainView = view;
            new MainPresenter(loginView.MainView, svnService, lineService, pctolineService);

            Application.Run((Form)loginView);
            
            
        }
    }
}
