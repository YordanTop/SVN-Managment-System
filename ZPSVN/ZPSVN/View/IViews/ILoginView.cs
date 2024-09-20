using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPSVN.Presentation;

namespace ZPSVN.View.IViews
{
    public interface ILoginView
    {
        string Username { get; set; }
        string Password { get; set; }

        bool IsLoggedIn { get; set; }

        IMainView MainView { get; set; }

        event EventHandler OnLogin;
        
    }
}
