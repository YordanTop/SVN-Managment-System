using DataBaseLayer.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Repositories.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected  SvnStatusInfoContext _dbContext;

        public Repository(SvnStatusInfoContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async void Add(T Object)
        {
            if (Object == null) throw new ArgumentNullException($"The value of type:{typeof(T)} is null");

            await _dbContext.Set<T>().AddAsync(Object);
            await _dbContext.SaveChangesAsync();
        }

        public async void Delete(T Object)
        {
            if (Object == null) throw new ArgumentNullException($"The value of type:{typeof(T)} is null");

            _dbContext.Remove<T>(Object);
            await _dbContext.SaveChangesAsync();
        }

        public List<T> GetAll()
        {
            var result = _dbContext.Set<T>().ToList();

            if (result == null) throw new NullReferenceException($"The list of type: {typeof(T)} is empty");

            return result;
        }

        public async Task<T> GetById(int id) => await _dbContext.Set<T>().FindAsync(id);
        public void Update(T Entity, T newEntity)
        {
            _dbContext.Entry(Entity).CurrentValues.SetValues(newEntity);
            _dbContext.SaveChanges();
        }
    }
}
