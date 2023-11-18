using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "4475d2d7-9cc1-464a-827f-e590220067da",
                    UserId = "50addda3-1c83-4089-b6a2-3206a9dd148f"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "50addda3-1c83-4089-b6a2-3206a9dd148e",
                    UserId = "4475d2d7-9cc1-464a-827f-e590220067da"
                }
            );
        }
    }
}