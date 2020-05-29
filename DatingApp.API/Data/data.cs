using DatingApp.api.models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.api.Data
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(@"Server=.\;Database=datingapp.db;Trusted_Connection=True;");
        }
    }
}
