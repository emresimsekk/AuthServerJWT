using AuthServerJWT.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Data.Configuration
{
    class RefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshToken>
    {
        public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
        {
            builder.HasKey(u => u.UserID);
            builder.Property(u => u.Code).IsRequired().HasMaxLength(200);
            
        }
    }
}
