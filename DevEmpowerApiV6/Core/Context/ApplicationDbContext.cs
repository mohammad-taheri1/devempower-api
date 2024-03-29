﻿using DevEmpowerApiV6.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevEmpowerApiV6.Core.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Video> Videos { get; set; }
    public DbSet<JobCategory> JobCategories { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
