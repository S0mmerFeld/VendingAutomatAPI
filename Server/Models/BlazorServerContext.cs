using System;
using Blazor.Client.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Blazor.Server.Models
{
    public partial class BlazorServerContext : DbContext
    {
        public BlazorServerContext()
        {
        }

        public BlazorServerContext(DbContextOptions<BlazorServerContext> options)
            : base(options)
        {
        }
               
      
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Name=BlazorServer");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.AboutMe).HasColumnName("about_me");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("created_date");

                entity.Property(e => e.DarkTheme).HasColumnName("dark_theme");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("DATETIME")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address");

                entity.Property(e => e.FirstName).HasColumnName("first_name");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Notifications).HasColumnName("notifications");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.ProfilePicDataUrl).HasColumnName("profile_pic_data_url");

                entity.Property(e => e.ProfilePictureUrl).HasColumnName("profile_picture_url");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
