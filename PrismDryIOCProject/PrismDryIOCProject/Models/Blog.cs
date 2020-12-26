using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDryIOCProject.Models
{
    public class Blog
    {
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
