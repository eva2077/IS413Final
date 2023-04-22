﻿using System;
using Microsoft.EntityFrameworkCore;
using Final.Models;
namespace Final.Models
{
    //Context is inheriting from DbContext
    public class Context : DbContext
    {
        //This only gets run the first time we build it
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        //stores the database inputs as Movies
        public DbSet<Movie> Movies { get; set; }
    }
}

