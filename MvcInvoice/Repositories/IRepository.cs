using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcInvoice.Repositories
{
    public interface IRepository<T,ID>
    {
        void Create(T entity);

        T Find(ID Id);

        IEnumerable<T> Read();

        void Update(T entity);

        void Delete(T entity);
    }
}
