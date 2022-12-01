using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ООО__Столовые_приборы_.Models;
using ООО__Столовые_приборы_.Tools;
using ООО__Столовые_приборы_.Views;

namespace ООО__Столовые_приборы_.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private Page currentPage;

        private User user = new User();

        private Visibility loggedIn = Visibility.Collapsed;

        public Command Logout { get; set; }

        public string UserName
        {
            get => $"{user.UserSurname} {user.UserName} {user.UserPatronymic}";
        }

        public string Role 
        {
            get => $"{user.UserRoleNavigation?.RoleName}";
        }

        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                SignalChanged();
            }
        }

        public User User
        {
            get => user;
            set
            {
                LoggedIn = Visibility.Visible;
                user = value;
                SignalChanged();
                SignalChanged("UserName");
                SignalChanged("Role");
            }
        }

        public Visibility LoggedIn
        {
            get => loggedIn;
            set
            {
                loggedIn = value;
                SignalChanged();
            }

        }

        public MainWindowVM()
        {
            CurrentPage = new AuthPage(this);

            Logout = new Command(() =>
            {
                User = new User();
                LoggedIn = Visibility.Collapsed;
                CurrentPage = new AuthPage(this);
            });
        }
    }
}
