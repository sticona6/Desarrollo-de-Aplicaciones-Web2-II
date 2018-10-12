namespace SISTEMAMVCTICONA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            Detallepedido = new HashSet<Detallepedido>();
        }

        [Key]
        public int idproducto { get; set; }

        public int idcategoria { get; set; }

        [Required]
        [StringLength(20)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public int precio { get; set; }

        public int stock { get; set; }

        [Required]
        [StringLength(1)]
        public string portada { get; set; }

        public int importancia { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detallepedido> Detallepedido { get; set; }
    }
}
