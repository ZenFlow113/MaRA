namespace MARA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Runner")]
    public partial class Runner
    {
        public int RunnerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryCode { get; set; }

        public virtual User User { get; set; }
    }
}
