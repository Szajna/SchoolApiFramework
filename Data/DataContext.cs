using SchoolApiFramewirk.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolApiFramewirk.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}