using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System.Diagnostics;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismDryIOCProject.Models;
using System.Collections.ObjectModel;
using PrismDryIOCProject.Services;
using System.Threading.Tasks;
using PrismDryIOCProject.Helpers;

namespace PrismDryIOCProject.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Metodo> _colecao;
        private bool _isbusy;

        IApiService _ApiService;

        private readonly INavigationService _navigationService;
        public DelegateCommand SecondPageCommand { get; set; }
        public DelegateCommand DisplayAlertCommand { get; }
        private IPageDialogService _pageDialogService { get; }
        public DelegateCommand NavigateToChartCommand { get; private set; }

        private Metodo _selectedChart;
        public Metodo SelectedChart
        {
            get { return _selectedChart; }
            set { SetProperty(ref _selectedChart, value); }
        }

        public ObservableCollection<Metodo> ColecaoData
        {
            get { return this._colecao; }
            set { SetProperty(ref this._colecao, value); }
        }

        public bool IsBusy
        {
            get { return _isbusy; }
            set { SetProperty(ref _isbusy, value); }
        }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IApiService apiService)
            : base(navigationService)
        {
            ColecaoData = new ObservableCollection<Metodo>();
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;

            _ApiService = apiService;


            SecondPageCommand = new DelegateCommand(SecondPageAction);

            Title = "Main Page";

            NavigateToChartCommand = new DelegateCommand(NavigateToChart, () => SelectedChart != null).ObservesProperty(() => SelectedChart);
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            await LoadAsync();

        }

        private async void NavigateToChart()
        {
            var parameter = new NavigationParameters();
            parameter.Add("Chart", SelectedChart);

            await NavigationService.NavigateAsync("ChartPage", parameter);
        }
        private async void SecondPageAction()
        {
            var parameter = new NavigationParameters();
            parameter.Add("title", "SecondPage");
            await _navigationService.NavigateAsync("SecondPage", parameter);
        }

        private async Task LoadAsync()
        {
            try
            {
                IsBusy = true;
                var response = await _ApiService.GetData(ApiURL.ApiBaseUrl);

                var resultMetodoCollection = response.DataCollection;
                ColecaoData.Clear();
                ColecaoData = new ObservableCollection<Metodo>(resultMetodoCollection);

            }
            catch (Exception ex)
            {
                await _pageDialogService.DisplayAlertAsync("Erro", "Erro ao Carregar Dados da Api:" + ex.Message, "OK");
            }
            finally
            {

                IsBusy = false;
            }
        }
    }
}
