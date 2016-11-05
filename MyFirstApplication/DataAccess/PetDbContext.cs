using System.Data.Entity;
using MyFirstApplication.DataAccess.Mapping;
using MyFirstApplication.Models;

namespace MyFirstApplication.DataAccess
{
    public class PetDbContext : DbContext
    {
        public PetDbContext() : base("DefaultConnection") { }

        public DbSet<CatModel> Cats { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new CatMap());
        }
    }
}