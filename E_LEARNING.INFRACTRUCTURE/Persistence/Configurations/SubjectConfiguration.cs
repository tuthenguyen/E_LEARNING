using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("subject_mst");

            builder.HasKey(e => e.Id);

            builder.HasMany(e => e.Classes).WithOne(e => e.Subject).HasForeignKey(e => e.SubjectId);
            builder.HasMany(e => e.ScoreLearnings).WithOne(e => e.Subject).HasForeignKey(e => e.SubjectId);
            builder.HasMany(e => e.Tests).WithOne(e => e.Subject).HasForeignKey(e => e.SubjectId);
        }
    }
}
