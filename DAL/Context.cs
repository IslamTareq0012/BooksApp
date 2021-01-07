using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Context : DbContext
    {
        //public Context() : base(DbContextHelper.generateOptions(SharedPackage.Configuration.Config["ConnectionString"]))
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BooksApp;Trusted_Connection=True;");
        }
       public  DbSet<Category> Category { get; set; }

       public DbSet<ApplicationType> applicationType { get; set; }
    }

}