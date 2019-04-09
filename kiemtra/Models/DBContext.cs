namespace kiemtra.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext1")
        {
        }

        public virtual DbSet<dmsanpham> dmsanphams { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dmsanpham>()
                .Property(e => e.tenDM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sanpham>()
                .Property(e => e.tenSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sanpham>()
                .Property(e => e.xuatSU)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
