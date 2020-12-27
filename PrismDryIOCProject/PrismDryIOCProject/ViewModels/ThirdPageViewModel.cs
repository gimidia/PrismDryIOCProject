using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDryIOCProject.ViewModels
{
    public class ThirdPageViewModel : ViewModelBase
    {
        public ThirdPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Title = parameters.GetValue<string>("title");
            
        }
    }
}
