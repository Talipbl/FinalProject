using Core.Entities.Concretes;
using Entities.Concretes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFrameworks
{
    public class FinalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R2TQ29K; Database=Northwind; Integrated Security=True;");
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
