namespace SISTEMAMVCTICONA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            Detallepedido = new HashSet<Detallepedido>();
        }

        [Key]
        public int idpedido { get; set; }

        public int idusuario { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(20)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detallepedido> Detallepedido { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
