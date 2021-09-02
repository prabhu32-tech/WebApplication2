using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Repository
{
    public class DataTable
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
  

        public string SaveTable(Project model)
        {
            Connection();
            SqlCommand com = new SqlCommand("Project_DataTable_Prabhu_Training", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustomerName", model.Customer_Name);
            com.Parameters.AddWithValue("@ProjectName", model.Project_Name);
            com.Parameters.AddWithValue("@ProjectId", model.Project_Id);
            com.Parameters.AddWithValue("@StartDate", model.ProjectStartDate);
            com.Parameters.AddWithValue("@EndDate", model.ProjectEndDate);
            com.Parameters.AddWithValue("@ProjectStatus", model.Project_Status);
            com.Parameters.AddWithValue("@LocationGroup", model.LocationGroup);
            com.Parameters.AddWithValue("@PayrollState", model.State_Name);
            com.Parameters.AddWithValue("@SalesPerson", model.SalesPersonName);
            com.Parameters.AddWithValue("@ProjectCategory", model.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", model.Project_Type);
            com.Parameters.AddWithValue("@SubDomain", model.Sub_Domain);
            com.Parameters.AddWithValue("@TimeSheetRepresentative", model.TimeSheetRepresentative);
            com.Parameters.AddWithValue("@TimesheetType", model.TimesheetType);
            com.Parameters.AddWithValue("@PracticeType", model.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", model.Recruiter);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", model.InvoiceGroup);
            com.Parameters.AddWithValue("@IsVmsTimeSheet", model.IsVmsTimeSheet);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return "Form Submitted";
            }
            else
            {
                return "Please Fill Valid Information";
            }
        }
    }
}