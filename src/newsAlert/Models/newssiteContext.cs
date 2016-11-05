using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace newsAlert.Models
{
    public partial class newssiteContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //   // optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=newssite;Trusted_Connection=True;");
        //}
        public newssiteContext(DbContextOptions<newssiteContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__tmp_ms_x__3ED78766B8EF0636");

                entity.ToTable("posts");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostCatagory)
                    .HasColumnName("post_catagory")
                    .HasMaxLength(50);

                entity.Property(e => e.PostDescription)
                    .HasColumnName("post_Description")
                    .HasMaxLength(300);

                entity.Property(e => e.PostImage)
                    .HasColumnName("post_image")
                    .HasMaxLength(60);

                entity.Property(e => e.PostName)
                    .HasColumnName("post_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<Videopost>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PK__tmp_ms_x__3214EC07DF85E1E9");

                entity.ToTable("videopost");

                entity.Property(e => e.VideoId).HasColumnName("video_Id");

                entity.Property(e => e.VideoCategory)
                    .HasColumnName("video_category")
                    .HasMaxLength(30);

                entity.Property(e => e.VideoDiscription)
                    .HasColumnName("video_discription")
                    .HasMaxLength(100);

                entity.Property(e => e.VideoEmbed)
                    .HasColumnName("video_embed")
                    .HasMaxLength(100);

                entity.Property(e => e.VideoName)
                    .HasColumnName("video_name")
                    .HasMaxLength(50);
            });
        }

        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Videopost> Videopost { get; set; }
    }
}