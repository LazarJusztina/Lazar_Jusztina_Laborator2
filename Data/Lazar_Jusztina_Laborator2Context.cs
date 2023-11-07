﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lazar_Jusztina_Laborator2.Models;

namespace Lazar_Jusztina_Laborator2.Data
{
    public class Lazar_Jusztina_Laborator2Context : DbContext
    {
        public Lazar_Jusztina_Laborator2Context (DbContextOptions<Lazar_Jusztina_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Lazar_Jusztina_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Lazar_Jusztina_Laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Lazar_Jusztina_Laborator2.Models.Author>? Author { get; set; }
    }
}
