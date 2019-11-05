using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models;
using System.Data.Entity;

namespace WebApplication7.DAL
{
    public class dal : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
    } 
}