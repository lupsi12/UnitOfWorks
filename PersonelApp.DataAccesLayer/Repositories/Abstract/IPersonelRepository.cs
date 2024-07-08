using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccesLayer.Repositories.Abstract
{
    public interface IPersonelRepository:IRepository<Personel>
    {
        IEnumerable<Personel> GetPersonelWithDepartments();
    }
}
