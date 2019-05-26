using System.Data.Entity;

namespace CityTransport.Repository.DbModels
{
    public class CityTransportContext : DbContext
    {
        public CityTransportContext() : base("name=CityTransportContext")
        {

        }

        public DbSet<UserDbModel> Users { get; set; }
    }
}
