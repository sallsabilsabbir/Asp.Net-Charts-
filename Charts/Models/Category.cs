using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Charts.Models
{
    public partial class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
