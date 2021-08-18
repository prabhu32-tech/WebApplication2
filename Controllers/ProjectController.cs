using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Repository;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {
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
                InvoiceGP= invoiceGP
            };
            return View(empVM);
        }
    }
}