using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeThiHang_22.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [Key]
        public int MaNhaCungCap { get; set; }
        [MaxLength(50)]
        public string TenNhaCungCap { get; set; }
        
    }
}