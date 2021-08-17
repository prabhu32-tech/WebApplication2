using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Project
    {
        [Display(Name = "Customer Name")]
        public string Customer_Name { get; set; }

        [Display(Name = "Project Name")]
        public string Project_Name { get; set; }

        public string Project_Id { get; set; }

        [Display(Name = "Project Start Date")]
        [DataType(DataType.Date)]
        public string ProjectStartDate { get; set; }

        [Display(Name = "Project End Date")]
        [DataType(DataType.Date)]
        public string ProjectEndDate { get; set; }
        public string Project_Status { get; set; }

        [Display(Name = "Location Group")]
        public string LocationGroup { get; set; }
        public string State_Name { get; set; }

        public string SalesPersonName { get; set; }


        [Display(Name = "Project Category")]
        public string ProjectCategory { get; set; }

        [Display(Name = "Project Type")]
        public string Project_Type { get; set; }


        [Display(Name = "Sub Domain ")]
        public string Sub_Domain { get; set; }


        [Display(Name = "TimeSheet Representative ")]
        public string TimeSheetRepresentative { get; set; }


        [Display(Name = "TimeSheet Type ")]
        public string TimesheetType { get; set; }

        public string PracticeType { get; set; }

        public string Recruiter { get; set; }

        public string InvoiceGroup { get; set; }


    }
}