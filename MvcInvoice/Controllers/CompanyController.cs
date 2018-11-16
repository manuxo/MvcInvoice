using MvcInvoice.Models;
using MvcInvoice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInvoice.Controllers
{
    public class CompanyController : Controller
    {
        private ICompanyService companyService = null;

        public CompanyController()
        {
            this.companyService = new CompanyService();
        }

        // GET: Company
        public ViewResult Index()
        {
            var companies = companyService.Read();
            return View(companies);
        }

        // GET: Company/Create
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Create(Company entity)
        {
            this.companyService.Create(entity);
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Delete(int id)
        {
            var company = companyService.Find(id);
            this.companyService.Delete(company);
            return RedirectToAction("Index");
        }

        // GET: Company/Edit
        public ViewResult Edit(int id)
        {
            var company = companyService.Find(id);
            return View(company);
        }

        // POST: Company/Edit
        [HttpPost]
        public RedirectToRouteResult Edit(Company entity)
        {
            this.companyService.Update(entity);
            return RedirectToAction("Index");
        }

        // GET: Company/Details/{id}
        public ViewResult Details(int id)
        {
            var company = this.companyService.Find(id);
            return View(company);
        }
    }
}