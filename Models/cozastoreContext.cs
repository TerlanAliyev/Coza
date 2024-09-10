using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Coza.Models
{
    public partial class cozastoreContext : DbContext
    {
        public cozastoreContext()
        {
        }

        public cozastoreContext(DbContextOptions<cozastoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-353APLF\\SQLEXPRESS;Database=cozastore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>(entity =>
            {
                entity.ToTable("Basket");

                entity.HasOne(d => d.BasketProduct)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.BasketProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Basket__BasketPr__01142BA1");

                entity.HasOne(d => d.BasketUser)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.BasketUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Basket__BasketUs__02084FDA");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.BranchName).HasMaxLength(30);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.ColorName).HasMaxLength(50);
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.ToTable("Favorite");

                entity.HasOne(d => d.FavoriteProduct)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.FavoriteProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Favorite__Favori__04E4BC85");

                entity.HasOne(d => d.FavoriteUser)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.FavoriteUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Favorite__Favori__05D8E0BE");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photo");

                entity.HasOne(d => d.PhotoProduct)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.PhotoProductId)
                    .HasConstraintName("FK__Photo__PhotoProd__6FE99F9F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductDescreption).HasMaxLength(400);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPrice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductBranch)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductBranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Product__Product__5165187F");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Product__Product__5629CD9C");

                entity.HasOne(d => d.ProductColor)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductColorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Product__Product__534D60F1");

                entity.HasOne(d => d.ProductUser)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductUserId)
                    .HasConstraintName("FK_ProductUserId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserGender).HasMaxLength(20);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserNickName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
