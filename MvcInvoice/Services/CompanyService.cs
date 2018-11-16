using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcInvoice.Models;
using MvcInvoice.Repositories;

namespace MvcInvoice.Services
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository repo = null;


        public CompanyService()
        {
            repo = new CompanyRepository();
        }

        public void Create(Company entity)
        {
            this.repo.Create(entity);
        }

        public void Delete(Company entity)
        {
            this.repo.Delete(entity);
        }

        public Company Find(int Id)
        {
            return this.repo.Find(Id);
        }

        public IEnumerable<Company> Read()
        {
            return this.repo.Read();
        }

        public void Update(Company entity)
        {
            this.repo.Update(entity);
        }
    }
}