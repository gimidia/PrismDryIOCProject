using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDryIOCProject.Models
{
    public class Response
    {

        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public string Mensagem
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }


        public List<Metodo> DataCollection
        {
            get;
            set;
        }
    }
}
