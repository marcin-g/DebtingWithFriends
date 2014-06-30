using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DeptingWithFriends.Resources;

namespace DeptingWithFriends
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        ApplicationBar SaldoApplicationBar;
        ApplicationBar HistoryApplicationBar;
        ApplicationBar DefaultApplicationBar;
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            SaldoApplicationBar = new ApplicationBar();
            HistoryApplicationBar = new ApplicationBar();
            DefaultApplicationBar = new ApplicationBar();

            SaldoApplicationBar.Mode = ApplicationBarMode.Default;
            SaldoApplicationBar.Opacity = 1.0;
            SaldoApplicationBar.IsVisible = true;
            SaldoApplicationBar.IsMenuEnabled = true;

            HistoryApplicationBar.Mode = ApplicationBarMode.Default;
            HistoryApplicationBar.Opacity = 1.0;
            HistoryApplicationBar.IsVisible = true;
            HistoryApplicationBar.IsMenuEnabled = true;

            DefaultApplicationBar.Mode = ApplicationBarMode.Minimized;
            DefaultApplicationBar.Opacity = 1.0;
            DefaultApplicationBar.IsVisible = true;
            DefaultApplicationBar.IsMenuEnabled = true;

            ApplicationBarIconButton add = new ApplicationBarIconButton();
            add.IconUri = new Uri("/Images/add.png", UriKind.Relative);
            ApplicationBarIconButton settings = new ApplicationBarIconButton();
            settings.IconUri = new Uri("/Images/settings.png", UriKind.Relative);
            ApplicationBarIconButton search = new ApplicationBarIconButton();
            search.IconUri = new Uri("/Images/search.png", UriKind.Relative);
            add.Text = AppResources.Add;
            settings.Text = AppResources.Settings;
            search.Text = AppResources.Search;
            SaldoApplicationBar.Buttons.Add(add);
            SaldoApplicationBar.Buttons.Add(settings);
            HistoryApplicationBar.Buttons.Add(search);

            ApplicationBarMenuItem help = new ApplicationBarMenuItem();
            help.Text = AppResources.Help;
            SaldoApplicationBar.MenuItems.Add(help);
            HistoryApplicationBar.MenuItems.Add(help);
            DefaultApplicationBar.MenuItems.Add(help);
            ApplicationBarMenuItem about = new ApplicationBarMenuItem();
            about.Text = AppResources.About;
            SaldoApplicationBar.MenuItems.Add(about);
            HistoryApplicationBar.MenuItems.Add(about);
            DefaultApplicationBar.MenuItems.Add(about);

            ApplicationBar = SaldoApplicationBar;
        }




        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void ApplicationBar_Add_Click(object sender, EventArgs e)
        {

        }
        private void ApplicationBar_Settings_Click(object sender, EventArgs e)
        {

        }
        private void ApplicationBar_About_Click(object sender, EventArgs e)
        {

        }
        private void ApplicationBar_Help_Click(object sender, EventArgs e)
        {

        }

        private void Panorama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int currentIndex = ((Panorama)sender).SelectedIndex;//((PanoramaItem)(((Panorama)sender).SelectedIndex));
            switch(currentIndex){
                case 0:
                    ApplicationBar = SaldoApplicationBar;
                    break;
                case 1:
                    ApplicationBar = HistoryApplicationBar;
                    break;
                default:
                    ApplicationBar=DefaultApplicationBar;
                    break;
              }
        }

        
    }
}