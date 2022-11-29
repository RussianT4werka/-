using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using ООО__Столовые_приборы_.DB;
using ООО__Столовые_приборы_.Models;
using ООО__Столовые_приборы_.Tools;
using ООО__Столовые_приборы_.Views;

namespace ООО__Столовые_приборы_.ViewModel
{
    internal class AuthPageVM : BaseVM
    {
        private MainWindowVM mainVM;
        private Canvas capchaCanvas;
        private Visibility capchaVisible;
        public string Login { get; set; }

        public Command Enter { get; set; }
        public Visibility CapchaVisible 
        { 
            get => capchaVisible;
            set
            {
                capchaVisible = value;
                SignalChanged();
            }
        }


        public AuthPageVM(MainWindowVM mainVM, System.Windows.Controls.PasswordBox textPassword)
        {
            this.mainVM = mainVM;

            Enter = new Command(() =>
            {
                string pass = textPassword.Password;
                CheckLoginPassword(pass);
            });
        }

        private void CheckLoginPassword(string pass)
        {
            User user = null;
            try
            {
                user = user09Context.GetInstance().Users.Include("UserRoleNavigation").FirstOrDefault(s => s.UserPassword == pass & s.UserLogin == Login);
            }
            catch
            {
                MessageBox.Show("Ошибка связи с БД");
            }
            if(user == null)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            else
            {
                EnterUser(user);
            }
            
        }
        private void EnterUser(User user)
        {
            Auth.Auth.CurrentUser = user;
            mainVM.User = user;
            mainVM.CurrentPage = new ProductLictPage(mainVM);
        }
    }
}
