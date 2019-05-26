using System.Data.Entity;

namespace Repository.DbModels
{
    public class CityTransportContext : DbContext
    {
        public CityTransportContext() : base("name=CityTransportContext")
        {

        }

        public DbSet<UserDbModel> Users { get; set; }
    }
}
