using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ООО__Столовые_приборы_.Models;
using ООО__Столовые_приборы_.Tools;

namespace ООО__Столовые_приборы_.ViewModel
{
    public class ProductLictPageVM : BaseVM
    {

        private List<Product> products;
        private User user;

        public Command AddProduct { get; set; }
        public Command EditProduct { get; set; }
        public Command RemoveProduct { get; set; }

        public Visibility IsAdminVisibility { get => user.UserRole == 1 ? Visibility.Visible : Visibility.Collapsed; }

        public ProductLictPageVM(MainWindowVM mainVM)
        {
            Products = DB.user09Context.GetInstance().Products.ToList();
            this.user = Auth.Auth.CurrentUser;

            AddProduct = new Command(() =>
            {

            });

            EditProduct = new Command(() =>
            {

            });

            RemoveProduct = new Command(() =>
            {

            });
        }

        public List<Product> Products
        {
            get => products;
            set
            {
                products = value;
                SignalChanged();
            }

        }

    }
}
