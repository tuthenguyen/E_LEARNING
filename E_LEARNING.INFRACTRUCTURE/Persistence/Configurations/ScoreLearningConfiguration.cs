using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class ScoreLearningConfiguration : IEntityTypeConfiguration<ScoreLearning>
    {
        public void Configure(EntityTypeBuilder<ScoreLearning> builder)
        {
            builder.ToTable("core_learming_mst");

            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Student).WithMany(e => e.ScoreLearnings).HasForeignKey(e => e.StudentId);
            builder.HasOne(e => e.Subject).WithMany(e => e.ScoreLearnings).HasForeignKey(e => e.SubjectId);
        }
    }
}
