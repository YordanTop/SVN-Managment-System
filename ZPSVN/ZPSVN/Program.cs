using DataBaseLayer.DataBaseContext;
using ServiceLayer.Repositories;
using ServiceLayer.Services;
using ServiceLayer.Services.CRUD_Services;
using ServiceLayer.Services.LoginService;
using ServiceLayer.Services.SvnService;
using System;
using System.Configuration;
using System.Net.NetworkInformation;
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

            try
            {
                SvnStatusInfoContext context = new SvnStatusInfoContext(dataBaseConnectingString);

                if (NetworkService.IsOnline() is false)
                {
                    throw new PingException("You are not connected to a network." +
                                            "Please check host provider or if you are disable the internet connection.");
                }

                if (context.Database.CanConnect() is false)
                {
                    throw new Exception();
                }

                //Implementing the MVP concept
                //Views
                ILoginView loginView = new LoginView();
                IMainView view = new MainView();

                //Project Services
                LoginService loginService = new LoginService(new UserRepository(context));
                LineService lineService = new LineService(new LineRepository(context));
                PctolineService pctolineService = new PctolineService(new PctolineRepository(context));
                SvnService svnService = new SvnService();

                //Presenters
                new LoginPresenter(loginView, loginService);
                loginView.MainView = view;
                new MainPresenter(loginView.MainView, svnService, lineService, pctolineService);

                Application.Run((Form)loginView);
            }
            catch (PingException pingException)
            {
                MessageBox.Show("You are not connected to a network. " +
                                "Please check host provider or if you are disable the internet connection.",
                                "Provider Error!");
            }
            catch (Exception entityException)
            {
                MessageBox.Show("The data connection has failed. Please check the database host if it's running.", "Server Error!");
            }

        }
    }
}
