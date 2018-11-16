namespace MvcInvoice.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MvcInvoiceContext : DbContext
    {
        public MvcInvoiceContext()
            : base("name=MvcInvoiceContext")
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}