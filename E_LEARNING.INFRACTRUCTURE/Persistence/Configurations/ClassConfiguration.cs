using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("class_mst");

            builder.HasKey(x => x.Id);

            builder.HasOne(e => e.Subject).WithMany(e => e.Classes).HasForeignKey(e => e.SubjectId);
            builder.HasMany(e => e.Students).WithOne(e => e.Class).HasForeignKey(e => e.ClassId);
            builder.HasMany(e => e.ClassDetails).WithOne(e => e.Class).HasForeignKey(e => e.ClassId);
        }
    }
}
