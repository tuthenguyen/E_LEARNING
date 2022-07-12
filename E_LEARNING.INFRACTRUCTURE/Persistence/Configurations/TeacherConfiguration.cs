using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("teacher_mst");

            builder.HasKey(t => t.Id);

            builder.HasOne(e => e.Account).WithOne(e => e.Teacher).HasForeignKey<Teacher>(e => e.AccounId);
            builder.HasMany(e => e.ClassTeacherReferences).WithOne(e => e.Teacher).HasForeignKey(e => e.TeacherId);
        }
    }
}
