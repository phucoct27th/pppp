namespace kiemtra.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maSP { get; set; }

        [StringLength(20)]
        public string tenSP { get; set; }

        [StringLength(10)]
        public string xuatSU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? namSX { get; set; }

        public double? dgia { get; set; }

        public int? maDM { get; set; }

        public virtual dmsanpham dmsanpham { get; set; }
    }
}
