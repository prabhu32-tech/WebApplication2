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
        [Route("Project/projectStatus")]
        public IHttpActionResult AddProject(ProjectController pc)
        {
            return Ok();
        }



        [HttpGet]
        [Route("Project/GetAppRefDataPrabhu")]
        public IHttpActionResult Status(int parentId)
        {
            Common objRepo = new Common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);

        }

    }
}
