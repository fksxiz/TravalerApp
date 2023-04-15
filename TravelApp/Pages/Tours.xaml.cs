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
    /// Interaction logic for Tours.xaml
    /// </summary>
    public partial class Tours : Page
    {
        private CollectionViewSource ToursViewModel { get; set; }

        public Tours()
        {
            InitializeComponent();
            DataContext = this;
            ToursViewModel = new CollectionViewSource();
            UpdateBooksDataGrid(null);
        }

        public void UpdateBooksDataGrid(Data.Tour tour)
        {
            if (tour == null && ToursDataGrid.SelectedItem != null)
            {
                tour = ToursDataGrid.SelectedItem as Data.Tour;
            }
            ObservableCollection<Data.Tour> Tours = new ObservableCollection<Data.Tour>(Core.Database.Tour.Where(T => T.Id >= 0));
            ToursViewModel.Source = Tours;
            ToursDataGrid.ItemsSource = ToursViewModel.View;

            if (Tours.Count > 0)
            {
                ToursDataGrid.SelectedItem = tour;
                if (ToursDataGrid.SelectedIndex < 0)
                {
                    ToursDataGrid.SelectedIndex = 0;
                }
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Core.AppMainWindow.ClosePage();
        }

        private void ToursDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
