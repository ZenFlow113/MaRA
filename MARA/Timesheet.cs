namespace MARA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timesheet")]
    public partial class Timesheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Timesheet()
        {
            STAFF = new HashSet<STAFF>();
        }

        [Key]
        [StringLength(50)]
        public string Timesheet_ID_Num { get; set; }

        [Required]
        [StringLength(50)]
        public string Staff_ID_Num { get; set; }

        [StringLength(50)]
        public string Start_Date_Time { get; set; }

        [StringLength(50)]
        public string End_Date_Time { get; set; }

        public int? Payment_Amount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAFF> STAFF { get; set; }
    }
}
