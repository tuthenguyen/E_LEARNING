using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class ClassDetailConfiguration : IEntityTypeConfiguration<ClassDetail>
    {
        public void Configure(EntityTypeBuilder<ClassDetail> builder)
        {
            builder.ToTable("class_detail_ref");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Class).WithMany(e => e.ClassDetails).HasForeignKey(e => e.ClassId);
            builder.HasMany(x => x.ClassTeacherReferences).WithOne(e => e.ClassDetail).HasForeignKey(e => e.ClassDetailId);
        }
    }
}
