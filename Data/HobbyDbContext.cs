﻿using Microsoft.EntityFrameworkCore;
using PaginationDemo.Entities;

namespace PaginationDemo.Data
{
    public class HobbyDbContext : DbContext
    {
        public HobbyDbContext(DbContextOptions<HobbyDbContext> options)
            : base(options)
        {

        }

        public DbSet<Hobby> Hobbies { get; set; }
    }
}
