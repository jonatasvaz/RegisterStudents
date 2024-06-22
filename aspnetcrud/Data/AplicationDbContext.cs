﻿using aspnetcrud.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnetcrud.Data
{
  
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options) 
        {
            
        }
       public DbSet<Student> Students { get; set; } 
    }
}
