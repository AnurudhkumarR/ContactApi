
using Microsoft.EntityFrameworkCore;

namespace ContactApi.Data
{
    public class ContactsApiDbContext : DbContext
    {
        public ContactsApiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Contact> Contacts { get; set; }
    }
}
