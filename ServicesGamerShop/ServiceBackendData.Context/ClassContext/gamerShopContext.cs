using ServiceBackendData.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ServiceBackendData.Context
{
    public partial class gamerShopContext : DbContext
    {
        public gamerShopContext()
            : base("name=gamerShopConnection")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryProduct> CategoryProduct { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<ImageProduct> ImageProduct { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<Invoicing> Invoicing { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryProduct)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Adrdress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Comment)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Invoice)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Qualification)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ImageProduct>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetail)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.Invoicing)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoicing>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Invoicing>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Invoicing>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoicing>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Invoicing>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethod>()
                .HasMany(e => e.Invoice)
                .WithRequired(e => e.PaymentMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CategoryProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Comment)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ImageProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InvoiceDetail)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Qualification)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Qualification>()
                .Property(e => e.Rating)
                .HasPrecision(5, 2);
        }
    }
}
