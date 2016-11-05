using System.Data.Entity.ModelConfiguration;
using MyFirstApplication.Models;

namespace MyFirstApplication.DataAccess.Mapping
{
    public class CatMap : EntityTypeConfiguration<CatModel>
    {
        public CatMap()
        {
            ToTable("Cats");

            HasKey(x => x.Id);
        }
    }
}