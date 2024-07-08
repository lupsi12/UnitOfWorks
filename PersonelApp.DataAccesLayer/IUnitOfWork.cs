using PersonelApp.DataAccesLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccesLayer
{
    public interface IUnitOfWork:IDisposable
    {
        IDeparmentRepository DeparmentRepository { get;  }
        IPersonelRepository PersonelRepository { get; }
        int Complete();
    }
}
