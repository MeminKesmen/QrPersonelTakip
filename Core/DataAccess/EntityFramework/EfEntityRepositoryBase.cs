using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext context = new TContext();

        public void Add(TEntity entity)
        {
            using(TContext context = new TContext()) { 
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;//Ekleme işlemi yapılacağını bildirdik. 

                context.SaveChanges();//İşlemleri gerçekleştir.
            }

        }
        public void Delete(TEntity entity)
        {
           

                var deletedEntity = context.Entry(entity);

                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();
           

        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {


            return context.Set<TEntity>().SingleOrDefault(filter);

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            //filter boş mu     EVET ise bütün datayı döndür           HAYIR ise filtreyi uygula 
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

        }

        public void Update(TEntity entity)
        {

            
                var updatedEntity = context.Entry(entity);

                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();
            

        }
    }
}
