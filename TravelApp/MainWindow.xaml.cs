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

namespace TravelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CurrectPageIndex;
        private List<Page> ActivePages;


        public MainWindow()
        {
            InitializeComponent();
            Core.AppMainWindow = this;
            //Создание списка страниц
            ActivePages = new List<Page>();
            CurrectPageIndex = -1;
        }

        public void ClosePage()
        {
            if (ActivePages.Count > 0)
            {
                ActivePages.RemoveAt(CurrectPageIndex);
                if (CurrectPageIndex > 0)
                {
                    CurrectPageIndex--;
                }
                else
                {
                    if (CurrectPageIndex >= ActivePages.Count)
                    {
                        CurrectPageIndex--;
                    }
                }
                if (CurrectPageIndex >= 0)
                {
                    RootFrame.Navigate(ActivePages[CurrectPageIndex]);
                }
                else
                {
                    RootFrame.Navigate(null);
                }
            }
        }

        private int GetActivePageIndexByType(Type PageType)
        {
            int Index = ActivePages.Count - 1;
            while (Index >= 0 && ActivePages[Index].GetType() != PageType)
            {
                Index--;
            }
            return Index;
        }

        private void ShowPage(Type PageType)
        {
            if (PageType != null)
            {
                Page Page;
                CurrectPageIndex = GetActivePageIndexByType(PageType);
                if (CurrectPageIndex < 0)
                {
                    //Создание страницы
                    Page = (Page)Activator.CreateInstance(PageType);
                    ActivePages.Add(Page);
                    CurrectPageIndex = ActivePages.Count - 1;
                }
                else
                {
                    Page = ActivePages[CurrectPageIndex];
                }
                RootFrame.Navigate(Page); 
            }
        }


        private void ToursButton_Click_1(object sender, RoutedEventArgs e)
        {
            ShowPage(typeof(Pages.Tours));
        }

        private void HotelsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowPage(typeof(Pages.Hotels));
        }
    }
}
