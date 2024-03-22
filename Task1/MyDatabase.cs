using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class MyDatabase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<KeyParams> KeyParamses { get; set; }

        public MyDatabase()
        {
            Database.EnsureCreated();
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RelationsModelsDb;Trusted_Connection=True;TrustServerCertificate=True;")
                .LogTo(e => Debug.WriteLine(e));
        }
    }
}
