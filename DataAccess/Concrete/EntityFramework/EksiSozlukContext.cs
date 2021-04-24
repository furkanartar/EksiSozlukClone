using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EksiSozlukContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

        //public DbSet<OperationClaim> OperationClaims { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
