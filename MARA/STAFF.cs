namespace MARA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STAFF")]
    public partial class STAFF
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Staff_ID_Num { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Date_of_Birth { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Position_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Position_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Position_Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Email_Address { get; set; }

        public virtual Possition Possition { get; set; }

        public virtual Timesheet Timesheet { get; set; }
    }
}
