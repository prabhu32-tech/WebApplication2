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
        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese provide valid Customer Name")]
        public string Customer_Name { get; set; }

        [Display(Name = "Project Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese provide valid Project Name")]
        public string Project_Name { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese provide valid Project Id")]
        public string Project_Id { get; set; }

        [Display(Name = "Project Start Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese provide valid Date ")]      
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public string ProjectStartDate { get; set; }

        [Display(Name = "Project End Date")]
       // [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese provide valid Date ")]
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string ProjectEndDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Status ")]
        public string Project_Status { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Location Group ")]
        [Display(Name = "Location Group")]
        public string LocationGroup { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select State Name  ")]
        public string State_Name { get; set; }

        public string SalesPersonName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Project Category  ")]
        [Display(Name = "Project Category")]
        public string ProjectCategory { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Project Category  ")]
        [Display(Name = "Project Type")]
        public string Project_Type { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Sub Domain  ")]
        [Display(Name = "Sub Domain ")]
        public string Sub_Domain { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select TimeSheet Representative  ")]
        [Display(Name = "TimeSheet Representative ")]
        public string TimeSheetRepresentative { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select TimeSheet Type  ")]
        [Display(Name = "TimeSheet Type ")]
        public string TimesheetType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Practice Type  ")]
        [Display(Name = "Practice Type ")]
        public string PracticeType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Recruiter   ")]
        public string Recruiter { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese select Invoice Group   ")]
        [Display(Name = "Invoice Group ")]
        public string InvoiceGroup { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Plese type Yes or No   ")]
            
         public string IsVmsTimeSheet { get; set; }


    }
}