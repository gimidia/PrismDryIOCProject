using Microcharts;
using System.Collections.Generic;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;

namespace PrismDryIOCProject.Views
{
    public partial class SecondPage : ContentPage
    {

        //List<Entry> planejado = new List<Entry>
        //{
        //    new Entry(137)
        //    {
        //        Color = SkiaSharp.SKColor.Parse("#00FF00"),
        //        Label = "Planejado",
        //        ValueLabel = "137"
        //    }
        //};

        //List<Entry> realizado = new List<Entry>
        //{
        //    new Entry(107)
        //    {
        //        Color = SkiaSharp.SKColor.Parse("#FF4500"),
        //        Label = "Realizado",
        //        ValueLabel = "107"
        //    }
        //};

        public SecondPage()
        {
            InitializeComponent();

            //Chart1.Chart = new RadialGaugeChart { Entries = planejado };
            //Chart2.Chart = new RadialGaugeChart { Entries = realizado };
        }
    }
}
