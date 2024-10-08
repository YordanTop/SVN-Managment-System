﻿using System;
using ServiceLayer.Services.LoginService;
using ZPSVN.View.IViews;
using ZPSVN.View;
using static DataBaseLayer.Models.User;

namespace ZPSVN.Presentation
{
    public class LoginPresenter
    {
        private ILoginView _view;
        private LoginService _loginService;

        public LoginPresenter(ILoginView view, LoginService userService)
        {
            _view = view;
            _loginService = userService;

            _view.OnLogin += OnLogin;
        }

        private void BeginSession(IMainView mainView)
        {
            MainView main = mainView as MainView;
            if (_loginService.CheckRole(_view.Username) == UserAccessRole.Admin)
            {
                main.UserRoleShower.Text += UserAccessRole.Admin.ToString();
                main.ShowDialog();
            }
            else
            {
                main.ComputerTool.Enabled = false;
                main.LineTool.Enabled = false;

                main.UserRoleShower.Text += UserAccessRole.User.ToString();
                main.ShowDialog();
            }
            
        }

        private void OnLogin(object sender, EventArgs e)
        {
            _view.IsLoggedIn = _loginService.CheckAuth(_view.Username, _view.Password);
            if (_view.IsLoggedIn)
            {
                BeginSession(_view.MainView);
            }
        }
    }
}
