using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;

namespace ADFS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Microsoft.IdentityModel.Tokens.

            return View();
        }

        public ActionResult ShowClaims()
        {
            ViewBag.Message = "Your application description page.";
            return View((User as ClaimsPrincipal).Claims);

            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}