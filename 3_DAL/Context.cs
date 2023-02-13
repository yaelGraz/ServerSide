using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
using Repository.Interfaces;
using System.Data;


namespace Server.Repository
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<Person> Persons { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //  modelBuilder.Entity<Person>().OwnsOne(x => x.Children);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9K91Q1V\SQLEXPRESS; Initial Catalog=PersonDB; Integrated Security = True; TrustServerCertificate=True ");
            optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer(@"Data Source=DESKTOP-9K91Q1V\SQLEXPRESS; Initial Catalog =PersonDB; Integrated Security = True; TrustServerCertificate=True ");
        }

    }
}