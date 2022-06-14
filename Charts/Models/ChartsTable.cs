using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Charts.Models
{
    [Keyless]
    [Table("ChartsTable")]
    public partial class ChartsTable
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string MonthsName { get; set; } = null!;
        public int Value { get; set; }
    }
}
