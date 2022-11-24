using System;
using System.Collections.Generic;
using System.IO;
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
using ООО__Столовые_приборы_.Models;
using ООО__Столовые_приборы_.DB;
using ООО__Столовые_приборы_.ViewModel;

namespace ООО__Столовые_приборы_
{
   

   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
            //Load();
        }
        private void Load()
        {
            // Scaffold-DbContext "server=192.168.1.15\SQLEXPRESS;database=DE;user=student;password=student" Microsoft.EntityFrameworkCore.SqlServer -force
            //OrderProduct - кросс сущность
            /*var bd = new user09Context();
            string file = @"C:\Users\Student\Desktop\Подготовка к ДЭ\Заказ_import.csv";
            string[] rows = File.ReadAllLines(file).Skip(1).ToArray();
            var spl = new char[] { ';' };

            foreach (var row in rows)
            {
                var cols = row.Split(spl);
                var article = cols[1].Split(',');

                OrderProduct orderProduct1 = new OrderProduct
                {
                    OrderId = int.Parse(cols[0]),
                    ProductArticleNumber = article[0],
                    OrderCount = int.Parse(article[1])
                };

                OrderProduct orderProduct2 = new OrderProduct
                {
                    OrderId = int.Parse(cols[0]),
                    ProductArticleNumber = article[2],
                    OrderCount = int.Parse(article[3])
                };
                bd.OrderProducts.AddRange(orderProduct1, orderProduct2);  
            }
            bd.SaveChanges();
            */

            // Картинки
            /*var bd = new user09Context();
            string file = @"C:\Users\Student\Desktop\Подготовка к ДЭ\Товар_import_Столовые приборы.csv";
            string dirImage = @"C:\Users\Student\Desktop\Подготовка к ДЭ\09_1.1-2022_3\Вариант 3\Вариант 3\Сессия 1\Товар_import\";
            string[] rows = File.ReadAllLines(file).Skip(1).ToArray();
            var spl = new char[] { ';' };
            foreach(string row in rows)
            {
                var cols = row.Split(spl, StringSplitOptions.RemoveEmptyEntries);

                if(cols.Length == 12)
                {
                    var product = bd.Products.FirstOrDefault(s => s.ProductArticleNumber==cols[0]);
                    product.ProductPhoto = File.ReadAllBytes(dirImage + cols[11]);
                }
            }
            bd.SaveChanges();*/


        }
    }
}
