namespace sac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblLibros
    {
        [Key]
        public int idlibros { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha")]
        public DateTime? fecha { get; set; }

        [StringLength(200)]
        public string afiliado { get; set; }

        [StringLength(100)]
        public string instrumento { get; set; }

        [StringLength(100)]
        public string folios { get; set; }

        [StringLength(100)]
        public string libro { get; set; }

        public string img { get; set; }

        public int idotorgante { get; set; }

        public int idfavorde { get; set; }

        public virtual tblAfavorde tblAfavorde { get; set; }

        public virtual tblOtorgante tblOtorgante { get; set; }
    }
}
