using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Charts.Models
{
    [Table("NewEmployeeJoin")]
    public partial class NewEmployeeJoin
    {
        [Key]
        public int Empid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Empname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Gender { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime Joindate { get; set; }
    }
}
