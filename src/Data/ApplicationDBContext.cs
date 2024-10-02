using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace api.src.Data
{
   public class ApplicationDBContext(DbContextOptions dBContextOptions) : DbContext(dBContextOptions)
    {
        public DbSet<User> Users {get; set;} = null!;
    }
}