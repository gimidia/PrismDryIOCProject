using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Entry = Microcharts.ChartEntry;
using Chart = Microcharts.Chart;
using Prism.Navigation;
using PrismDryIOCProject.Models;
using Microcharts;

namespace PrismDryIOCProject.ViewModels
{
    public class ChartPageViewModel : ViewModelBase
    {

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

        private Metodo _chartdetail;
        public Metodo ChartDetail
        {
            get { return _chartdetail; }
            set { SetProperty(ref _chartdetail, value); }
        }

        public ChartPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            ChartDetail = (Metodo)parameters["Chart"];
            Title = ChartDetail.Nome;
            Planejado = ChartDetail.Planejado;
            Realizado = ChartDetail.Realizado;
            var ValuePlanejado = Convert.ToInt32(ChartDetail.Planejado);
            var ValueRealizado = Convert.ToInt32(ChartDetail.Realizado);


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
