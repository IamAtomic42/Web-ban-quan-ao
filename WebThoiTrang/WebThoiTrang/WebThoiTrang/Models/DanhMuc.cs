namespace WebThoiTrang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            LoaiSP = new HashSet<LoaiSP>();
        }

        [Key]
        public int MaDM { get; set; }

        [Required]
        [StringLength(80)]
        public string TenDM { get; set; }

        [StringLength(100)]
        public string AnhDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiSP> LoaiSP { get; set; }
    }
}
