﻿using dotNet_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNet_RPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
