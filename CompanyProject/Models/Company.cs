using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyProject.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Company_Name { get; set; }
        public string Owner { get; set; }
        public int Employes { get; set; }
        public string Product { get; set; }
        public string Location { get; set; }
    }
}