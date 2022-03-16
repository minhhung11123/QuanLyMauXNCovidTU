namespace QLXN_DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public int ID { get; set; }

        [Required]
        [StringLength(32)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(32)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        public byte QuyenHan { get; set; }

        public bool TrangThai { get; set; }
    }
}
