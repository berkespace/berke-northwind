using Frontend.Core.Database;
using Frontend.Core.Database.DataModels;
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

namespace Frontend
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ProductModel> products = new List<ProductModel>();
        public MainWindow()
        {
            InitializeComponent();
            PListBox.ItemsSource = products;
            PListBox.DisplayMemberPath = " ";
        }

        private void PSearchButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
          products = db.GetProducts(PsearchTextbox.Text); 
        }
    }
}
