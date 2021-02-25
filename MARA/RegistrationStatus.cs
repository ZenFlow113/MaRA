namespace MARA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistrationStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RegistrationStatusId { get; set; }

        [Column("RegistrationStatus")]
        [Required]
        [StringLength(80)]
        public string RegistrationStatus1 { get; set; }
    }
}
