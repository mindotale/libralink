﻿using Libralink.Domain;
using Microsoft.EntityFrameworkCore;

namespace Libralink.Persistence;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; } = null!;

    public DbSet<Author> Authors { get; set; } = null!;

    public DbSet<Genre> Genres { get; set; } = null!;

    public DbSet<Publisher> Publishers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
