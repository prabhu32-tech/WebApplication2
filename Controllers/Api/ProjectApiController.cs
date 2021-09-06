using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using WebApplication2.Models;
using WebApplication2.Repository;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers.Api
{
    public class ProjectController : ApiController
    {
        [HttpPost]
        [Route("Project/ProjectAdd")]
        public IHttpActionResult AddProject(Project pc)
        {
            DataTable objRepo = new DataTable();
            var dataTable = objRepo.SaveTable(pc);
            return Ok(dataTable);
        }



        [HttpGet]
        [Route("Project/GetStatusTraining")]
        public IHttpActionResult Status(int parentId)
        {
            Common objRepo = new Common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);

        }
        [HttpGet]
        [Route("Project/GetLocationGroup")]
        public IHttpActionResult LocGroupList()
        {
            Common objRepo = new Common();
            var getComps = objRepo.GetLocGroup();
            return Ok(getComps);

        }
        [HttpGet]
        [Route("Project/GetProjectCat")]
        public IHttpActionResult ProjectCatList()
        {
            Common objRepo = new Common();
            var projCat = objRepo.GetProjCat();
            return Ok(projCat);
        }
        [HttpGet]
        [Route("Project/GetProjectType")]
        public IHttpActionResult ProjectTypeList()
        {
            Common objRepo = new Common();
            var projType = objRepo.GetProjType();
            return Ok(projType);
        }
        [HttpGet]
        [Route("Project/GetSubDomain")]
        public IHttpActionResult SubDomainList()
        {
            Common objRepo = new Common();
            var subDomain = objRepo.GetSubdomain();
            return Ok(subDomain);
        }
        [HttpGet]
        [Route("Project/GetTimeSheet")]
        public IHttpActionResult TimeSheetList()
        {
            Common objRepo = new Common();
            var timeSheet = objRepo.GetTimeSheet();
            return Ok(timeSheet);
        }
        [HttpGet]
        [Route("Project/GetTimeSheetType")]
        public IHttpActionResult TimeSheeTypetList()
        {
            Common objRepo = new Common();
            var timeSheetType = objRepo.GetTimeSheetType();
            return Ok(timeSheetType);
        }
        [HttpGet]
        [Route("Project/GetPracticeType")]
        public IHttpActionResult PracticeTypeList()
        {
            Common objRepo = new Common();
            var pracType = objRepo.GetPracticeType();
            return Ok(pracType);
        }
        [HttpGet]
        [Route("Project/GetRecruiter")]
        public IHttpActionResult RecruiterList()
        {
            Common objRepo = new Common();
            var recruiter = objRepo.GetRecruiter();
            return Ok(recruiter);
        }
        [HttpGet]
        [Route("Project/GetInvoiceGroup")]
        public IHttpActionResult InvoiceGroupList()
        {
            Common objRepo = new Common();
            var invoiceGP = objRepo.GetInvoiceGroup();
            return Ok(invoiceGP);
        }
        [HttpGet]
        [Route("Project/GetAllDetails")]
        public IHttpActionResult ProjectDetailsList()
        {
            Common objRepo = new Common();
            var projects = objRepo.GetProjectList();
            return Ok(projects);
        }
        [HttpGet]
        [Route("Project/GetAllPayrollState")]
        public IHttpActionResult PayrollStateList()
        {
            Common objRepo = new Common();
            var payrollState = objRepo.GetPayrollState(1);
            return Ok(payrollState);
        }
        [HttpGet]
        [Route("Project/GetAllSalesPerson")]
        public IHttpActionResult SalesPersonList()
        {
            Common objRepo = new Common();
            var salesPerson = objRepo.GetSalesPerson();
            return Ok(salesPerson);
        }
        [HttpGet]
        [Route("ProjectApi/GetProjectList")]
        public IHttpActionResult ProjectList()
        {
            Common objRepo = new Common();
            var pro = objRepo.GetProjectList();
            return Ok(pro);
        }

        //[HttpGet]
        //[Route("ProjectApi/GetProjectDataList")]
        //public IHttpActionResult ProjecDatatList()
        //{
        //    //DataTable objRepo = new DataTable();
        //    //var pro = objRepo.GetProjectData(project_Id);
        //    //return Ok(pro);
        //}
    }
}
