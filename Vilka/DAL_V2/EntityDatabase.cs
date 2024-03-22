using DAL_V2.Entity;
using DAL_V2.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2
{
    public class EntityDatabase : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Word> Word { get; set; }
        public DbSet<KeyParams> KeyLink { get; set; }

        public EntityDatabase()
        {
            Database.EnsureCreated();   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=NewBaseTest2;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Cart)
                .WithOne(c => c.Product)
                .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Word>()
                .HasMany(w => w.PrpductLink)
                .WithOne(kp => kp.KeyWords)
                .HasForeignKey(kp => kp.KeyWordsId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.KeyWords)
                .WithOne(kp => kp.Product)
                .HasForeignKey(kp => kp.ProductId);
        }
    }
}
