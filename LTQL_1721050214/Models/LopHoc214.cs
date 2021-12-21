using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL_1721050214.Models
{

    [Table("LopHoc214")]
    public class LopHoc214
    {
        [Key]
        [Display(Name = "Mã Lớp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLop { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Lớp")]
        public string TenLop { get; set; }
    }
}