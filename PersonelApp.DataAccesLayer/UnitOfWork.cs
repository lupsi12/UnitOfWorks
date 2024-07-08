using PersonelApp.DataAccesLayer.Repositories.Abstract;
using PersonelApp.DataAccesLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccesLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonelContext _personelContext;
        public UnitOfWork(PersonelContext context)
        {
            _personelContext = context;
            DeparmentRepository = new DepartmentRepository(_personelContext);
            PersonelRepository = new PersonelRepository(_personelContext);
        }
        public IDeparmentRepository DeparmentRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
           return _personelContext.SaveChanges();
        }

        public void Dispose()
        {
            _personelContext.Dispose();
        }
    }
}
