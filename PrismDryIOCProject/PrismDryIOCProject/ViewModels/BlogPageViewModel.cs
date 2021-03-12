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

        private string _planejado;
        public string Planejado
        {
            get { return _planejado; }
            set { SetProperty(ref _planejado, value); }
        }

        private string _realizado;
        public string Realizado
        {
            get { return _realizado; }
            set { SetProperty(ref _realizado, value); }
        }

        private Chart _charts;
        public Chart Charts
        {
            get { return _charts; }
            set { SetProperty(ref _charts, value); }
        }

        private Metodo _blogDetail;
        public Metodo BlogDetail
        {
            get { return _blogDetail; }
            set { SetProperty(ref _blogDetail, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            BlogDetail = (Metodo)parameters["Blog"];
            Title = BlogDetail.Nome;
            Planejado = BlogDetail.Planejado;
            Realizado = BlogDetail.Realizado;
            var ValuePlanejado = Convert.ToInt32(BlogDetail.Planejado);
            var ValueRealizado = Convert.ToInt32(BlogDetail.Realizado);


            List<Entry> EntryCharts = new List<Entry>
            {
                new Entry(ValuePlanejado)
                {
                    Color = SkiaSharp.SKColor.Parse("#008000"),
                    Label = "Planejato",
                    ValueLabel = Planejado,
                    ValueLabelColor = SkiaSharp.SKColor.Parse("#008000")

                },

                new Entry(ValueRealizado)
                {
                    Color = SkiaSharp.SKColor.Parse("#FF4500"),
                    Label = "Realizado",
                    ValueLabel = Realizado,
                    ValueLabelColor = SkiaSharp.SKColor.Parse("#FF4500")
                }
            };

            Charts = new DonutChart { Entries = EntryCharts };

        }
    }
}
