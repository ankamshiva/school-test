using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Core.Models;

namespace School.Data.Configurations
{
    public class TeacherConfiguration: IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Address)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Grade)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Class)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .ToTable("Teachers");
        }
    }
}
