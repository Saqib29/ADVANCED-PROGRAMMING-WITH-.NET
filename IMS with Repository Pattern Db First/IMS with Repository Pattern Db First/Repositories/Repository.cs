using IMS_with_Repository_Pattern_Db_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_with_Repository_Pattern_Db_First.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected InventoryDbContext context = new InventoryDbContext();
        public void Delete(int id)
        {
            context.Set<TEntity>().Remove(Get(id));
            context.SaveChanges();
        }
        
        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

    }
}