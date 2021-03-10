using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ONC.RESTful.Entities.Obra;

namespace ONC.RESTful.Data.EF6
{
    //public class BaseDataService<T> : IDataService<T> where T : IdentityBase, new()
    public class BaseDataService<T> : IDataService<T> where T : IdentityBase, new()
    {
        protected ApiDbContext Db;

        public BaseDataService()
        {
            Db = new ApiDbContext();
        }

        public List<ValidationResult> ValidateModel(T model)
        {
            ValidationContext v = new ValidationContext(model);
            List<ValidationResult> r = new List<ValidationResult>();

            bool validate = Validator.TryValidateObject(model, v, r, true);

            if (validate)
            {
                return null;
            }
            else
            {
                return r;
            }
        }

        public virtual List<T> Get(Expression<Func<T, bool>> whereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeEntities = "")
        {
            IQueryable<T> query = Db.Set<T>();

            if (whereExpression != null)
            {
                query = query.Where(whereExpression);
            }

            var entity = includeEntities.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var model in entity)
            {
                query = query.Include(model);
            }

            if (orderFunction != null)
            {
                query = orderFunction(query);
            }

            return query.ToList();
        }

        public virtual T GetById(int id)
        {
            return Db.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public virtual void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = Db.Set<T>().Find(id);
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public virtual T Create(T entity)
        {
            Db.Set<T>().Add(entity);
            Db.SaveChanges();
            return entity;
        }
    }
}
