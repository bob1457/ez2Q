using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Core.Interfaces;
using ezQ.Data.Interfaces;

namespace ezQ.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Data context

        private readonly IDbContext _context;
        private readonly IDbSet<T> _dbset;

        public Repository(IDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }


        //Implementation
        //

        public IEnumerable<T> GetAll()
        {
            return _dbset;
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public void Add(T entity)
        {
            try
            {

                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                _dbset.Add(entity);
                _context.SaveChanges(); //bypass uow
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var valicationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in valicationErrors.ValidationErrors)
                    {
                        msg +=
                            string.Format("Property: {0} Error: {1}", validationError.PropertyName,
                                validationError.ErrorMessage) + Environment.NewLine;
                    }
                }

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public void Delete(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
            _dbset.Remove(entity);
            _context.SaveChanges();
        }

        public void DeleteAll(IEnumerable<T> entity)
        {
            foreach (var ent in entity)
            {
                var entry = _context.Entry(ent);
                entry.State = EntityState.Deleted;
                _dbset.Remove(ent);
                _context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                //var entry = _context.Entry(entity);


                _dbset.Attach(entity);
                //entry.State = EntityState.Modified; 

                _context.Entry(entity).State = EntityState.Modified;

                _context.SaveChanges(); //bypass uow
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var valicationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in valicationErrors.ValidationErrors)
                    {
                        msg +=
                            string.Format("Property: {0} Error: {1}", validationError.PropertyName,
                                validationError.ErrorMessage) + Environment.NewLine;
                    }
                }

                var fail = new Exception(msg, dbEx);
                throw fail;
            }
        }

        public bool Any()
        {
            return _dbset.Any();
        }
    }
}
