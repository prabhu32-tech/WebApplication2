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
        [HttpGet]
        public IHttpActionResult GetProjects()
        {
            var pj = new Common().GetAppRefData(1800);

            return Ok(pj);

        }

    }
}
