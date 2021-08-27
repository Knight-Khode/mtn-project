using Church_Web.Data.Db_Model;
using Church_Web.Utils.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Church_Web.Utils.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        //private IGenericRepository<Church> _Churchlist;
        //private IGenericRepository<Event> _Events;
        private IGenericRepository<User> _User;
        //private IGenericRepository<ParentComment> _ParentComment;
        //private IGenericRepository<ChildComment> _ChildComment;


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        //public IGenericRepository<Church> Churchlist => _Churchlist ??= new GenericRepository<Church>(_context);
        //public IGenericRepository<Event> UpcomingEvent => _Events ??= new GenericRepository<Event>(_context);
        public IGenericRepository<User> Users => _User ??= new GenericRepository<User>(_context);
        //public IGenericRepository<ParentComment> ParentComment => _ParentComment ??= new GenericRepository<ParentComment>(_context);
        //public IGenericRepository<ChildComment> ChildComment => _ChildComment ??= new GenericRepository<ChildComment>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
