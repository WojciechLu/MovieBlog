﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieBlog_Backend.Models.ModelConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Name);
            entity.Property(u => u.Email).IsRequired();
            entity.Property(u => u.Password).IsRequired();
            entity.HasOne(u => u.ToWatch)
                .WithOne(l => l.Owner)
                .HasForeignKey<ListToWatch>(l => l.OwnerId);
        }
    }
}