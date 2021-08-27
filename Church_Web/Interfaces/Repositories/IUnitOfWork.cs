using Church_Web.Db_Model;
using System;
using System.Threading.Tasks;

namespace Church_Web.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Church> Churchlist { get; }
        IGenericRepository<Event> UpcomingEvent { get; }
        IGenericRepository<User> Users { get; }
        IGenericRepository<ParentComment> ParentComment { get; }
        IGenericRepository<ChildComment> ChildComment { get; }
        Task Save();
    }
}
