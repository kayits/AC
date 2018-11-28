namespace sac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPersonal")]
    public partial class tblPersonal
    {
        [Key]
        public int Id_Personal { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        public string Genero { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Nacimiento { get; set; }

        public int? Id_EstadoRegistro { get; set; }

        public virtual tblEstadosRegistros tblEstadosRegistros { get; set; }
    }
}
