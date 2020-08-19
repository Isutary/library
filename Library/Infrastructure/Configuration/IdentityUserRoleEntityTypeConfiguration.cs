using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Library.Infrastructure.Configuration
{
    public class IdentityUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            var userRoles = new List<IdentityUserRole<Guid>>() {
                new IdentityUserRole<Guid> {
                    UserId = new Guid("D82D7385-C6B1-4090-8128-7695C4A83F50"),
                    RoleId = new Guid("79293F5D-C7CE-4EA0-8A19-816571E14C4D")
                },
                new IdentityUserRole<Guid> {
                    UserId = new Guid("62118166-5017-4732-B744-C59E24DD7A43"),
                    RoleId = new Guid("E371F336-8278-4468-A6C7-373B9F02DB52")
                },
                new IdentityUserRole<Guid> {
                    UserId = new Guid("F3E8124A-E6EB-40DD-ADFD-976DF7F6B447"),
                    RoleId = new Guid("821764A3-1F57-4413-94AA-A178B26509EB")
                }
            };

            builder.HasData(userRoles);
        }

    }
}
