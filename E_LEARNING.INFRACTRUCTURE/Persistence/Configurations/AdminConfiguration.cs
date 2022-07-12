using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("admin_mst");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50);

            builder.Property(e => e.Phone).HasMaxLength(10);

            builder.HasOne(e => e.Account).WithOne(e => e.Admin).HasForeignKey<Admin>(e => e.AccountId);
        }
    }
}
