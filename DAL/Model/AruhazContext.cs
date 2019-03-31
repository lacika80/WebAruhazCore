using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.Model
{
    public class AruhazContext : DbContext
    {

        public AruhazContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Photo2Product> Photo2Products { get; set; }
        public DbSet<Filter2Product> Filter2Products { get; set; }
        public DbSet<Filler> Fillers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {


            base.OnModelCreating(modelbuilder);
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //comp keys
            modelbuilder.Entity<Filter2Product>().HasKey(f2p => new { f2p.ProdId, f2p.FId });
            modelbuilder.Entity<Photo2Product>().HasKey(p2p => new { p2p.ProdId, p2p.PhotoId });
            // //bruttó ár számítása
            // modelbuilder.Entity<Product>().Property(p => p.NetPrice).HasComputedColumnSql("[BrutPrice]/(1+[VAT])");
            // //*-* kapcsolatok
            // modelbuilder.Entity<Photo2Product>().HasKey(p2p => new { p2p.PhotoId, p2p.ProdId });
            // modelbuilder.Entity<Filter2Product>().HasKey(p2p => new { p2p.FId, p2p.ProdId });
            modelbuilder.Entity<Filter2Product>().HasOne<Filter>(f2p => f2p.Filter).WithMany(f => f.Filter2Product).HasForeignKey(f2p => f2p.FId).OnDelete(DeleteBehavior.SetNull);
            modelbuilder.Entity<Filter2Product>().HasOne<Product>(f2p => f2p.Product).WithMany(p => p.Filter2Product).HasForeignKey(f2p => f2p.ProdId).OnDelete(DeleteBehavior.SetNull);

            modelbuilder.Entity<Photo2Product>().HasOne<Photo>(p2p => p2p.Photo).WithMany(p => p.Photo2Product).HasForeignKey(p2p => p2p.PhotoId).OnDelete(DeleteBehavior.SetNull);
            modelbuilder.Entity<Photo2Product>().HasOne<Product>(p2p => p2p.Product).WithMany(p => p.Photo2Product).HasForeignKey(p2p => p2p.ProdId).OnDelete(DeleteBehavior.SetNull);

            modelbuilder.Entity<Product>().HasOne<Photo>(p => p.Photo).WithMany(ph => ph.Products).HasForeignKey(p => p.PhotoId).OnDelete(DeleteBehavior.SetNull);

            modelbuilder.Entity<Product>().HasOne<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CatId).OnDelete(DeleteBehavior.SetNull);

            modelbuilder.Entity<Category>().HasOne<Photo>(C => C.Photo).WithMany(p => p.Categories).HasForeignKey(c => c.PhotoId).OnDelete(DeleteBehavior.SetNull);
            // //1-1 kapcsok
            //modelbuilder.Entity<Photo>().HasOne<Category>(p => p.Category).WithOne(c => c.Photo).HasForeignKey<Category>(c => c.PhotoId);
           // //modelbuilder.Entity<Product>().HasKey(c => new { c.CatId });
           // //modelbuilder.Entity<Product>().HasKey(c => new { c.PhotoId });
           // modelbuilder.Entity<Category>().HasOne<Photo>(c => c.Photo).WithOne(p => p.Category).HasForeignKey<Category>(c => c.PhotoId);
           //modelbuilder.Entity<Product>().HasOne<Photo>(c => c.Photo).WithOne(p => p.Product).HasForeignKey<Product>(c => c.PhotoId);
           // modelbuilder.Entity<Product>().HasOne<Category>(p => p.Category).WithOne(p => p.Product).HasForeignKey<Product>(p => p.CatId);
            //default értékek
            modelbuilder.Entity<Product>().Property(p => p.ProdCreated).HasDefaultValueSql("getdate()");
            modelbuilder.Entity<User>().Property(u => u.IsAdmin).HasDefaultValueSql("0");
            modelbuilder.Entity<Product>().Property(p => p.IsActiveProd).HasDefaultValueSql("1");
            modelbuilder.Entity<Photo>().Property(ph => ph.IsActivePhoto).HasDefaultValueSql("1");
        }
    }
}
