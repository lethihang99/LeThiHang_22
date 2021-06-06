using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeThiHang_22.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        public string MaSanPham { get; set; }
        [MaxLength(20)]
        public string TenSanPham { get; set; }
        [MaxLength(50)]
        public int MaNhaCungCap { get; set; }
    }
}