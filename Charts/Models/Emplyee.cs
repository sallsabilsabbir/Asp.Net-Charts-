using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Charts.Models
{
    public partial class Emplyee
    {
        [Key]
        public Guid Id { get; set; }
        [Column("emplyee_Id")]
        public int EmplyeeId { get; set; }
        [Column("First_Name")]
        public string FirstName { get; set; } = null!;
        [Column("Last_Name")]
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        [Column("Phone_Number")]
        public string PhoneNumber { get; set; } = null!;
        public int Salary { get; set; }
        public string Department { get; set; } = null!;
        public DateTime CreatedDateTime { get; set; }
    }
}
