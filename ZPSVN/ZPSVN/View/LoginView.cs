using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation;
using ZPSVN.View.IViews;

namespace ZPSVN.View
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string Username
        {
            get
            {
                return userTextBox.Text;
            }
            set
            {
                userTextBox.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return passTextBox.Text;
            }
            set
            {
                passTextBox.Text = value;
            }
        }

        /// <summary>
        /// Checks if the user is log in 
        /// <para>the default property is false</para>
        /// </summary>
        public bool IsLoggedIn { get; set; } = false;
        public IMainView MainView { get; set ; }

        public event EventHandler OnLogin;

        private void Login(object sender, EventArgs e)
        {
            OnLogin?.Invoke(this, EventArgs.Empty);
        }
    }
}
