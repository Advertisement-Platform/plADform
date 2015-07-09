using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.Models
{
    public class MainDbContext : DbContext
    {
        //public MainDbContext()
        //    : base("Data Source=tcp:wusmvmcf12.database.windows.net,1433;Initial Catalog=Advertisement;Persist Security Info=True;User ID=hometesting;Password=Home@testing")
        //{
        //    //Database.SetInitializer<MainDbContext>(new DropCreateDatabaseIfModelChanges<MainDbContext>());
        //}

        public DbSet<Person> PersonCollection { get; set; }
        public DbSet<Advertisement> AdvertisementCollection { get; set; }
        public DbSet<Catagory> CategoryCollection { get; set; }
        public DbSet<Client> ClientCollection { get; set; }
        public DbSet<Vehicle> VehicleCollection { get; set; }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The number of state entries written to the underlying database. This can include
        /// state entries for entities and/or relationships. Relationship state entries are created for
        /// many-to-many relationships and relationships where there is no foreign key property
        /// included in the entity class (often referred to as independent associations).
        /// </returns>
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
