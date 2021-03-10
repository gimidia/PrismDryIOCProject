using PrismDryIOCProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrismDryIOCProject.Services
{
    public interface IApiService
    {
        Task<Response> GetData(string urlBase);
    }
}
