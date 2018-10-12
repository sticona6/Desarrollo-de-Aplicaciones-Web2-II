namespace SISTEMAMVCTICONA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    using System.Linq;
    using System.Data.Entity;

    [Table("TipoUsuario")]
    public partial class TipoUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int idtipousuario { get; set; }

        [Required]
        [StringLength(30)]
        public string nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }

        public List<TipoUsuario> Listar() {//devuelve una coleccion
            var objTipo = new List<TipoUsuario>();
            try {
                //establecer el origen de la fuente de datos
                using (var db = new Model_Ventas()) {
                    //sentencia LINQ
                    objTipo = db.TipoUsuario.ToList();
                }
            }
            catch (Exception) {
                throw;
            }
            return objTipo;
        }
        public TipoUsuario Obtener (int id){
            var objTipo = new TipoUsuario();
            try
            {
                using (var db = new Model_Ventas())
                {
                    objTipo = db.TipoUsuario
                        .Where(x => x.idtipousuario == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objTipo;
        }
        public List<TipoUsuario> Buscar(string criterio)
        {
            var objTipo = new List<TipoUsuario>();
            try
            {
                using (var db = new Model_Ventas())
                {
                    objTipo = db.TipoUsuario
                        .Where(x => x.idtipousuario.ToString().Equals(criterio) || 
                                    x.nombre.Contains(criterio))
                        .ToList();
                }
            }
            catch (Exception)
            {
               throw;
            }
            return objTipo;
        }
        public void Guardar()
        {
            try
            {
                using (var db = new Model_Ventas())
                {
                    if (this.idtipousuario > 0) {
                        //si existe un valor en la DB la modifica
                        db.Entry(this).State = EntityState.Modified;
                    }
                    else {
                        //agrega un nuevo valor
                        db.Entry(this).State = EntityState.Added;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Eliminar()
        {
            try
            {
                using (var db = new Model_Ventas())
                {
                    //si existe un valor en la DB la modifica
                    db.Entry(this).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
