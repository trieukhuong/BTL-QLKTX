using System.Data.Entity;

namespace BTL_QLKTX.Models
{
    public partial class QLKTXDbContext : DbContext
    {
        public QLKTXDbContext() : base("name=QLKTXDbContext")
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonId)
            .IsUnicode(false);
        }
    }
}