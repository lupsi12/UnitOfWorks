using PersonelApp.DataAccesLayer.Repositories.Abstract;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccesLayer.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDeparmentRepository
    {
        public DepartmentRepository(PersonelContext context) : base(context)
        {
            
        }
        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
            }

        public IEnumerable<Department> GetTopDepartmentsWithPersonels()
        {
            return PersonelContext.Departments.Include("Personels").ToList();
        }
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }

    }
}
