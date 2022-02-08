using cargomanagementsystem.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.DAL.Data
{
    public class cargomanagementDbContext : DbContext
    {
        public cargomanagementDbContext(DbContextOptions<cargomanagementDbContext>options):base(options)
        {

        }
        public DbSet<cargomanagementRegister>Register { get; set; }
        public DbSet<Cust_details> Customer_Details { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
