using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LeThiHang_22.Models
{
    public partial class LeThiHang_22 : DbContext
    {
        public LeThiHang_22()
            : base("name=LeThiHang_22")
        {
        }

        
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNhaCungCap);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.TenNhaCungCap)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenSanPham)
                .IsUnicode(false);
        }
    }
}
