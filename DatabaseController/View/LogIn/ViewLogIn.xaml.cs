using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatabaseController.View.LogIn
{
    /// <summary>
    /// Interaction logic for ViewLogIn.xaml
    /// </summary>
    public partial class ViewLogIn : UserControl
    {
        public ViewLogIn()
        {
            InitializeComponent();
        }

        private static readonly DependencyProperty LoginProperty =
            DependencyProperty.Register("Login", typeof(string), typeof(ViewLogIn),
                new FrameworkPropertyMetadata(null));

        private static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(ViewLogIn),
                new FrameworkPropertyMetadata(null));

        public string Login
        {
            get => (string)GetValue(LoginProperty);
            set => SetValue(LoginProperty, value);
        }

        public string Password
        {
            get => (string)GetValue(PasswordProperty);
            set => SetValue(PasswordProperty, value);
        }

    }
}
