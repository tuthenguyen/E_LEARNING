using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("account_mst");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Username).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Password).HasMaxLength(256);

            builder.Property(e => e.Email).HasMaxLength(100);

            builder.Property(e => e.Phone).HasMaxLength(10);

            builder.Property(e => e.Type).HasMaxLength(500);

            builder.HasOne(e => e.Admin).WithOne(e => e.Account).HasForeignKey<Account>(e => e.AdminId);
            builder.HasOne(e => e.Student).WithOne(e => e.Account).HasForeignKey<Account>(e => e.StudentId);
            builder.HasOne(e => e.Teacher).WithOne(e => e.Account).HasForeignKey<Account>(e => e.TeacherId);
        }
    }
}
