using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactApi.Models
{
    public class ContactDb:DbContext
    {
        private readonly IConfiguration configuration;

        public ContactDb(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("ContactCon"));
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;initial catalog=contactDb;integrated security=true");
        }
    }
}
