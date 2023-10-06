using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericUnitOfWork
    {
        DbContext context { get; set; }

        Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public GenericUnitOfWork(DbContext context) { 
            this.context = context;
        }

        public IGenericRepository<T> Repository<T>() where T : class { 
            if (repositories.Keys.Contains(typeof(T)))
            {
                return repositories[typeof(T)] as IGenericRepository<T>;
            }

            IGenericRepository<T> repository = new EFGenericRepository<T>(context);
            repositories.Add(typeof(T) ,repository);
            return repository;
        }
    }
}
