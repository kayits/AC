namespace sac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHistorial")]
    public partial class tblHistorial
    {
        [Key]
        public int Id_Historial { get; set; }

        public int Id_Caso { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Final { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string Archivo { get; set; }

        public virtual tblCasos tblCasos { get; set; }
    }
}
