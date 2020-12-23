using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System.Diagnostics;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismDryIOCProject.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand SecondPageCommand { get; set; }
        public DelegateCommand DisplayAlertCommand { get; }
        private IPageDialogService _pageDialogService { get; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            SecondPageCommand = new DelegateCommand(SecondPageAction);
            DisplayAlertCommand = new DelegateCommand(DisplayAlert);

            Title = "Main Page";
        }


        private async void SecondPageAction()
        {
            await _navigationService.NavigateAsync("SecondPage");
        }

        private async void DisplayAlert()
        {
            var result = await _pageDialogService.DisplayAlertAsync("Alert", "This is an alert from MainPageViewModel.", "Accept", "Cancel");
            Trace.WriteLine(result);
        }
    }
}
