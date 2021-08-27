﻿using System;
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
        //[HttpPost]
        //[Route("Project/AddProject")]
        //public IHttpActionResult AddProject(ProjectController pc)
        //{
        //    return Ok();
        //}



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
    }
}
