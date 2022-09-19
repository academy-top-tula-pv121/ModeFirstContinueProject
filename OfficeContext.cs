using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ModeFirstContinueProject
{
    internal class OfficeContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<City> Cities => Set<City>();

        public OfficeContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=MyOffice;Integrated Security=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<User>()
        //    //            .HasOne(u => u.Company)
        //    //            .WithMany(c => c.Users)
        //    //            .OnDelete(DeleteBehavior.Cascade);


        //    //modelBuilder.Entity<User>()
        //    //            .HasOne(u => u.Company)
        //    //            .WithMany(c => c.Users)
        //    //            .HasForeignKey(u => u.CompanyId);
        //}
    }
}
