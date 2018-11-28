namespace sac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOtorgante")]
    public partial class tblOtorgante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOtorgante()
        {
            tblLibros = new HashSet<tblLibros>();
        }

        [Key]
        public int idotorgante { get; set; }

        [StringLength(60)]
        public string nombres { get; set; }

        [StringLength(60)]
        public string apellidos { get; set; }

        [StringLength(20)]
        public string genero { get; set; }

        [StringLength(9)]
        public string telefono { get; set; }

        [StringLength(100)]
        public string correo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha")]
        public DateTime? fechanacimiento { get; set; }

        [StringLength(100)]
        public string lugarnacimiento { get; set; }

        [StringLength(60)]
        public string municipio { get; set; }

        [StringLength(30)]
        public string departamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLibros> tblLibros { get; set; }
    }
}
