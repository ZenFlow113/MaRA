namespace MARA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Possition")]
    public partial class Possition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Possition()
        {
            STAFF = new HashSet<STAFF>();
        }

        [Key]
        [StringLength(50)]
        public string Position_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Position_Name { get; set; }

        [StringLength(100)]
        public string Position_Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Pay_Period { get; set; }

        public int Pay_Rate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAFF> STAFF { get; set; }
    }
}
