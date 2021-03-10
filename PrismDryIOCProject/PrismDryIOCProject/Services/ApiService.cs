using Newtonsoft.Json;
using Polly;
using PrismDryIOCProject.Exceptions;
using PrismDryIOCProject.Helpers;
using PrismDryIOCProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrismDryIOCProject.Services
{
    public class ApiService : IApiService
    {
        public async Task<Response> GetData(string urlBase)
        {
            var Url = urlBase;
            HttpClient client = new HttpClient();

            string content = await client.GetStringAsync(Url); 
            var resultado = JsonConvert.DeserializeObject<List<Metodo>>(content);
            return new Response
            {
                DataCollection = resultado
            };

            
        }
    }


}
