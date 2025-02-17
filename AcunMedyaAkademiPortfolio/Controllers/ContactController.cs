using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult ContactList()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int ID)
        {
            var values = db.TblContact.Find(ID);
            db.TblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(TblContact p)
        {
            db.TblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}