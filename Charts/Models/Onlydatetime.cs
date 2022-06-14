using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Charts.Models
{
    public partial class Onlydatetime
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column("joindate", TypeName = "date")]
        public DateTime Joindate { get; set; }
    }
}
