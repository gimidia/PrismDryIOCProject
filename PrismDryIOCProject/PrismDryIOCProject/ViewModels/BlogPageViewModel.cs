using Microcharts;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDryIOCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Entry = Microcharts.ChartEntry;
using Chart = Microcharts.Chart;

namespace PrismDryIOCProject.ViewModels
{
    public class BlogPageViewModel : ViewModelBase
    {
        public BlogPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
