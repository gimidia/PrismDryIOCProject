using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDryIOCProject.Models;
using PrismDryIOCProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace PrismDryIOCProject.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public ObservableCollection<MyMenuItem> MenuItems { get; set; }

        private MyMenuItem selectedMenuItem;
        public MyMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<MyMenuItem>();

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "ic_viewa",
                PageName = nameof(MainPage),
                Title = "MainPage"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "ic_viewb",
                PageName = nameof(SecondPage),
                Title = "SecondPage"
            });

            NavigateCommand = new DelegateCommand(Navigate);
        }

        async void Navigate()
        {
            //await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedMenuItem.PageName);
            await _navigationService.NavigateAsync("NavigationPage"+ "/"+ SelectedMenuItem.PageName);
        }
    }
}
