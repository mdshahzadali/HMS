using HMS.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.DbContexts
{
    public class HMSDbContext : DbContext
    {
        public HMSDbContext(DbContextOptions<HMSDbContext> options) : base(options){}
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
