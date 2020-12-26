using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDryIOCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDryIOCProject.ViewModels
{
    public class BlogPageViewModel : ViewModelBase
    {
        public BlogPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
        }


        private Blog _blogDetail;
        public Blog BlogDetail
        {
            get { return _blogDetail; }
            set { SetProperty(ref _blogDetail, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            BlogDetail = (Blog)parameters["Blog"];
            Title = BlogDetail.BlogTitle;


        }
    }
}
