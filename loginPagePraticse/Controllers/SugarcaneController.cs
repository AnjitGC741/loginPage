using loginPagePraticse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginPagePraticse.Controllers
{
    public class SugarcaneController : Controller
    {
        tryLoginPageEntities db = new tryLoginPageEntities();
        // GET: Sugarcane
        public ActionResult loginPage()
        {
            return View();
        }
        public ActionResult check(string userName,string password)
        {
            var countUserName = db.userRecords.Where(x => x.userName == userName);
            var countPassword = db.userRecords.Where(x => x.password == password);
            if(countUserName.Count() == 0 || countPassword.Count() == 0)
            {
                Session["error"] = "false";
                return RedirectToAction("loginPage");
            }
            return RedirectToAction("home","forHomePage");
        }
    }
}