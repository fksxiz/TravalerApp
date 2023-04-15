using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TravelApp.Pages
{
    /// <summary>
    /// Interaction logic for Hotels.xaml
    /// </summary>
    public partial class Hotels : Page
    {
        private CollectionViewSource HotelsViewModel { get; set; }
        public Hotels()
        {
            InitializeComponent();
            DataContext = this;
            HotelsViewModel = new CollectionViewSource();
            UpdateHotelsDataGrid(null);
        }

        public void UpdateHotelsDataGrid(Data.Hotel hotel)
        {
            if (hotel == null && HotelsDataGrid.SelectedItem != null)
            {
                hotel = HotelsDataGrid.SelectedItem as Data.Hotel;
            }
            ObservableCollection<Data.Hotel> Hotels = new ObservableCollection<Data.Hotel>(Core.Database.Hotel.Where(T => T.Id >= 0));
            HotelsViewModel.Source = Hotels;
            HotelsDataGrid.ItemsSource = HotelsViewModel.View;

            if (Hotels.Count > 0)
            {
                HotelsDataGrid.SelectedItem = hotel;
                if (HotelsDataGrid.SelectedIndex < 0)
                {
                    HotelsDataGrid.SelectedIndex = 0;
                }
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Core.AppMainWindow.ClosePage();
        }
    }
}
