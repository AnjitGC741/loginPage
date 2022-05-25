using loginPagePraticse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginPagePraticse.Controllers
{
    public class forCreateAccountController : Controller
    {
        tryLoginPageEntities db = new tryLoginPageEntities();
        // GET: forCreateAccount
        public ActionResult createAccount()
        {
            return View();
        }
        public ActionResult saveData(string userName,string email,string country,string password)
         {

             userRecord value = new userRecord();
             value.userName = userName;
             value.email = email; 
             value.country = country; 
             value.password = password;
             db.userRecords.Add(value);
             db.SaveChanges();
             return RedirectToAction("home", "forHomePage");

         }
      /*  public ActionResult saveData(string userName,string email,string country,string password )
           {
               db.userRecords.Add("userName","email","country","password");
               db.SaveChanges();
               return RedirectToAction("home", "forHomePage");
           }
       /* public ActionResult saveData(userRecord userRecord)
           {
               db.userRecords.Add(userRecord);
               db.SaveChanges();
               return RedirectToAction("home", "forHomePage");
           }*/
      
    }
}