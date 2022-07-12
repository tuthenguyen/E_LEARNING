using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class ClassDetailRefTeacherRefConfiguration : IEntityTypeConfiguration<ClassTeacherReference>
    {
        public void Configure(EntityTypeBuilder<ClassTeacherReference> builder)
        {
            builder.ToTable("class_teacher_ref");

            builder.HasKey(e => new { e.TeacherId, e.ClassDetailId });

            builder.HasOne(e => e.ClassDetail).WithMany(e => e.ClassTeacherReferences).HasForeignKey(e => e.ClassDetailId);
            builder.HasOne(e => e.Teacher).WithMany(e => e.ClassTeacherReferences).HasForeignKey(e => e.TeacherId);
        }
    }
}
