using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "50addda3-1c83-4089-b6a2-3206a9dd148f",
                    Email = "admin@localhost",
                    NormalizedEmail = "ADMIN@LOCALHOST",
                    UserName = "admin@localhost",
                    NormalizedUserName = "ADMIN@LOCALHOST",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd!"),
                    SecurityStamp = string.Empty,
                    FirstName = "System",
                    LastName = "Admin",

                },
                new ApplicationUser
                {
                    Id = "4475d2d7-9cc1-464a-827f-e590220067da",
                    Email = "user@localhost",
                    NormalizedEmail = "USER@LOCALHOST",
                    UserName = "user@localhost",
                    NormalizedUserName = "USER@LOCALHOST",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd!"),
                    SecurityStamp = string.Empty,
                    FirstName = "System",
                    LastName = "User",
                }
            );
        }
    }
}