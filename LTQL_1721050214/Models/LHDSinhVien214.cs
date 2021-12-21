using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL_1721050214.Models
{

    [Table("LHDSinhVien214")]
    public class LHDSinhVien214
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        [StringLength(20)]
        public int MaSinhVien { get; set; }
        [StringLength(50)]
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Họ Tên")]
        public int MaLop { get; set; }
        [ForeignKey("Malop")]
        public virtual LopHoc214 LopHoc214 { get; set; }
    }
}