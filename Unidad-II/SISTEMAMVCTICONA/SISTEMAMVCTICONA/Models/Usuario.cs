namespace SISTEMAMVCTICONA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Pedido = new HashSet<Pedido>();
        }

        [Key]
        public int idusuario { get; set; }

        public int idtipousuario { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        [StringLength(100)]
        public string clave { get; set; }

        [StringLength(20)]
        public string nombre { get; set; }

        [StringLength(20)]
        public string apellido { get; set; }

        [StringLength(50)]
        public string email { get; set; }
        [StringLength(1)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }


        public List<Usuario> Listar()
        {//devuelve una coleccion
            var objUsuario = new List<Usuario>();
            try
            {
                //establecer el origen de la fuente de datos
                using (var db = new Model_Ventas())
                {
                    //sentencia LINQ
                    objUsuario = db.Usuario.Include("TipoUsuario").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objUsuario;
        }
        public Usuario Obtener(int id)
        {
            var objUsuario = new Usuario();
            try
            {
                using (var db = new Model_Ventas())
                {
                    objUsuario = db.Usuario.Include("TipoUsuario")
                        .Where(x => x.idusuario == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objUsuario;
        }
        public List<Usuario> Buscar(string criterio)
        {
            var objUsuario = new List<Usuario>();

            string estadousu = "";
            if (criterio == "Activo") estadousu = "A";
            if(criterio == "Inactivo") estadousu = "I";

            try
            {
                //establece el origen de la fuente de datos
                using (var db = new Model_Ventas())
                {
                    //sentencia LINQ
                    objUsuario = db.Usuario.Include("TipoUsuario")
                        .Where(x => x.TipoUsuario.nombre.Contains(criterio) ||
                                    x.apellido.Contains(criterio) ||
                                    x.email.Contains(criterio) ||
                                    x.estado == estadousu)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objUsuario;
        }
        public void Guardar()
        {
            try
            {
                using (var db = new Model_Ventas())
                {
                    if (this.idusuario > 0)
                    {
                        //si existe un valor en la DB la modifica
                        db.Entry(this).State = EntityState.Modified;
                    }
                    else
                    {
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
