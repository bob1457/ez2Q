using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Core.Interfaces;

namespace ezQ.Data.Repositories
{
    public class DoctorRepository : IRepository<Doctor>
    {
        private readonly ezQDbContext _context = new ezQDbContext();

        public IEnumerable<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> FindBy(System.Linq.Expressions.Expression<Func<Doctor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Doctor entity)
        {
            //throw new NotImplementedException();
            _context.Doctors.Add(entity);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void Delete(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(IEnumerable<Doctor> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
