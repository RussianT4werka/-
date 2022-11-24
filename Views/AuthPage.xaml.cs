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
using ООО__Столовые_приборы_.ViewModel;

namespace ООО__Столовые_приборы_.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage(ViewModel.MainWindowVM mainVM)
        {
            InitializeComponent();
            DataContext = new AuthPageVM(mainVM, capchaCanvas, textPassword);
        }
    }
}
