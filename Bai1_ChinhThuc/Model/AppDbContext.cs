using Bai1_ChinhThuc.Model.Blog;
using Bai1_ChinhThuc.Model.Product;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bai1_ChinhThuc.Model
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }

        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductCategoryProduct> ProductCategoryProducts { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(c => c.Slug)
                        .IsUnique();
            });
            modelBuilder.Entity<PostCategory>(entity =>
            {
                entity.HasKey(c => new {c.PostId, c.CategoryId});
            });
            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(p => p.Slug)
                            .IsUnique();
            });

            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.HasIndex(c => c.Slug)
                        .IsUnique();
            });
            modelBuilder.Entity<ProductCategoryProduct>(entity =>
            {
                entity.HasKey(c => new { c.ProductId, c.CategoryProductId });
            });
            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasIndex(p => p.Slug)
                            .IsUnique();
            });
        }
    }
}
