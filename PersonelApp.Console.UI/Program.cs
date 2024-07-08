using PersonelApp.DataAccesLayer;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Console.UI
{
     class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.DeparmentRepository.Add(new Department() { Name = "IT", IsActive = true, CreatedDate = DateTime.Now });
            unitOfWork.PersonelRepository.Add(new Personel() { Name = "ISIL", IsActive = true, CreatedDate = DateTime.Now });

            unitOfWork.Complete();

        }
    }
}
