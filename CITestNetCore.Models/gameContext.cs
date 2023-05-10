using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITestNetCore.Models
{
    public class gameContext : DbContext
    {

        public gameContext()
        {

        }

        public gameContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }

    }
}
