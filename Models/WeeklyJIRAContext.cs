using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeeklyJIRAStatus.Models
{
    public class WeeklyJIRAContext : DbContext
    {
        public WeeklyJIRAContext(DbContextOptions<WeeklyJIRAContext> options) : base(options)
        {

        }

        public DbSet<WeeklyJIRA> Weekly_JIRA { get; set; }
    }
}
