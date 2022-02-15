using MVCFilters_2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCFilters_2.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().Ignore(x => x.ConfirmPassword);
        }

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}