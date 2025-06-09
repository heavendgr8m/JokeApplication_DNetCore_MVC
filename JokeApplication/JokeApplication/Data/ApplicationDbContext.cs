﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokeApplication.Models;

namespace JokeApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<JokeApplication.Models.Joke> Joke { get; set; } = default!;
        public DbSet<ApplicationUser> Users { get; set; }
    }
}
