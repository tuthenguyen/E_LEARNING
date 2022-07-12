using E_LEARNING.CORE.BusinessDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Persistence.Configurations
{
    public class Studentconfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("student_mst");

            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Account).WithOne(e => e.Student).HasForeignKey<Student>(e => e.AccountId);
            builder.HasOne(e => e.Class).WithMany(e => e.Students).HasForeignKey(e => e.ClassId);
        }
    }
}
