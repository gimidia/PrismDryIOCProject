using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrismDryIOCProject.Models
{
    public class Data
    {

        [JsonProperty("metodos")]
        public List<Metodo> Metodos { get; set; }

    }

    public class Metodo
    {
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "planejado")]
        public string Planejado { get; set; }
       
        [JsonProperty(PropertyName = "realizado")]
        public string Realizado { get; set; }

        [JsonProperty(PropertyName = "periodoInicio")]
        public string PeriodoInicio { get; set; }

        [JsonProperty(PropertyName = "periodoFim")]
        public string PeriodoFim { get; set; }

        [JsonProperty(PropertyName = "unidadeMedida")]
        public string UnidadeMedida { get; set; }

        [JsonProperty(PropertyName = "unidadeMedidaSigla")]
        public string UnidadeMedidaSigla { get; set; }
 
    }
}
