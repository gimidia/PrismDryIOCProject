using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDryIOCProject.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand ThirdPageCommand { get; }

        private NavigationMode _navigationMode;
        public NavigationMode NavigationMode
        {
            get { return _navigationMode; }
            set { SetProperty(ref _navigationMode, value); }
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }

        public SecondPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            _navigationService = navigationService;
            ThirdPageCommand = new DelegateCommand(ThirdPageAction);
        }

        private async void ThirdPageAction()
        {
            await _navigationService.NavigateAsync("ThirdPage");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            NavigationMode = parameters.GetNavigationMode();
            Title = parameters.GetValue<string>("title");
            IsVisible = NavigationMode == NavigationMode.Back;
        }
    }
}
