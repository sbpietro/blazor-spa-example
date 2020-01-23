using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServerSideSPA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideSPA.Infra.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee> 
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Department)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Gender)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.HasOne(x => x.City)
                .WithMany(y => y.Employees)
                .HasForeignKey(x => x.CityId);

            builder.ToTable("Employee");
        }
    }
}
