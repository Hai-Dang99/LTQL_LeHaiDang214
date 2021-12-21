using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050214.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }
        public virtual DbSet<LopHoc214> LopHoc214 { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
