using ContactAppWithRESTDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ContactAppWithRESTDemo.Data
{
    public class ContactDbContext:DbContext
    {
        public string ConnectionString { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public ContactDbContext()
        {
            ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactAppWithRESTDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
