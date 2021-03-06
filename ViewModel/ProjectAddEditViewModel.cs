using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class ProjectAddEditViewModel
    {

        public Project Project { get; set; }
        public List<AppRefData> Status { get; set; }

        public List<AppRefData> LocGroup { get; set; }
        public List<AppRefData> ProjCat { get; set; }

        public List<AppRefData> ProjType { get; set; }

        public List<AppRefData> SubDomain { get; set; }
        public List<AppRefData> TimeSheet { get; set; }
        public List<AppRefData> TimeSheetType { get; set; }
        public List<AppRefData> PracType { get; set; }

        public List<AppRefData> Recruiter { get; set; }
        public List<AppRefData> InvoiceGP { get; set; }
        public List<AppRefData> PayrollState { get; set; }

        public List<AppRefData> SalesPerson { get; set; }




    }
}