using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PersonelApp.Domains;

namespace PersonelApp.DataAccesLayer
{
    public class PersonelContext : DbContext
    {
        public PersonelContext():base("PersonelContext")
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }

    }
}
