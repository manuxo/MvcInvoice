using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcInvoice.Models;

namespace MvcInvoice.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {

        private MvcInvoiceContext context;

        public void Create(Company entity)
        {
            using(context = new MvcInvoiceContext())
            {
                context.Companies.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Company entity)
        {
            using(context = new MvcInvoiceContext())
            {
                context.Companies.Remove(entity);
                context.SaveChanges();
            }
        }

        public Company Find(int Id)
        {
            using(context = new MvcInvoiceContext())
            {
                var company =  context.Companies.Where(res => res.Id == Id).FirstOrDefault();
                return company;
            }
        }

        public IEnumerable<Company> Read()
        {
            using(context = new MvcInvoiceContext())
            {
                var companies = context.Companies.ToList();
                return companies;
            }
        }

        public void Update(Company entity)
        {
            using (context = new MvcInvoiceContext())
            {
                var currentCompany = context.Companies.Where(res => res.Id == entity.Id).FirstOrDefault();
                currentCompany.PhoneNumber = entity.PhoneNumber;
                currentCompany.Email = entity.Email;
                currentCompany.BusinessName = entity.BusinessName;
                currentCompany.ZipCode = entity.ZipCode;
                currentCompany.Address = entity.Address;
                context.SaveChanges();
            }
        }
    }
}