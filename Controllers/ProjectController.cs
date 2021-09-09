using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {


        private SqlConnection con;
        

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
        // GET: Project
        public ActionResult Index()
        {
            Common objRepo = new Common();
            var appRefStatus = objRepo.GetAppRefData(1800);
            var locGroup = objRepo.GetLocGroup();
            var projCat = objRepo.GetProjCat();
            var projType = objRepo.GetProjType();
            var subDomain = objRepo.GetSubdomain();
            var timeSheet = objRepo.GetTimeSheet();
            var timeSheetType = objRepo.GetTimeSheetType();
            var pracType = objRepo.GetPracticeType();
            var recruiter = objRepo.GetRecruiter();
            var invoiceGP = objRepo.GetInvoiceGroup();
            var payrollState = objRepo.GetPayrollState(1);
            var salesPerson = objRepo.GetSalesPerson();
            //var getCust = objRepo.InsertUserDetails();
            //var insert = objRepo.AddProject();

            var empVM = new ProjectAddEditViewModel
            {
             Status= appRefStatus,
             LocGroup= locGroup,
             ProjCat= projCat,
             ProjType= projType,
             SubDomain= subDomain,
             TimeSheet= timeSheet,
             TimeSheetType= timeSheetType,
             PracType= pracType,
             Recruiter=recruiter,
             InvoiceGP= invoiceGP,
             PayrollState= payrollState,
             SalesPerson= salesPerson
                //Customer_Name= getCust,
                //Project_Name= insert
            };
            return View(empVM);
        }
        public ActionResult Table(ProjectAddEditViewModel model)
        {
            Connection();
            SqlCommand com = new SqlCommand("Project_DetailsPrabhu_Training", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustomerName", model.Project.Customer_Name);
            com.Parameters.AddWithValue("@ProjectName", model.Project.Project_Name);
            com.Parameters.AddWithValue("@ProjectId", model.Project.Project_Id);
            com.Parameters.AddWithValue("@StartDate", model.Project.ProjectStartDate);
            com.Parameters.AddWithValue("@EndDate", model.Project.ProjectEndDate);
            com.Parameters.AddWithValue("@ProjectStatus", model.Project.Project_Status);
            com.Parameters.AddWithValue("@LocationGroup", model.Project.LocationGroup);
            com.Parameters.AddWithValue("@PayrollState", model.Project.State_Name);
            com.Parameters.AddWithValue("@SalesPerson", model.Project.SalesPersonName);
            com.Parameters.AddWithValue("@ProjectCategory", model.Project.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", model.Project.Project_Type);
            com.Parameters.AddWithValue("@SubDomain", model.Project.Sub_Domain);
            com.Parameters.AddWithValue("@TimeSheetRepresentative", model.Project.TimeSheetRepresentative);
            com.Parameters.AddWithValue("@TimesheetType", model.Project.TimesheetType);
            com.Parameters.AddWithValue("@PracticeType", model.Project.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", model.Project.Recruiter);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", model.Project.InvoiceGroup);
            com.Parameters.AddWithValue("@IsVmsTimeSheet", model.Project.IsVmsTimeSheet);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
        public ActionResult GetList()
        {
            var result =new Repository.Common().GetProjectList();


            return View(result);
        }

        public ActionResult AddProject()
        {
            
            return View();
        }

        public ActionResult DataTable()
        {

            
            return View();
        }
        public ActionResult Edit(string Id)
        {
            //var result = new Repository.DataTable().GetProjectData(Id);
           // Repository.DataTable sbd = new Repository.DataTable();
           // var xyz = sbd.GetProjectData(Id).Find(Project => Project.Project_Id == Id);
            return View();
            //string _data = "";
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Project_Edit_Prabhu_Training", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@ProjectId", Project_Id);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //con.Close();
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    _data = JsonConvert.SerializeObject(ds.Tables[0]);
            //}

            //return View(_data);
        }
        [HttpPost]
        public ActionResult Edit(string Project_Id, Project smodel)
        {
           

            try
            {
                Repository.DataTable sbd = new Repository.DataTable();
                sbd.GetProjectData(Project_Id);                                                        
                return RedirectToAction("GetList");
            }
            catch
            {
                return View();
            }
        }
    }
}