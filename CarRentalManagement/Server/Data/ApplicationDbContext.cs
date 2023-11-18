﻿using CarRentalManagement.Server.Configurations.Entities;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarRentalManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColorSeedConfiguration());
            builder.ApplyConfiguration(new MakesSeedConfiguration());
            builder.ApplyConfiguration(new ModelsSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

        }
    }
}