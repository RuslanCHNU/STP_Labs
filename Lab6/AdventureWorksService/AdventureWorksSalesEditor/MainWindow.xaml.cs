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

namespace AdventureWorksSalesEditor
{
    public partial class MainWindow : Window
    {
        private AdventureWorksService.AdventureWorksServiceClient client;
        private List<AdventureWorksService.SalesOrderHeader> orders;
        private int currentIndex = 0;

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            client = new AdventureWorksService.AdventureWorksServiceClient();
            var array = await client.GetOrdersAsync();
            orders = array.ToList();
            ordersGrid.ItemsSource = new List<AdventureWorksService.SalesOrderHeader> { orders[currentIndex] };
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0) ordersGrid.ItemsSource = new[] { orders[--currentIndex] };
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < orders.Count - 1) ordersGrid.ItemsSource = new[] { orders[++currentIndex] };
        }

        private async void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var current = (AdventureWorksService.SalesOrderHeader)ordersGrid.Items[0];
            await client.UpdateOrderAsync(current);
            MessageBox.Show("Зміни збережено");
        }
    }
}
