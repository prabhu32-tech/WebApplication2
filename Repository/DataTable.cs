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

        public List<Project> GetProjectData(string Id) 
        {
            DataSet ds = new DataSet();
            List<Project> SelectListNew = new List<Project>();
            Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Project_Edit1_Prabhu_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProjectId", Id);

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.Customer_Name = Convert.ToString(ds.Tables[0].Rows[i]["CustomerName"]);
                    obj.Project_Name = Convert.ToString(ds.Tables[0].Rows[i]["ProjectName"]);
                    obj.Project_Id = Convert.ToString(ds.Tables[0].Rows[i]["ProjectId"]);
                    obj.ProjectStartDate = Convert.ToString(ds.Tables[0].Rows[i]["StartDate"]);
                    obj.ProjectEndDate = Convert.ToString(ds.Tables[0].Rows[i]["EndDate"]);
                    obj.Project_Status = Convert.ToString(ds.Tables[0].Rows[i]["ProjectStatus"]);
                    obj.LocationGroup = Convert.ToString(ds.Tables[0].Rows[i]["LocationGroup"]);
                    obj.State_Name = Convert.ToString(ds.Tables[0].Rows[i]["PayRollState"]);
                    obj.SalesPersonName = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.ProjectCategory = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCategory"]);
                    obj.Project_Type = Convert.ToString(ds.Tables[0].Rows[i]["ProjectType"]);
                    obj.Sub_Domain = Convert.ToString(ds.Tables[0].Rows[i]["SubDomain"]);
                    obj.TimeSheetRepresentative = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRepresentative"]);
                    obj.InvoiceGroup = Convert.ToString(ds.Tables[0].Rows[i]["ClientInvoiceGroup"]);
                    obj.TimesheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IsVmsTimeSheet = Convert.ToString(ds.Tables[0].Rows[i]["IsVmsTimeSheet"]);
                    obj.PracticeType = Convert.ToString(ds.Tables[0].Rows[i]["PracticeType"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                    SelectListNew.Add(obj);
                }
            }

            return SelectListNew;
        }

        public string UpdateTable(Project model)
        {
            Connection();
            SqlCommand com = new SqlCommand("Project_Update_Prabhu_Training", con);
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
                return "Form Updated";
            }
            else
            {
                return "Please Fill Valid Information";
            }

        }


        public List<Project> FindProjectData(int Project_Type, int PracticeType, string Customer_Name)
        {
            DataSet ds = new DataSet();
            List<Project> SelectListNew = new List<Project>();
            Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Manage_Project_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProjectType", Project_Type);
            cmd.Parameters.AddWithValue("@PracticeType", PracticeType);
            cmd.Parameters.AddWithValue("@CustomerName", Customer_Name);
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.Customer_Name = Convert.ToString(ds.Tables[0].Rows[i]["CustomerName"]);
                    obj.Project_Name = Convert.ToString(ds.Tables[0].Rows[i]["ProjectName"]);
                    obj.Project_Id = Convert.ToString(ds.Tables[0].Rows[i]["ProjectId"]);
                    obj.ProjectStartDate = Convert.ToString(ds.Tables[0].Rows[i]["StartDate"]);
                    obj.ProjectEndDate = Convert.ToString(ds.Tables[0].Rows[i]["EndDate"]);
                    obj.Project_Status = Convert.ToString(ds.Tables[0].Rows[i]["ProjectStatus"]);
                    obj.LocationGroup = Convert.ToString(ds.Tables[0].Rows[i]["LocationGroup"]);
                    obj.State_Name = Convert.ToString(ds.Tables[0].Rows[i]["PayRollState"]);
                    obj.SalesPersonName = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.ProjectCategory = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCategory"]);
                    obj.Project_Type = Convert.ToString(ds.Tables[0].Rows[i]["ProjectType"]);
                    obj.Sub_Domain = Convert.ToString(ds.Tables[0].Rows[i]["SubDomain"]);
                    obj.TimeSheetRepresentative = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRepresentative"]);
                    obj.InvoiceGroup = Convert.ToString(ds.Tables[0].Rows[i]["ClientInvoiceGroup"]);
                    obj.TimesheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IsVmsTimeSheet = Convert.ToString(ds.Tables[0].Rows[i]["IsVmsTimeSheet"]);
                    obj.PracticeType = Convert.ToString(ds.Tables[0].Rows[i]["PracticeType"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                    SelectListNew.Add(obj);
                }
            }

            return SelectListNew;
        }

    }
}