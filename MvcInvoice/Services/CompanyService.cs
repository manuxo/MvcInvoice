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

        public void Create(Company entity)
        {
            using(repo = new CompanyRepository())
            {
                repo.Create(entity);
            }
        }

        public void Delete(Company entity)
        {
            using(repo = new CompanyRepository())
            {
                repo.Delete(entity);
            }
        }

        public Company Find(int id)
        {
            using(repo = new CompanyRepository())
            {
                return repo.Find(id);
            }
        }

        public IEnumerable<Company> Read()
        {
            using(repo = new CompanyRepository())
            {
                return repo.Read();
            }
        }

        public void Update(Company entity)
        {
            using(repo = new CompanyRepository())
            {
                repo.Update(entity);
            }
        }
    }
}