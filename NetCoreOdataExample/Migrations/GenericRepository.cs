using Microsoft.EntityFrameworkCore;
using NetCoreOdataExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetCoreOdataExample.Migrations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DataContext _dbContext;

        public GenericRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }
        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>()
                        .AsNoTracking()
                        .FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> where)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().Where(where);
        }


        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().AddAsync(entity);
            _dbContext.SaveChangesAsync();
        }

        public void Update(int id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChangesAsync();
        }


    }
}
