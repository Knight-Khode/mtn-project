using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Church_Web.Db_Model
{
    public class AppDbContext: IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                  : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<ChildComment> ChildComments { get; set; }
        public DbSet<Church> ChurchLists { get; set; }
        public DbSet<ChurchMembers> ChurchMembers { get; set; }
        public DbSet<EbuCusComments> EbuCusComments { get; set; }
        public DbSet<ParentComment> ParentComments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<VideoList> VideoLists { get; set; }
        public DbSet<Event> UpComingEvents { get; set; }

    }

}
