using System.Data.Entity;
namespace EfDbApp.Models

{

    public class MobileContext : DbContext

    {
        public MobileContext() : base("DefaultConnection")
        {

        }

        public DbSet<Phone> Phones { get; set; }

    }
}
