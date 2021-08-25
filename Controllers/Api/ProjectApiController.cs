using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Repository;

namespace WebApplication2.Controllers.Api
{
    public class ProjectController : ApiController
    {
        [HttpPost]
        [Route("Project/AddProject")]
        public IHttpActionResult AddProject(ProjectController pc)
        {
            return Ok();
        }



        [HttpGet]
        [Route("Project/GetStatusTrainingPrabhu")]
        public IHttpActionResult Status(int parentId)
        {
            Common objRepo = new Common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);

        }
        [HttpGet]
        [Route("Project/GetLocationGroupPrabhu")]
        public IHttpActionResult LocGroupList()
        {
            Common objRepo = new Common();
            var getComps = objRepo.GetLocGroup();
            return Ok(getComps);

        }
        [HttpGet]
        [Route("Project/GetProjectCatPrabhu")]
        public IHttpActionResult ProjectCatList()
        {
            Common objRepo = new Common();
            var projCat = objRepo.GetProjCat();
            return Ok(projCat);
        }
        [HttpGet]
        [Route("Project/GetProjectTypePrabhu")]
        public IHttpActionResult ProjectTypeList()
        {
            Common objRepo = new Common();
            var projType = objRepo.GetProjType();
            return Ok(projType);
        }
        [HttpGet]
        [Route("Project/GetSubDomainePrabhu")]
        public IHttpActionResult SubDomainList()
        {
            Common objRepo = new Common();
            var subDomain = objRepo.GetSubdomain();
            return Ok(subDomain);
        }
        [HttpGet]
        [Route("Project/GetTimeSheetPrabhu")]
        public IHttpActionResult TimeSheetList()
        {
            Common objRepo = new Common();
            var timeSheet = objRepo.GetTimeSheet();
            return Ok(timeSheet);
        }
        [HttpGet]
        [Route("Project/GetTimeSheetTypePrabhu")]
        public IHttpActionResult TimeSheeTypetList()
        {
            Common objRepo = new Common();
            var timeSheetType = objRepo.GetTimeSheetType();
            return Ok(timeSheetType);
        }
        [HttpGet]
        [Route("Project/GetPracticeTypePrabhu")]
        public IHttpActionResult PracticeTypeList()
        {
            Common objRepo = new Common();
            var pracType = objRepo.GetPracticeType();
            return Ok(pracType);
        }
        [HttpGet]
        [Route("Project/GetRecruiterPrabhu")]
        public IHttpActionResult RecruiterList()
        {
            Common objRepo = new Common();
            var recruiter = objRepo.GetRecruiter();
            return Ok(recruiter);
        }
        [HttpGet]
        [Route("Project/GetInvoiceGroupPrabhu")]
        public IHttpActionResult InvoiceGroupList()
        {
            Common objRepo = new Common();
            var invoiceGP = objRepo.GetInvoiceGroup();
            return Ok(invoiceGP);
        }
    }
}
