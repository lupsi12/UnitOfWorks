using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccesLayer.Repositories.Abstract
{
    public interface IDeparmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartments(int count);
        IEnumerable<Department> GetTopDepartmentsWithPersonels();
    }
}
